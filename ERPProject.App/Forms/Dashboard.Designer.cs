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
            this._saleDepartment = new System.Windows.Forms.TabPage();
            this._accountDepartment = new System.Windows.Forms.TabPage();
            this._finalDepartment = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "S.N";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
    }
}