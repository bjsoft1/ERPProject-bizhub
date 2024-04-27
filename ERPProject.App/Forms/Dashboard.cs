using ERPProject.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            customerTable.Columns.Add(nameColumn);

            DataColumn addressColumn = new DataColumn("Address", typeof(string));
            customerTable.Columns.Add(addressColumn);

            DataColumn emailColumn = new DataColumn("Email", typeof(string));
            customerTable.Columns.Add(emailColumn);

            DataColumn mobileColumn = new DataColumn("Mobile", typeof(string));
            customerTable.Columns.Add(mobileColumn);

            DataColumn actionColumn = new DataColumn("ActionBox", typeof(string));
            customerTable.Columns.Add(actionColumn);


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

        private void dataGridView1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ActionBox"].Index && e.RowIndex >= 0)
            {
                //MessageBox.Show($"Action clicked for row {e.RowIndex + 1}");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ActionBox"].Index && e.RowIndex >= 0)
            {
                // Get the current data row from the DataGridView's DataSource
                var currentDataRow = ((DataTable)dataGridView1.DataSource).Rows[e.RowIndex];

                // Access the data in the current row
                // For example:
                // string name = currentDataRow["Name"].ToString();

                e.Value = "Custom Text";

                // Set the color for the button
                e.CellStyle.BackColor = Color.Blue;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void _addOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
