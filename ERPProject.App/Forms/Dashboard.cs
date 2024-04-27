using ERPProject.Controls;
using System;
using System.Data;
using System.Drawing;

namespace ERPProject.App.Forms
{
    public partial class Dashboard : ERPForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            DataTable customerTable = new DataTable("Customer");

            DataColumn nameColumn = new DataColumn("Name", typeof(string));
            nameColumn.Unique = true;
            customerTable.Columns.Add(nameColumn);

            DataColumn addressColumn = new DataColumn("Address", typeof(string));
            addressColumn.Unique = true;
            customerTable.Columns.Add(addressColumn);

            DataColumn emailColumn = new DataColumn("Email", typeof(string));
            emailColumn.Unique = true;
            customerTable.Columns.Add(emailColumn);

            DataColumn mobileColumn = new DataColumn("Mobile", typeof(string));
            mobileColumn.Unique = true;
            customerTable.Columns.Add(mobileColumn);

            for (int i = 1; i <= 100; i++)
            {
                DataRow row = customerTable.NewRow();
                row["Name"] = "Customer " + i;
                row["Address"] = "Address " + i;
                row["Email"] = "email" + i + "@example.com";
                row["Mobile"] = "123456789" + i.ToString().PadLeft(2, '0'); // PadLeft ensures mobile number is 10 digits
                customerTable.Rows.Add(row);
            }

            this.dataGridView1.DataSource = customerTable;
        }


        #region main Menu Click Events
        private void _createProduct_Click(object sender, EventArgs e)
        {

        }
        private void _createCustomer_Click(object sender, EventArgs e)
        {

        }
        private void _createOrder_Click(object sender, EventArgs e)
        {

        }
        #endregion main Menu Click Events
    }
}
