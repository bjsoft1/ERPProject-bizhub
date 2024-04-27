
namespace ERPProject.Controls
{
    public class ERPButton:System.Windows.Forms.Button
    {
        public ERPButton()
        {
            InitializeControl();
        }

        private void InitializeControl()
        {
            base.Cursor = System.Windows.Forms.Cursors.Hand;
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.Location = new System.Drawing.Point(651, 405);
            base.Size = new System.Drawing.Size(110, 35);
            base.MaximumSize = new System.Drawing.Size(110, 35);
            base.MinimumSize = new System.Drawing.Size(110, 35);
            base.UseVisualStyleBackColor = false;
            base.AutoSize = true;
            base.Text = "ERP Button";
        }
    }
    public class ERPButtonSave: ERPButton
    {
        public ERPButtonSave()
        {
            InitializeControl();
        }

        private void InitializeControl()
        {
            base.BackColor = System.Drawing.Color.FromArgb(50, 150, 50);
            base.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            base.Text = "Save";
        }
    }
    public class ERPButtonCancel: ERPButton
    {
        public ERPButtonCancel() 
        {
            InitializeControl();
        }

        private void InitializeControl()
        {
            base.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            base.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            base.Text = "Cancel";
        }
    }
}
