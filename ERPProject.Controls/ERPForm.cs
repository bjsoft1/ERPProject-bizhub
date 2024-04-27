using System.Windows.Forms;

namespace ERPProject.Controls
{
    public partial class ERPForm : Form
    {
        public ERPForm()
        {
            InitializeComponent();
            base.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if(e.KeyCode == Keys.Escape)
            {
                if (ERPMessage.YesNoCancel("Do you want to close it?", "Are you sure?"))
                    this.Close();
            }
            else if(e.KeyCode == Keys.S && e.Control == true)
                this.OnSubmitForm();
        }
        /// <summary>
        /// This function call when Pressed CTRL + S
        /// </summary>
        protected virtual void OnSubmitForm()
        {
            // Override this functin in child and write their logic..
        }
    }
    public static class ERPMessage
    {
        public static bool YesNoCancel(string message, string caption = null)
        {
            return MessageBox.Show(message,caption, MessageBoxButtons.YesNoCancel) == DialogResult.Yes;
        }
        public static bool YesNo(string message, string caption = null)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
        public static void OK(string message, string caption = null)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
    }
}
