using ERPProject.Controls;

namespace ERPProject.App.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._createProduct = new System.Windows.Forms.ToolStripMenuItem();
            this._createCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this._createOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._pendingList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new ERPProject.Controls.ERPDataViewer();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._saleDepartment = new System.Windows.Forms.TabPage();
            this._accountDepartment = new System.Windows.Forms.TabPage();
            this._finalDepartment = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this._addOrder = new ERPProject.Controls.ERPButtonSave();
            this._btnApprove = new ERPProject.Controls.ERPButtonSave();
            this._btnReject = new ERPProject.Controls.ERPButtonCancel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._pendingList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._createProduct,
            this._createCustomer,
            this._createOrder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _createProduct
            // 
            this._createProduct.Name = "_createProduct";
            this._createProduct.Size = new System.Drawing.Size(98, 20);
            this._createProduct.Text = "Create Product";
            this._createProduct.Click += new System.EventHandler(this._createProduct_Click);
            // 
            // _createCustomer
            // 
            this._createCustomer.Name = "_createCustomer";
            this._createCustomer.Size = new System.Drawing.Size(108, 20);
            this._createCustomer.Text = "Create Customer";
            this._createCustomer.Click += new System.EventHandler(this._createCustomer_Click);
            // 
            // _createOrder
            // 
            this._createOrder.Name = "_createOrder";
            this._createOrder.Size = new System.Drawing.Size(86, 20);
            this._createOrder.Text = "Create Order";
            this._createOrder.Click += new System.EventHandler(this._createOrder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this._pendingList);
            this.tabControl1.Controls.Add(this._saleDepartment);
            this.tabControl1.Controls.Add(this._accountDepartment);
            this.tabControl1.Controls.Add(this._finalDepartment);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 490);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // _pendingList
            // 
            this._pendingList.Controls.Add(this.dataGridView1);
            this._pendingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._pendingList.Location = new System.Drawing.Point(4, 22);
            this._pendingList.Name = "_pendingList";
            this._pendingList.Padding = new System.Windows.Forms.Padding(3);
            this._pendingList.Size = new System.Drawing.Size(1052, 464);
            this._pendingList.TabIndex = 0;
            this._pendingList.Text = "Pending";
            this._pendingList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1046, 458);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "SN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "SN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // _saleDepartment
            // 
            this._saleDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saleDepartment.Location = new System.Drawing.Point(4, 22);
            this._saleDepartment.Name = "_saleDepartment";
            this._saleDepartment.Padding = new System.Windows.Forms.Padding(3);
            this._saleDepartment.Size = new System.Drawing.Size(1052, 464);
            this._saleDepartment.TabIndex = 1;
            this._saleDepartment.Text = "Sale Department";
            this._saleDepartment.UseVisualStyleBackColor = true;
            // 
            // _accountDepartment
            // 
            this._accountDepartment.Location = new System.Drawing.Point(4, 22);
            this._accountDepartment.Name = "_accountDepartment";
            this._accountDepartment.Size = new System.Drawing.Size(1052, 464);
            this._accountDepartment.TabIndex = 2;
            this._accountDepartment.Text = "Account Department";
            this._accountDepartment.UseVisualStyleBackColor = true;
            // 
            // _finalDepartment
            // 
            this._finalDepartment.Location = new System.Drawing.Point(4, 22);
            this._finalDepartment.Name = "_finalDepartment";
            this._finalDepartment.Padding = new System.Windows.Forms.Padding(3);
            this._finalDepartment.Size = new System.Drawing.Size(1052, 464);
            this._finalDepartment.TabIndex = 3;
            this._finalDepartment.Text = "Final Department";
            this._finalDepartment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Orders";
            // 
            // _addOrder
            // 
            this._addOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._addOrder.AutoSize = true;
            this._addOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this._addOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this._addOrder.FlatAppearance.BorderSize = 0;
            this._addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._addOrder.Location = new System.Drawing.Point(955, 36);
            this._addOrder.MaximumSize = new System.Drawing.Size(110, 35);
            this._addOrder.MinimumSize = new System.Drawing.Size(110, 35);
            this._addOrder.Name = "_addOrder";
            this._addOrder.Size = new System.Drawing.Size(110, 35);
            this._addOrder.TabIndex = 4;
            this._addOrder.Text = "Add Order";
            this._addOrder.UseVisualStyleBackColor = false;
            this._addOrder.Click += new System.EventHandler(this._addOrder_Click);
            // 
            // _btnApprove
            // 
            this._btnApprove.AccessibleName = "";
            this._btnApprove.AutoSize = true;
            this._btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this._btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnApprove.Enabled = false;
            this._btnApprove.FlatAppearance.BorderSize = 0;
            this._btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._btnApprove.Location = new System.Drawing.Point(465, 27);
            this._btnApprove.MaximumSize = new System.Drawing.Size(110, 35);
            this._btnApprove.MinimumSize = new System.Drawing.Size(110, 35);
            this._btnApprove.Name = "_btnApprove";
            this._btnApprove.Size = new System.Drawing.Size(110, 35);
            this._btnApprove.TabIndex = 5;
            this._btnApprove.Text = "Approve";
            this._btnApprove.UseVisualStyleBackColor = false;
            this._btnApprove.Click += new System.EventHandler(this._btnApprove_Click);
            // 
            // _btnReject
            // 
            this._btnReject.AccessibleName = "";
            this._btnReject.AutoSize = true;
            this._btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnReject.Enabled = false;
            this._btnReject.FlatAppearance.BorderSize = 0;
            this._btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._btnReject.Location = new System.Drawing.Point(581, 27);
            this._btnReject.MaximumSize = new System.Drawing.Size(110, 35);
            this._btnReject.MinimumSize = new System.Drawing.Size(110, 35);
            this._btnReject.Name = "_btnReject";
            this._btnReject.Size = new System.Drawing.Size(110, 35);
            this._btnReject.TabIndex = 6;
            this._btnReject.Text = "Reject";
            this._btnReject.UseVisualStyleBackColor = false;
            this._btnReject.Click += new System.EventHandler(this._btnReject_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this._btnReject);
            this.Controls.Add(this._btnApprove);
            this.Controls.Add(this._addOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this._pendingList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _createProduct;
        private System.Windows.Forms.ToolStripMenuItem _createCustomer;
        private System.Windows.Forms.ToolStripMenuItem _createOrder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _pendingList;
        private System.Windows.Forms.TabPage _saleDepartment;
        private System.Windows.Forms.TabPage _accountDepartment;
        private System.Windows.Forms.TabPage _finalDepartment;
        private System.Windows.Forms.Label label1;
        private Controls.ERPDataViewer dataGridView1;
        private ERPButtonSave _addOrder;
        private ERPButtonSave _btnApprove;
        private ERPButtonCancel _btnReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}