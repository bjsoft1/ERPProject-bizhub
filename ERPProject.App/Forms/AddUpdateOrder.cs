using Dapper;
using ERPProject.App.Utilities;
using ERPProject.Controls;
using ERPProject.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace ERPProject.App.Forms
{
    public partial class AddUpdateOrder : ERPForm
    {
        public AddUpdateOrder()
        {
            InitializeComponent();
        }
        IEnumerable<ProductModel> productModels;
        IEnumerable<CustomerModel> customerModels;
        
        List<FormSubmittedEventArgs> orderDetails = new List<FormSubmittedEventArgs>();
        private void _addRow_Click(object sender, EventArgs e)
        {
            var data = new FormSubmittedEventArgs(0, 0);
            orderDetails.Add(data);
            var form = new ERPProductDetailsForm(orderDetails.Count, productModels, data);
            form.OnFormValueChange += new ERPProject.Controls.OnOrderFormValueChange(this.OnFormValueChange);
            form.OnFormRemoveClick += new ERPProject.Controls.OnOrderFormRemoveClick(this.OnFormRemoveClick);

            this._orderDetailPanel.Controls.Add(form);
            refereshAmount();
        }
        double refereshAmount()
        {
            var totalAmount = orderDetails.Sum(x => x.Quantity * x.Amount);
            _totalAmount.Text = totalAmount.ToString();
        return totalAmount;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //TODO: FIlter
            var query = $"select {nameof(ProductModel.Id)},{nameof(ProductModel.ProductName)} From Store.Products";
            this.productModels = ERPSqlHelper.ExcuteEnumerable<ProductModel>(query);

            query = $"select {nameof(CustomerModel.Id)},{nameof(CustomerModel.CustomerName)} From Person.Customers";
            this.customerModels = ERPSqlHelper.ExcuteEnumerable<CustomerModel>(query);

            this._customer.DataSource = customerModels;
            this._customer.DisplayMember = nameof(CustomerModel.CustomerName);
            this._customer.ValueMember = nameof(CustomerModel.Id);
        }
        protected override void OnSubmitForm()
        {
            //base.OnSubmitForm();

            if (_customer.SelectedValue == null)
            {
                ERPMessage.OK("Please Slect Customer", "Validation Waring.");
                return;
            }
            else if (orderDetails.Count == 0)
            {
                ERPMessage.OK("Please Add Order Details", "Validation Waring.");
                return;
            }

            for (var i = 0; i < orderDetails.Count; i++)
            {
                var item = orderDetails[i];
                var childs = _orderDetailPanel.GetChilds();
                var child = childs[i];
                if (item.Amount <= 0)
                {
                    ERPMessage.OK("Amount Is Required.", "Validation Waring.");
                    if (childs.Count() > i)
                    {
                        child.ForeColor = Color.Red;
                    }
                    return;
                }
                else
                    child.ForeColor = Color.Black;

                if (item.Quantity <= 0)
                {
                    ERPMessage.OK("Quantity Is Required.", "Validation Waring.");
                    if (childs.Count() > i)
                    {
                        child.ForeColor = Color.Red;
                    }
                    return;
                }
                else
                    child.ForeColor = Color.Black;

                if (item.ProductId <= 0)
                {
                    ERPMessage.OK("Product Is Required.", "Validation Waring.");
                    if (childs.Count() > i)
                    {
                        child.ForeColor = Color.Red;
                    }
                    return;
                }
                else
                    child.ForeColor = Color.Black;
            }

            //TODO: get From Login Details
            var curentUserId = 1;

            var dp = new DynamicParameters();
            dp.Add("CustomerId", _customer.SelectedValue);
            dp.Add("TotalAmount", refereshAmount());
            dp.Add("CreationTime", DateTime.Now);
            dp.Add("CreatorUserID", curentUserId);
            dp.Add("@json", System.Text.Json.JsonSerializer.Serialize(orderDetails));

            //TODO: Convert this into Stored Procedure
            var query = @"
    INSERT INTO [Order].[Orders] (CustomerId, TotalAmount, CreationTime, CreatorUserID) VALUES (@CustomerId, @TotalAmount, @CreationTime, @CreatorUserID);

    DECLARE @OrderId int = SCOPE_IDENTITY();

    INSERT INTO [Order].[OrderDetails] (CreationTime, CreatorUserID, ProductId, Quantity, Amount, OrderId)
    SELECT @CreationTime, @CreatorUserId, ProductId, Quantity, Amount, @OrderId
    FROM OPENJSON(@json)
    WITH (
        ProductId int,
        Quantity int,
        Amount real
    );
    SELECT @OrderId;
";

            try
            {
                var orderId = ERPSqlHelper.ExcuteFirstOrDefault<int>(query, dp);
                if(orderId > 0)
                {
                    ERPMessage.OK("Record Successfully Inserted.", "Success", MessageBoxIcon.Information);
                    this.orderDetails = new List<FormSubmittedEventArgs>();
                    var childs = this._orderDetailPanel.GetChilds();
                    foreach (var item in childs)
                        _orderDetailPanel.Controls.Remove(item);
                }
                else
                    ERPMessage.OK("Record Cannot Successfully Inserted.", "Faild", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ERPMessage.OK(ex.Message);
            }


        }
        //void refreshOrderDetails()
        //{
        //    for (int i = 0; i < orderDetails.Count; i++)
        //    {
        //        var item = orderDetails[i];
        //        var form = new ERPProductDetailsForm(i, productModels, item);
        //        this._orderDetailPanel.Controls.Add(form);
        //    }
        //}

        private void OnFormValueChange(object sender, FormSubmittedEventArgs e)
        {
            refereshAmount();
            //Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(orderDetails));
        }
        private void OnFormRemoveClick(object sender, FormSubmittedEventArgs e, ERPProductDetailsForm removeForm)
        {
            this._orderDetailPanel.Controls.Remove(removeForm);
            this.orderDetails.Remove(e);
            refereshAmount();
        }

        private void _save_Click(object sender, EventArgs e)
        {
            this.OnSubmitForm();
        }
    }
}
