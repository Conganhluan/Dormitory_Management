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

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Program.conn.Close();
        }
    }
}
