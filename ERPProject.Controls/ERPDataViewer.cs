
using System.Drawing;
using System.Windows.Forms;

namespace ERPProject.Controls
{
    public class ERPDataViewer : System.Windows.Forms.DataGridView
    {
        private ERPButton erpButton2;
        private ERPButton erpButton1;

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
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnHeadersHeight = 35;
            this.EnableHeadersVisualStyles = false;
            this.GridColor = Color.FromArgb(220, 220, 220);
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
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(230, 230, 230);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 0, 0);
            this.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RowTemplate.Height = 35;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dock = DockStyle.Fill;

            SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SerialNumber.HeaderText = "SN";
            SerialNumber.Name = "SerialNumber";
            SerialNumber.ReadOnly = true;
            SerialNumber.Width = 60;
            if (this.Columns.Count == 0)
                this.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            SerialNumber});
        }
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            if(this.ColumnCount > 0)
            {
                this.Rows[e.RowIndex].SetValues(e.RowIndex + 1);
            }
        }

        private void InitializeComponent()
        {
            this.erpButton1 = new ERPProject.Controls.ERPButton();
            this.erpButton2 = new ERPProject.Controls.ERPButton();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // erpButton1
            // 
            this.erpButton1.AutoSize = true;
            this.erpButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.erpButton1.FlatAppearance.BorderSize = 0;
            this.erpButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erpButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erpButton1.Location = new System.Drawing.Point(651, 405);
            this.erpButton1.MaximumSize = new System.Drawing.Size(110, 35);
            this.erpButton1.MinimumSize = new System.Drawing.Size(110, 35);
            this.erpButton1.Name = "erpButton1";
            this.erpButton1.Size = new System.Drawing.Size(110, 35);
            this.erpButton1.TabIndex = 0;
            this.erpButton1.Text = "erpButton1";
            this.erpButton1.UseVisualStyleBackColor = false;
            // 
            // erpButton2
            // 
            this.erpButton2.AutoSize = true;
            this.erpButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.erpButton2.FlatAppearance.BorderSize = 0;
            this.erpButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erpButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erpButton2.Location = new System.Drawing.Point(651, 405);
            this.erpButton2.MaximumSize = new System.Drawing.Size(110, 35);
            this.erpButton2.MinimumSize = new System.Drawing.Size(110, 35);
            this.erpButton2.Name = "erpButton2";
            this.erpButton2.Size = new System.Drawing.Size(110, 35);
            this.erpButton2.TabIndex = 0;
            this.erpButton2.Text = "erpButton2";
            this.erpButton2.UseVisualStyleBackColor = false;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
    }

}
