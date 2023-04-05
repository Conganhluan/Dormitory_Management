using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
{
    internal static partial class Program
    {
        internal class User
        {
            protected string Name;
            protected string Email;
            protected string Username;
            protected string Password;

            public User()
            {
                Name = "";
                Email = "";
                Username = "";
                Password = "";
            }

            public virtual void MainScreen()
            {
                previousForm = null;
                currentForm = new StartScreen();
                currentForm.Show();
            }

            public void changePassword(string oldPass, string newPass, string checkSame)
            {
                if (oldPass != Password)
                {
                    MessageBox.Show("The old password is incorrect, please re-input!", "Update failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (newPass != checkSame)
                {
                    MessageBox.Show("The 2 new password isn't the same, please re-input!", "Update failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Password = newPass;
            }

            virtual public void SaveData() { }
        }
    }
}
