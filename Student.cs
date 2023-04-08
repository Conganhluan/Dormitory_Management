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
                //Get the data for Name, Password, and Email from table Users
                string sql = "SELECT * FROM Users WHERE Username = '" + Username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Name = reader.GetString("Name");
                    Password = reader.GetString("Password");
                    Email = reader.GetString("Email");
                }
                reader.Close();
                //Get the data for struct Room and Personal from table Students and Rooms
                sql = "SELECT * FROM Students WHERE Username = '" + Username + "'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Personal.School = reader.GetString("School");
                    Personal.CitizenID = reader.GetString("CitizenID");
                    Personal.StudentID = reader.GetString("StudentID");
                    Personal.PhoneNumber = reader.GetString("PhoneNumber");
                    Personal.Vehice = reader.GetString("Vehice");
                    Personal.HomeAddress = reader.GetString("HomeAddress");
                }
                reader.Close();
                sql = "SELECT * FROM Rooms WHERE Username = '" + Username + "'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room.Building = reader.GetString("Building");
                    Room.RoomNum = reader.GetString("RoomNum");
                    Room.Type = reader.GetByte("Type");
                    Room.Bill = reader.GetUInt32("Bill");
                    Room.Late = reader.GetTimeSpan("Late");
                }
                reader.Close();
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
                string sql = "INSERT INTO Requests (Username, Request) VALUES ('" + Username + "', '" + Room.Building + " " + Room.RoomNum + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

            public override void SaveData()
            {
                // Save the changes of Password into table Users
                string sql = "UPDATE Users SET Password = '" + Password + "' WHERE Username = '" + Username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
    
}
