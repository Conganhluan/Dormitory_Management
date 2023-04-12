using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
                public string Building;
                public string RoomNum;
                public byte Type;
                public uint Bill;
                public TimeSpan Late;
            }

            private struct Personal
            {
                public string School;
                public string CitizenID;
                public string StudentID;
                public string PhoneNumber;
                public string Vehice;
                public string HomeAddress;
            }

            Room r = new Room();
            Personal p = new Personal();

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
                    p.School = reader.GetString("School");
                    p.CitizenID = reader.GetString("Citizen ID");
                    p.StudentID = reader.GetString("Student ID");
                    p.PhoneNumber = reader.GetString("Phone number");
                    p.Vehice = reader.GetString("Vehicle plate num");
                    p.HomeAddress = reader.GetString("Home address");
                }
                reader.Close();
                sql = "SELECT * FROM Rooms WHERE Username = '" + Username + "'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    r.Building = reader.GetString("Building");
                    r.RoomNum = reader.GetString("Number");
                    r.Type = reader.GetByte("Type");
                    r.Bill = reader.GetUInt32("Bill");
                    r.Late = reader.GetTimeSpan("Last bill Time");
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
                 *      "building rNum"
                 * to the table Requests */
                string sql = "INSERT INTO Requests (Username, Request) VALUES ('" + Username + "', '" + r.Building + " " + r.RoomNum + "')";
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

            public string getName()
            { 
                return Name;
            }

        }
    }
    
}
