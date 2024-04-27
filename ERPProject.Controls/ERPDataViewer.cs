
using System.Drawing;
using System.Windows.Forms;

namespace ERPProject.Controls
{
    public class ERPDataViewer : System.Windows.Forms.DataGridView
    {
        public ERPDataViewer()
        {
            // 
            SetDataGridViceStyle();
        }
        private void SetDataGridViceStyle()
        {
            this.DoubleBuffered = true;
            this.Size = new System.Drawing.Size(600, 400);
            this.ColumnHeadersHeight = 35;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.BackgroundColor = Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230,230,230);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(50,50,50);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnHeadersHeight = 35;
            this.EnableHeadersVisualStyles = false;
            this.GridColor = Color.FromArgb(220,220,220);
            this.Name = "nlitsolutionDataGridView1";
            this.ReadOnly = true;
            this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RowHeadersVisible = false;
            this.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230,230,230);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 0, 0);
            this.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RowTemplate.Height = 35;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dock = DockStyle.Fill;
        }
    }
}
