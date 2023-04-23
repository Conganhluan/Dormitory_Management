using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

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
            }

            public void AddBuilding(string name, string gender, DataTable dataTable)
            {
                /* Add a new building to the table Buildings
                 * Use AddFloor() below to create rooms for this building */


                // Add building first to avoid foreign key
                conn.Open();
                string querry = "INSERT INTO Buildings VALUES('" + name + "', '" + gender + "')";
                MySqlCommand cmd = new MySqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                // Add rooms for the building
                string numberFloor = "", numberRoom = "", typeRoom = "";
                foreach (DataRow row in dataTable.Rows) {
                    typeRoom = row[1].ToString();
                    numberFloor = row[0].ToString();
                    for (int i = 1; i <= Convert.ToInt32(row[2]); i++)
                    {
                        if (i < 10) { numberRoom = "0" + i.ToString(); }
                        else { numberRoom = i.ToString(); }
                        conn.Open();
                        querry = "INSERT INTO Rooms VALUES('" + name + "', '" + numberFloor + numberRoom + "', " + typeRoom + ", 0, now(), '')";
                        cmd.CommandText = querry;
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }

            public void ModifyBuilding(string name, string field, string newValue)
            {
                // Save the changes of wanted field to table Buildings
                // need a name to know update which building

                conn.Open();
                string sqlUpdate = "UPDATE Buildings SET " + field + " = " + newValue +
                    "WHERE Name = '" + name + "'";
                MySqlCommand cmd = new MySqlCommand(sqlUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            public void AddManagers(string filepath)
            {
                /* Read a file with format:
                 *      username_1, name_1, email_1,
                 *      username_2, name_2, email_2,...
                 * Create new Manager users whose password will be "manager" and add them to table Users */

                try
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] manager = line.Split(',');

                            // set default password and role = 'manager'
                            conn.Open();
                            string sqlQuerry = "INSERT INTO Users VALUES('" + manager[1] + "', '"
                                + manager[0] + "', 'manager', '" + manager[2] + "', 'manager', 0)";
                            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Add new managers successfully!", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void AddStudents(string filepath)
            {
                /* Read a file with format:
                 *      username_1, name_1, email_1,
                 *      username_2, name_2, email_2,...
                 * Create new Student users whose password will be "student" and add them to table Users */

                try
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] student = line.Split(',');

                            // set default password and role = 'student'
                            conn.Open();
                            string sqlQuerry = "INSERT INTO Users VALUES('" + student[1] + "', '"
                                + student[0] + "', 'student', '" + student[2] + "', 'student', 0)";
                            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Add new students successfully!", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void RemoveUsers(string filepath)
            {
                /* Remove any users whose username are listed in the file
                 * If there is non-exist user, notify the current user this error and continue after he/she is "Ok" */

                using (StreamReader reader = new StreamReader(filepath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] user = line.Split(',');

                        // set default password and role = 'student'
                        conn.Open();
                        string sqlQuerry = "DELETE FROM Users WHERE Username = " + user[0];
                        MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                        int success = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (success == 0) { MessageBox.Show("Error! Non-exist user!\nClick OK to continue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        else { MessageBox.Show("Remove listed users successfully!", "Remove successfully", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                }
            }

            public override void SaveData()
            {
                // Save the changes of Password into table Users
                conn.Open();
                string sql = "UPDATE Users SET Password = '" + Password + "' WHERE Username = '" + Username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}