using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualBasic.FileIO;
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
            }

            public void AddStudentList(string filepath)
            {
                /* You should see the file format in advance on the Figma - Interface diagram
                 * Use AddStudent() below to support this method
                 * Create a file formatted as:
                 *      name, email, <name>+<citizenID> for every student each line */
                //string SQL;
                //UInt32 FileSize;
                //byte[] rawData;
                

                if (File.Exists(filepath))
                {
                    /*
                    try
                    {
                        FileSize = fs.Length;

                        rawData = new byte[FileSize];
                        fs.Read(rawData, 0, FileSize);
                        fs.Close();

                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand();

                        SQL = "INSERT INTO file VALUES(NULL, @FileName, @FileSize, @File)";
                        cmd.Connection = conn;
                        cmd.CommandText = SQL;
                        
                        cmd.Parameters.AddWithValue("@Namw", Student.Name);
                        cmd.Parameters.AddWithValue("@Email", FileSize);
                        cmd.Parameters.AddWithValue("@<Name>+<CitizenID>", rawData);
                        
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("File Inserted into database successfully!",
                            "Success!");

                        conn.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message);
                    }
                    */


                }
                else
                {
                    FileStream fs = File.Create(filepath);
                }
            }
            
            public void AddStudent(string gender, byte type, string building, string roomNum,
                                        string name, string email, string school, string studentID,
                                            string vehicle, string citizenID, string birthdate, string phone, string homeAddress)
            {
                /* Build a algorithm to get each student his/her wishful room
                 * If that room cannot be found, then increase the type by 2, if there is out of room, notify the user
                 * Gender must be correct, type is second choice, building is third choice, and roomNum is fourth choice
                 * Support AddStudentList() above at creating the file */
                

            }

            public void RemoveStudent(string studentID)
            {
                // Remove student whose studentID is given out of table Students
                string sqlQuerry = " 'DELETE FROM Students WHERE Student ID = ' " + studentID;
                MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);
                int success = cmd.ExecuteNonQuery();
                if (success == 0)
                {
                   MessageBox.Show("Error! Non-exist student!");
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

                }
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
