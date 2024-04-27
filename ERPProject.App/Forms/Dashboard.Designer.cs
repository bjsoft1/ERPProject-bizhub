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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._createProduct = new System.Windows.Forms.ToolStripMenuItem();
            this._createCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this._createOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _createProduct;
        private System.Windows.Forms.ToolStripMenuItem _createCustomer;
        private System.Windows.Forms.ToolStripMenuItem _createOrder;
    }
}