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

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (Program.conn.State == System.Data.ConnectionState.Closed) { return; }
            if (Program.student != null) { Program.student.LogOut(); }
            if (Program.manager != null) { Program.manager.LogOut(); }
            if (Program.admin != null) { Program.admin.LogOut(); }
            Program.conn.Close();
        }
    }
}
