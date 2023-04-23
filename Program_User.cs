using MySql.Data.MySqlClient;
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

            public string GetName() { return Name; }

            public void ChangePassword(string oldPass, string newPass, string checkSame)
            {
                if (oldPass != Password)
                {
                    MessageBox.Show("The old password is incorrect, please re-input!", "Update failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (newPass != checkSame)
                {
                    MessageBox.Show("The 2 new password isn't the same, please re-input!", "Update failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Password = newPass;
                MessageBox.Show("Update the new password successfully!", "Update success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveData();
            }

            virtual public void SaveData() { }

            public void LogOut()
            {
                conn.Open();
                string sql = "UPDATE Users SET Online = 0 WHERE Username = '" + Username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(cmd.ExecuteNonQuery());
                conn.Close();
            }
        }
    }
}
