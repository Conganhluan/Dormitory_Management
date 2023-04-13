using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DormitoryManagment
{
    internal static partial class Program
    {
        internal class Admin : User
        {
            public Admin(string password)
            {
                Name = "admin";
                Username = "admin";
                Email = "";
                Password = password;
            }

<<<<<<< HEAD
=======
            private class Room
            {
                private string _Building;
                public string Building { get => _Building; set => _Building = value; }
                private string _Number;
                public string Number { get => _Number; set => _Number = value; }
                private byte _Type;
                public byte Type { get => _Type; set => _Type = value; }
                private byte _Bill;
                public byte Bill { get => _Bill; set => _Bill = value; }
                private DateTime _LastBillTime;
                public DateTime LastBillTime { get => _LastBillTime; set => _LastBillTime = value; }
                private string _Reviewer;
                public string Reviewer { get => _Reviewer; set => _Reviewer = value; }

                public Room(string buil, string num, byte type, byte bill, DateTime last, string rev)
                {
                    Building = buil;
                    Number = num;
                    Type = type;
                    Bill = bill;
                    LastBillTime = last;
                    Reviewer = rev;
                }
            }

            public override void MainScreen()
            {
                previousForm = null;
                currentForm = new AdminMainScreen();
                currentForm.Show();
            }

>>>>>>> 5bb73dcdc23bbe145ceae671046f668b422984b3
            public void AddBuilding(string name, string gender, byte numOfFloor)
            {
                /* Add a new building to the table Buildings
                 * Use AddFloor() below to create rooms for this building */

                for (byte floorIndex = 1; floorIndex <= numOfFloor; floorIndex++)
                {
                    //add building first to avoid foreign key
                    string querry = "INSERT INTO Buildings VALUES('" + name + "', '" + gender + "')";
                    MySqlCommand cmd = new MySqlCommand(querry, conn);
                    cmd.ExecuteNonQuery();

                    //add room after add building
                    List<Room> rooms = AddFloor(floorIndex, 24, 1);

                    foreach (Room room in rooms)
                    {
                        string sqlQuerry = "INSERT INTO Rooms VALUES('" + name + "', '" + room.Number 
                            + "', " + room.Type + ", " + room.Bill + ", '" + room.LastBillTime + "', '" + room.Reviewer + "')";

                        cmd = new MySqlCommand(sqlQuerry, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            private List<Room> AddFloor(byte floorNum, byte numOfRoom, byte typeOfRoom)
            {
                /* Supporting the AddBuilding() above (which already has the building's name)
                 * Create rooms for the floor, room number will be formatted as: <floorNum>+<num>[2]
                 *      Ex: floor 1, number 2 -> 102
                 *      Ex: floor 13, number 4 -> 1304 */

                List<Room> rooms = new List<Room>();
                for (int roomIndex = 1; roomIndex <= numOfRoom; roomIndex++)
                {
                    rooms.Add(new Room("", (floorNum + roomIndex).ToString(), typeOfRoom, 0, DateTime.Now, ""));
                }
                return rooms;
            }

            public void ModifyBuilding(string name, string field, string newValue)
            {
                // Save the changes of wanted field to table Buildings
                // need a name to know update which building

                string sqlUpdate = "UPDATE Buildings SET " + field + " = " + newValue + 
                    "WHERE Name = '" + name + "'";
                MySqlCommand cmd = new MySqlCommand(sqlUpdate, conn);
                cmd.ExecuteNonQuery();
            }

            public void AddManagers(string filepath)
            {
                /* Read a file with format:
                 *      username_1, name_1, email_1,
                 *      username_2, name_2, email_2,...
                 * Create new Manager users whose password will be "manager" and add them to table Users */

                using (TextFieldParser parser = new TextFieldParser(filepath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // ignore header
                    string[] columnHeader = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        string[] manager = parser.ReadFields();

                        // set default password and role = 'manager'
                        string sqlQuerry = "INSERT INTO Users VALUES('" + manager[1] + "', '" 
                            + manager[0] + "', 'manager', '" + manager[2] + "', 'manager')";
                        MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void AddStudents(string filepath)
            {
                /* Read a file with format:
                 *      username_1, name_1, email_1,
                 *      username_2, name_2, email_2,...
                 * Create new Student users whose password will be "student" and add them to table Users */

                using (TextFieldParser parser = new TextFieldParser(filepath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // ignore header
                    string[] columnHeader = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        string[] student = parser.ReadFields();

                        // set default password and role = 'student'
                        string sqlQuerry = "INSERT INTO Users VALUES('" + student[1] + "', '"
                            + student[0] + "', 'student', '" + student[2] + "', 'student')";
                        MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void RemoveUsers(string filepath)
            {
                /* Remove any users whose username are listed in the file
                 * If there is non-exist user, notify the current user this error and continue after he/she is "Ok" */

                using (TextFieldParser parser = new TextFieldParser(filepath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // ignore header
                    string[] columnHeader = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        string[] user = parser.ReadFields();

                        // set default password and role = 'student'
                        string sqlQuerry = "DELETE FROM Users WHERE Username = " + user[0];
                        MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                        int success = cmd.ExecuteNonQuery();

                        if (success == 0)
                        {
                            MessageBox.Show("Error! Non-exist user!\nClick OK to continue!");
                        }
                    }
                }
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
