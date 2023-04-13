using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            }

            public Room r;
            public Personal p;

            public Student(string username)
            {
                Username = username;
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
            }

            public void PayRequest()
            {
                /* Add a request string formatted as below:
                 *      "building roomNum"
                 * to the table Requests */
                /*string sql = "INSERT INTO Requests (Username, Request) VALUES ('" + Username + "', '" + r.Building + " " + r.RoomNum + "')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();*/
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
