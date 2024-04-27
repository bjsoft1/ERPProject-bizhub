namespace ERPProject.App.Forms
{
    partial class AddUpdateOrder
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
            this._customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._totalAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._orderDetailPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this._addRow = new ERPProject.Controls.ERPButtonSave();
            this._save = new ERPProject.Controls.ERPButtonSave();
            this.SuspendLayout();
            // 
            // _customer
            // 
            this._customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this._customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._customer.FormattingEnabled = true;
            this._customer.Location = new System.Drawing.Point(12, 32);
            this._customer.Name = "_customer";
            this._customer.Size = new System.Drawing.Size(243, 24);
            this._customer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // _totalAmount
            // 
            this._totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalAmount.Location = new System.Drawing.Point(281, 33);
            this._totalAmount.Name = "_totalAmount";
            this._totalAmount.ReadOnly = true;
            this._totalAmount.Size = new System.Drawing.Size(240, 23);
            this._totalAmount.TabIndex = 2;
            this._totalAmount.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Amount";
            // 
            // _orderDetailPanel
            // 
            this._orderDetailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._orderDetailPanel.AutoScroll = true;
            this._orderDetailPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._orderDetailPanel.Location = new System.Drawing.Point(12, 108);
            this._orderDetailPanel.Name = "_orderDetailPanel";
            this._orderDetailPanel.Size = new System.Drawing.Size(1060, 400);
            this._orderDetailPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Details";
            // 
            // _addRow
            // 
            this._addRow.AutoSize = true;
            this._addRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this._addRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this._addRow.FlatAppearance.BorderSize = 0;
            this._addRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._addRow.Location = new System.Drawing.Point(962, 70);
            this._addRow.MaximumSize = new System.Drawing.Size(110, 35);
            this._addRow.MinimumSize = new System.Drawing.Size(110, 35);
            this._addRow.Name = "_addRow";
            this._addRow.Size = new System.Drawing.Size(110, 35);
            this._addRow.TabIndex = 7;
            this._addRow.Text = "Add Row";
            this._addRow.UseVisualStyleBackColor = false;
            this._addRow.Click += new System.EventHandler(this._addRow_Click);
            // 
            // _save
            // 
            this._save.AutoSize = true;
            this._save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this._save.Cursor = System.Windows.Forms.Cursors.Hand;
            this._save.FlatAppearance.BorderSize = 0;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this._save.Location = new System.Drawing.Point(962, 514);
            this._save.MaximumSize = new System.Drawing.Size(110, 35);
            this._save.MinimumSize = new System.Drawing.Size(110, 35);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(110, 35);
            this._save.TabIndex = 8;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // AddUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this._save);
            this.Controls.Add(this._addRow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._orderDetailPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._totalAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._customer);
            this.Name = "AddUpdateOrder";
            this.Text = "AddUpdateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _totalAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel _orderDetailPanel;
        private System.Windows.Forms.Label label4;
        private Controls.ERPButtonSave _addRow;
        private Controls.ERPButtonSave _save;
    }
}