using ERPProject.App.Utilities;
using ERPProject.Controls;
using ERPProject.Model;
using System;
using System.Collections.Generic;
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
        void refereshAmount()
        {
            var totalAmount = orderDetails.Sum(x => x.Quantity * x.Amount);
            _totalAmount.Text = totalAmount.ToString();

        }
        void refreshOrderDetails()
        {
            for (int i = 0; i < orderDetails.Count; i++)
            {
                var item = orderDetails[i];
                var form = new ERPProductDetailsForm(i, productModels, item);
                this._orderDetailPanel.Controls.Add(form);
            }
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
    }
}
