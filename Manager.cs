using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography;

namespace DormitoryManagment
{
    internal static partial class Program
    {
        internal class Manager : User
        {
            public Manager(string username)
            {
                Username = username;
                // Complete the Password, Name and Email from table Users
                conn.Open();
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
                conn.Close();
            }

            public void AddStudentList(string filepath)
            {
                /* You should see the file format in advance on the Figma - Interface diagram
                 * Use AddStudent() below to support this method
                 * Create a file formatted as:
                 *      name, email, <name>+<studentID> for every student each line */
                try
                {
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        StreamWriter writer = new StreamWriter("Student Users", false);
                        string newStudent = null;
                        List<string> newStudentAttributes = null;
                        while ((newStudent = reader.ReadLine()) != null)
                        {
                            newStudentAttributes = newStudent.Split(',').ToList();
                            AddStudent(ref newStudentAttributes);
                            writer.WriteLine(newStudentAttributes[4] + "," + newStudentAttributes[5] + "," +
                                                newStudentAttributes[4].Split(' ').Last().ToLower() + newStudentAttributes[7]);
                        }
                        writer.Close();
                        reader.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            public void AddStudent(ref List<String> attributes)
            {
                /* string gender, byte type, string building, string roomNum,
                 * string name, string email, string school, string studentID,
                 * string vehicle, string citizenID, string birthdate, string phone, string homeAddress 
                 * 
                 * Build a algorithm to get each student his/her wishful room
                 * If that room cannot be found, then increase the type by 2, if there is out of room, notify the user
                 * Gender must be correct, type is second choice, building is third choice, and roomNum is fourth choice
                 * Support AddStudentList() above at creating the file */
                string gender = attributes[0], building = attributes[2], roomNum = attributes[3];
                int type = Int16.Parse(attributes[1]);
                conn.Open();
                string sql = "SELECT Gender FROM Buildings WHERE Name = '" + building + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (gender != reader.GetString("Gender")) building = null;
                }
                reader.Close();
                conn.Close();
            }

            public void RemoveStudent(string studentID)
            {
                // Remove student whose studentID is given out of table Students
                conn.Open();
                string sqlQuerry = " 'DELETE FROM Students WHERE Student ID = ' " + studentID;
                MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                int success = cmd.ExecuteNonQuery();
                conn.Close();
                if (success == 0)
                {
                   MessageBox.Show("Non-exist student!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void AddBills(string filepath)
            {
                /* Add bills to table Rooms through a file with format:
                 *     building_1, roomNum_1, bill_1,
                 *     building_2, roomNum_2, bill_2,...
                 * the Last bill Time will be "today" and the Review will be null for all bills
                 * The new bill will be updated as: new Bill = old Bill * (1 + 1% * dayLate) + new Bill */
                /*
                using (TextFieldParser parser = new TextFieldParser(filepath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // ignore header
                    string[] columnHeader = parser.ReadFields();
                    //run thử
                    while (!parser.EndOfData)
                    {
                        string[] bills = parser.ReadFields();

                        // set default ....
                        string sql = "INSERT INTO Rooms VALUES('" + bills[0] + "', '"
                            + bills[1] + "', 'roomNum', '" + bills[2] + "', 'bill')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                */
                

                if (File.Exists(filepath))
                {
                    //File.WriteAllText(file, "Hello World");
                }
                else
                {
                    FileStream fs = File.Create(filepath);
                }

            }

            public void PrintBills(DataTable lateBills)
            {
                /* Create the file LateBills.csv with format:
                 *     building_1, roomNum_1, bill_1, lateTime_1,
                 *     building_2, roomNum_2, bill_2, lateTime_2,...
                 * the data will be from the DataTable.
                 * If existing the file LateBills.csv, then notify the user and write over it */
                conn.Open();
                string sql = "'SELECT EXISTS ( '" + "' FROM '" + lateBills + "')'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Prepare();
                if(cmd.ExecuteNonQuery() > 0)
                {

                }
                else
                {
                    lateBills = new DataTable();
                    //string sql1 = "'SELECT ";
                }
                conn.Close();
            }

            public void ReviewBills(List<string> pending)
            {
                /* Every bills listed in table Requests will be consider "paid"
                 * -> Update the bills = 0, the reviewer for these bills will be current user and delete them from table Requests
                 * However, the bill listed in pending list above will be consider "unpaid"
                 * -> Don't update these bills and don't delete them from table Requests    
                 * **The format of the strings in pending list will be at your own choice** */
                
            }

            public void StudentModify(string field, string value)
            {
                /* Modify the value of wanted field 
                 * Update the table Users */
                conn.Open();
                string sql = "'UPDATE Users SET " + field + " = " + value + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            public void PrintWrongStudents()
            {
                /* Print the list of students staying at wrong building (the gender are not the same)
                 * The list contains 5 column Name, Student ID, BUilding name, Room number, Student's gender */
                //Create reverse Dictionary 
                Dictionary<string, string> reverseDictionary = new Dictionary<string, string>();
                conn.Open();
                string sql = "SELECT * FROM Buildings";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string buildingName = reader.GetString(0);
                    string gender = reader.GetString(1);
                    if (gender == "Male") gender = "Female";
                    else if (gender == "Female") gender = "Male";
                    reverseDictionary.Add(buildingName, gender);
                }
                reader.Close();
                conn.Close();
                if (reverseDictionary.Count == 0)
                {
                    MessageBox.Show("The dictionary is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Write headers
                StreamWriter streamWriter = new StreamWriter("Students staying at wrong building.csv", false);
                streamWriter.WriteLine("Name, Student ID, Building name, Room number, Student's gender");

                // Write records
                foreach (KeyValuePair<string, string> pair in reverseDictionary)
                {
                    conn.Open();
                    sql = "SELECT `Name`, `Student ID`, `Building name`, `Room number`, `Gender` FROM Students WHERE " +
                        "`Building name`= '" + pair.Key + "' AND Gender = '" + pair.Value + "'";
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read()) streamWriter.WriteLine(reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3) + ", " + reader.GetString(4));
                    reader.Close();
                    conn.Close();
                }
                streamWriter.Close();
                MessageBox.Show("Print the list of students successfully!", "Print successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            public override void SaveData()
            {
                //Save the changes of Password, Name and Email to table Users
                conn.Open();
                string sql = "'UPDATE Users SET Password = '" + Password + "' WHERE Name = '" + Name + "' WHERE Email = '" + Email + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
