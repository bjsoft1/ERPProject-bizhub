namespace ERPProject.App
{
    partial class Form1
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
            this.erpButtonSave1 = new ERPProject.Controls.ERPButtonSave();
            this.SuspendLayout();
            // 
            // erpButtonSave1
            // 
            this.erpButtonSave1.AutoSize = true;
            this.erpButtonSave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.erpButtonSave1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.erpButtonSave1.FlatAppearance.BorderSize = 0;
            this.erpButtonSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.erpButtonSave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erpButtonSave1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.erpButtonSave1.Location = new System.Drawing.Point(678, 403);
            this.erpButtonSave1.MaximumSize = new System.Drawing.Size(110, 35);
            this.erpButtonSave1.MinimumSize = new System.Drawing.Size(110, 35);
            this.erpButtonSave1.Name = "erpButtonSave1";
            this.erpButtonSave1.Size = new System.Drawing.Size(110, 35);
            this.erpButtonSave1.TabIndex = 0;
            this.erpButtonSave1.Text = "Save";
            this.erpButtonSave1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erpButtonSave1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ERPButtonSave erpButtonSave1;
    }
}

