using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DormitoryManagment
{
    internal static partial class Program
    {
        internal class Student : User
        {
            private struct Room
            {
                string Building;
                string RoomNum;
                byte Type;
                uint Bill;
                TimeSpan Late;
            }

            private struct Personal
            {
                string School;
                string CitizenID;
                string StudentID;
                string PhoneNumber;
                string Vehice;
                string HomeAddress;
            }

            public Student(string username)
            {
                Username = username;
                /* Get the data for Name, Password, and Email from table Users
                 * Get the data for struct Room and Personal from table Students and Rooms */
            }

            public override void MainScreen()
            {
                previousForm = null;
                currentForm = new StudentMainScreen();
                currentForm.Show();
            }

            public void PayRequest()
            {
                /* Add a request string formatted as below:
                 *      "building roomNum"
                 * to the table Requests */
            }

            public override void SaveData()
            {
                // Save the changes of Password into table Users
            }
        }
    }
    
}
