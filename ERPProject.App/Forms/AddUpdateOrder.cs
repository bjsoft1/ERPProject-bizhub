using ERPProject.Controls;
using ERPProject.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ERPProject.App.Forms
{
    public partial class AddUpdateOrder : ERPForm
    {
        public AddUpdateOrder()
        {
            InitializeComponent();
        }
        List<ProductModel> productModels;
        
        List<FormSubmittedEventArgs> orderDetails = new List<FormSubmittedEventArgs>();
        private void _addRow_Click(object sender, EventArgs e)
        {
            var data = new FormSubmittedEventArgs(0, 0);
            orderDetails.Add(data);
            var form = new ERPProductDetailsForm(orderDetails.Count, productModels, data);
            form.OnFormValueChange += new ERPProject.Controls.OnOrderFormValueChange(this.OnFormValueChange);
            form.OnFormRemoveClick += new ERPProject.Controls.OnOrderFormRemoveClick(this.OnFormRemoveClick);

            this._orderDetailPanel.Controls.Add(form);
            //refreshOrderDetails();
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

        private void OnFormValueChange(object sender, FormSubmittedEventArgs e)
        {
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(orderDetails));
        }
        private void OnFormRemoveClick(object sender, FormSubmittedEventArgs e, ERPProductDetailsForm removeForm)
        {
            this._orderDetailPanel.Controls.Remove(removeForm);
            this.orderDetails.Remove(e);
        }
    }
}
