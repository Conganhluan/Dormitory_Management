using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
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
            public struct Room
            {
                public string Building;
                public string RoomNum;
                public byte Type;
                public uint Bill;
                public DateTime BillTime;
            }

            public struct Personal
            {
                public string School;
                public string CitizenID;
                public string StudentID;
                public string PhoneNumber;
                public string Vehice;
                public string HomeAddress;
                public DateTime BirthDate;
            }

            public Room r;
            public Personal p;

            public Student(string username)
            {
                Username = username;
                conn.Open();
                string sql = "SELECT * FROM Users " +
                             "CROSS JOIN Students ON Students.Email = Users.Email " +
                             "WHERE Username = '" + Username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Get the data for Name, Password, and Email from table Users
                    Name = reader.GetString("Name");
                    Password = reader.GetString("Password");
                    Email = reader.GetString("Email");

                    //Get the data for struct Personal
                    p.School = reader.GetString("School");
                    p.CitizenID = reader.GetString("Citizen ID");
                    p.StudentID = reader.GetString("Student ID");
                    p.PhoneNumber = reader.GetString("Phone number");
                    p.Vehice = reader.GetString("Vehicle plate number");
                    p.HomeAddress = reader.GetString("Home address");
                    p.BirthDate = reader.GetDateTime("Date of birth");
                    r.Building = reader.GetString("Building name");
                    r.RoomNum = reader.GetString("Room number");
                }
                reader.Close();

                sql = "SELECT * FROM Rooms WHERE Building = '" + r.Building + "' AND Number = '" + r.RoomNum + "'";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Get the data for struct Rooms
                    r.Type = reader.GetByte("Type");
                    r.Bill = reader.GetUInt32("Bill");
                    r.BillTime = reader.GetDateTime("Last bill Time");
                }
                reader.Close();
                conn.Close();
            }

            public void PayRequest()
            {
                /* Add a request string formatted as below:
                 *      "building roomNum"
                 * to the table Requests, payer will be the student's name */

                string request = r.Building + " " + r.RoomNum;
                conn.Open();
                string sql = "SELECT * FROM Requests WHERE Request = '" + request + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("There is already a pending pay request for your room", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    reader.Close();
                    conn.Close();
                    return;
                }
                reader.Close();
                sql = "INSERT INTO Requests VALUES ('" + r.Building + " " + r.RoomNum + "', '" + Username + "')";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Request to pay the bill is sent\nWhen the manager accept your request, the bill will be updated!",
                            "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            public override void SaveData()
            {
                // Save the changes of Password into table Users
                conn.Open();
                string sql = "UPDATE Users SET Password = '" + Password + "' WHERE Username = '" + Username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                //Save the personal information into table Students
                sql = "UPDATE Students SET `Date of birth` = '" + p.BirthDate.ToString() + "', " +
                                          "`Citizen ID` = '" + p.CitizenID + "', " +
                                          "`Phone number` = '" + p.PhoneNumber + "', " +
                                          "`Vehicle plate number` = '" + p.Vehice + "', " +
                                          "`Home address` = '" + p.HomeAddress + "' " +
                      "WHERE Email = '" + Email + "'";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
    
}
