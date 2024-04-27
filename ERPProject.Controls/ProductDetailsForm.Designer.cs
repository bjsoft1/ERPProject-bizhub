namespace ERPProject.Controls
{
    partial class ERPProductDetailsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._quantity = new System.Windows.Forms.TextBox();
            this._product = new System.Windows.Forms.ComboBox();
            this._amount = new System.Windows.Forms.TextBox();
            this._totalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.erpButtonCancel1 = new ERPProject.Controls.ERPButtonCancel();
            this.SuspendLayout();
            // 
            // _quantity
            // 
            this._quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._quantity.Location = new System.Drawing.Point(261, 27);
            this._quantity.Name = "_quantity";
            this._quantity.Size = new System.Drawing.Size(129, 23);
            this._quantity.TabIndex = 5;
            this._quantity.TextChanged += new System.EventHandler(this._quantity_TextChanged);
            // 
            // _product
            // 
            this._product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this._product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._product.FormattingEnabled = true;
            this._product.Location = new System.Drawing.Point(3, 26);
            this._product.Name = "_product";
            this._product.Size = new System.Drawing.Size(243, 24);
            this._product.TabIndex = 4;
            this._product.SelectedValueChanged += new System.EventHandler(this._product_SelectedValueChanged);
            // 
            // _amount
            // 
            this._amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._amount.Location = new System.Drawing.Point(409, 27);
            this._amount.Name = "_amount";
            this._amount.Size = new System.Drawing.Size(240, 23);
            this._amount.TabIndex = 6;
            this._amount.TextChanged += new System.EventHandler(this._amount_TextChanged);
            // 
            // _totalAmount
            // 
            this._totalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalAmount.Location = new System.Drawing.Point(667, 27);
            this._totalAmount.Name = "_totalAmount";
            this._totalAmount.ReadOnly = true;
            this._totalAmount.Size = new System.Drawing.Size(194, 23);
            this._totalAmount.TabIndex = 7;
            this._totalAmount.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Amount";
            // 
            // erpButtonCancel1
            // 
            this.erpButtonCancel1.AutoSize = true;
            this.erpButtonCancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.erpButtonCancel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.erpButtonCancel1.FlatAppearance.BorderSize = 0;
            this.erpButtonCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erpButtonCancel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erpButtonCancel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.erpButtonCancel1.Location = new System.Drawing.Point(867, 15);
            this.erpButtonCancel1.MaximumSize = new System.Drawing.Size(35, 35);
            this.erpButtonCancel1.MinimumSize = new System.Drawing.Size(35, 35);
            this.erpButtonCancel1.Name = "erpButtonCancel1";
            this.erpButtonCancel1.Size = new System.Drawing.Size(35, 35);
            this.erpButtonCancel1.TabIndex = 13;
            this.erpButtonCancel1.Text = "X";
            this.erpButtonCancel1.UseVisualStyleBackColor = false;
            this.erpButtonCancel1.Click += new System.EventHandler(this.erpButtonCancel1_Click);
            // 
            // ERPProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.erpButtonCancel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._totalAmount);
            this.Controls.Add(this._amount);
            this.Controls.Add(this._quantity);
            this.Controls.Add(this._product);
            this.Name = "ERPProductDetailsForm";
            this.Size = new System.Drawing.Size(913, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _quantity;
        private System.Windows.Forms.ComboBox _product;
        private System.Windows.Forms.TextBox _amount;
        private System.Windows.Forms.TextBox _totalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ERPButtonCancel erpButtonCancel1;
    }
}
