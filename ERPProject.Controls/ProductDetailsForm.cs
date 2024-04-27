using ERPProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPProject.Controls
{
    public partial class ERPProductDetailsForm : UserControl
    {
        public event OnOrderFormValueChange OnFormValueChange;
        public event OnOrderFormRemoveClick OnFormRemoveClick;
        public ERPProductDetailsForm()
        {
            InitializeComponent();
        }
        public ERPProductDetailsForm(int index, IEnumerable<ProductModel> products, FormSubmittedEventArgs refrence)
        {
            InitializeComponent();
            this.formIndex = index;
            this.productDatasource = products;
            this.refValue = refrence;
        }
        private IEnumerable<ProductModel> productDatasource;
        int formIndex;
        FormSubmittedEventArgs refValue;

        private void _quantity_TextChanged(object sender, EventArgs e)
        {
            int quantity;
            int.TryParse(_quantity.Text.Trim(), out quantity);
            _quantity.Text = (quantity <= 0 ? "" : quantity.ToString());
            updateTotal();
        }

        private void _amount_TextChanged(object sender, EventArgs e)
        {
            float amount;
            float.TryParse(_amount.Text.Trim(), out amount);
            _amount.Text = (amount <= 0 ? "" : amount.ToString());
            updateTotal();
        }
        void updateTotal()
        {
            int quantity;
            int.TryParse(_quantity.Text.Trim(), out quantity);
            float amount;
            float.TryParse(_amount.Text.Trim(), out amount);
            _totalAmount.Text = $"{quantity * amount}";

            refValue.Amount = amount;
            refValue.Quantity= quantity;

            if (_product.SelectedValue != null)
            {
                int productId;
                int.TryParse(_product.SelectedValue.ToString(), out productId);
                refValue.ProductId = productId;
            }
             
                OnFormValueChange?.Invoke(this, refValue);
        }

        private void erpButtonCancel1_Click(object sender, EventArgs e)
        {
            OnFormRemoveClick?.Invoke(this, refValue, this);
        }
    }
    public delegate void OnOrderFormValueChange(object sender, FormSubmittedEventArgs e);
    public delegate void OnOrderFormRemoveClick(object sender, FormSubmittedEventArgs e, ERPProductDetailsForm removeForm);
    public class FormSubmittedEventArgs : EventArgs
    {
        public FormSubmittedEventArgs(int quantity, float amount, int? productId = null)
        {
            ProductId = productId;
            Quantity = quantity;
            Amount = amount;
        }
        public int? ProductId { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
    }
}
