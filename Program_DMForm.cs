using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment    
{
    public class DMForm : Form
    {
        protected void Navigate(ref DMForm nextForm)
        {
            this.Close();
            Thread thread = new Thread(RunForm);
            thread.Start(nextForm);
        }

        private void RunForm(object obj)
        {
            Application.Run((DMForm)obj);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DMForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "DMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }
    }
}
