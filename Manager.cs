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
using System.Web;
using System.ComponentModel;
using System.Net.NetworkInformation;
using Mysqlx.Crud;
using static DormitoryManagment.Program.Student;
using static DormitoryManagment.Program;
using System.Xml.Linq;
using System.Data.Entity.Core.Metadata.Edm;
using System.Threading;

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

            public void AddStudentList(string filepath, ref ProgressBar progressBar)
            {
                /* You should see the file format in advance on the Figma - Interface diagram
                 * Use AddStudent() below to support this method
                 * Create a file formatted as:
                 *      name, email, <name>+<studentID> for every student each line */
                try
                {
                    progressBar.Value = 0;
                    int lineCount = File.ReadLines(filepath).Count();
                    double step = 100 / (float)lineCount;
                    double value = 0;
                    StreamReader reader = new StreamReader(filepath);
                    StreamWriter writer = new StreamWriter("Student Users.csv", false);
                    string newStudent = null;
                    List<string> newStudentAttributes = null;
                    while ((newStudent = reader.ReadLine()) != null)
                    {
                        newStudentAttributes = newStudent.Split(',').ToList();
                        bool result = AddStudent(ref newStudentAttributes);
                        if (!result)
                        {
                            MessageBox.Show("Stoping finding room for students from student " + newStudentAttributes[4], "Stop adding students to dorm",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            writer.Close();
                            reader.Close();
                            return;
                        }
                        writer.WriteLine(newStudentAttributes[4] + "," + newStudentAttributes[5] + "," +
                                            newStudentAttributes[4].Split(' ').Last().ToLower() + newStudentAttributes[7]);
                        value += step;
                        progressBar.Value = Convert.ToInt32(Math.Round(value));
                    }
                    MessageBox.Show("Successfully add all students to dorm", "Add successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    writer.Close();
                    reader.Close();                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            public bool AddStudent(ref List<String> attributes)
            {
                /* string gender, byte type, string building, string roomNum,
                 * string name, string email, string school, string studentID,
                 * string vehicle, string citizenID, string birthdate, string phone, string homeAddress 
                 * 
                 * Build a algorithm to get each student his/her wishful room
                 * If that room cannot be found, then increase the type by 2, if there is out of room, notify the user
                 * Gender must be correct, type is second choice, building is third choice, and roomNum is fourth choice 
                 * Create a file List of new students to know which building will these students stay at */
                
                string gender = attributes[0], building = attributes[2], roomNum = attributes[3];
                int type = Convert.ToInt32(attributes[1]);
                bool isFound = false;
                int currentStaying = 0;
                conn.Open();
                string sql = "SELECT Name FROM Buildings WHERE Gender = '" + gender + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                List<string> availableBuildings = new List<string>();
                if (!reader.HasRows)
                {
                    MessageBox.Show("Can not find available buildings for the gender " + gender + " of the student " + attributes[4], "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else while (reader.Read()) availableBuildings.Add(reader.GetString(0));
                reader.Close();
                if (availableBuildings.Contains(building))
                {
                    sql = "SELECT * FROM Rooms WHERE Building = '" + building + "' AND Number = '" + roomNum + "' AND `Current staying` < Type";
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows) isFound = true;
                    else roomNum = null;
                    reader.Close();
                }
                else
                {
                    building = null;
                    roomNum = null;
                }
                if (!isFound)
                {
                    if (building != null && building != availableBuildings[0])
                    {
                        availableBuildings.Remove(building);
                        availableBuildings.Add(building);
                        availableBuildings.Reverse();
                    }
                    for (;type<=8;type+=2)
                    {
                        foreach(string chosenBuilding in availableBuildings)
                        {
                            sql = "SELECT Number, `Current staying` FROM Rooms WHERE Building = '" + chosenBuilding + "' AND Type = " + type + " AND `Current staying` < Type";
                            cmd = new MySqlCommand(sql, conn);
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    roomNum = reader.GetString(0);
                                    building = chosenBuilding;
                                    isFound = true;
                                    currentStaying = reader.GetInt32(1);
                                }
                                reader.Close();
                            }
                            if (isFound) break;
                        }
                        if (isFound) break;
                    }
                }
                if (!isFound)
                {
                    DialogResult reply = MessageBox.Show("There is none of room left for the gender " + gender + "\n"
                        + "Do you want to Ignore this error and continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (reply == DialogResult.Cancel)
                    {
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    sql = "INSERT INTO `Students`(`Gender`, `Building name`, `Room number`, `Name`, `Email`, `School`, `Student ID`, `Vehicle plate number`, `Citizen ID`, `Date of birth`, `Phone number`, `Home address`)" +
                        "VALUES('" + attributes[0] + "', '" + attributes[2] + "', '" + attributes[3] + "', '" + attributes[4] + "', '" + attributes[5] + "', '" + attributes[6] + "', '" + attributes[7] + 
                        "', '" + attributes[8] + "', '" + attributes[9] + "', '" + attributes[10] + "', '" + attributes[11] + "', '" + attributes[12] + "')";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    sql = "UPDATE Rooms SET `Current staying` = " + (currentStaying + 1).ToString() + " WHERE Building = '" + building + "' AND Number = '" + roomNum + "'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }

            public void RemoveStudent(string building, string roomNum)
            {
                // Decrease the Current staying of the room before remove the student
                int currentStaying = 0;
                conn.Open();
                string sql = "SELECT `Current staying` FROM Rooms WHERE Building = '" + building + "' AND Number = '" + roomNum + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    currentStaying = reader.GetInt32(0);
                }
                reader.Close();
                sql = "UPDATE Rooms SET `Current staying` = " + (currentStaying-1).ToString() + " WHERE Building = '" + building + "' AND Number = '" + roomNum + "'";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                reader.Close();
                conn.Close();
            }

            public void AddBills(string filepath)
            {
                /* Add bills to table Rooms through a file with format:
                 *     building_1, roomNum_1, bill_1,
                 *     building_2, roomNum_2, bill_2,...
                 * the Last bill Time will be "today" and the Review will be null for all bills
                 * The new bill will be updated as: new Bill = old Bill * (1 + 1% * dayLate) + new Bill */

                StreamReader streamReader = new StreamReader(filepath);
                string newBill = null;
                while ((newBill = streamReader.ReadLine()) != null)
                {
                    List<string> information = newBill.Split(',').ToList();
                    string building = information[0], room = information[1];
                    int bill = Convert.ToInt32(information[2]), oldBill = 0;
                    TimeSpan late = new TimeSpan();
                    conn.Open();
                    string sql = "SELECT * FROM Rooms WHERE Building = '" + building + "' AND Number = '" + room + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        oldBill = reader.GetInt32("Bill");
                        late = DateTime.Today - reader.GetDateTime("Last bill Time");
                    }
                    reader.Close();
                    bill = Convert.ToInt32(Math.Round(oldBill * (1 + 0.01 * Math.Max(5,late.TotalMinutes/ 1440)) + bill));
                    sql = "UPDATE Rooms SET Bill = " + bill.ToString() + " WHERE Building = '" + building + "' AND '" + room + "'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                streamReader.Close();
                MessageBox.Show("Add bills for rooms successfully", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            public void PrintLateBills()
            {
                /* Create the file Late bills.csv with format:
                 *     building_1, roomNum_1, bill_1, lateTime_1,
                 *     building_2, roomNum_2, bill_2, lateTime_2,...
                 * the data will be from the table Rooms. */

                StreamWriter streamWriter = new StreamWriter("Late bills.csv", false);
                conn.Open();
                string sql = "SELECT `Building`, `Number`, `Bill`, `Last bill Time` FROM Rooms";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string information = reader.GetString(0) + ", " + reader.GetString(1) + ", " + reader.GetInt32(2).ToString() + ", ";
                    int late = Convert.ToInt32(Math.Round((DateTime.Today - reader.GetDateTime(3)).TotalMinutes/1440));
                    streamWriter.WriteLine(information + late.ToString());
                }
                reader.Close();
                conn.Close();
                MessageBox.Show("Print out late bills succesfully!", "Print successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                streamWriter.Close();
            }

            public void ReviewBills(DataTable billList)
            {
                /* Exclude rows that have the check in column "Pending",
                 * Every rows will be deleted from the table and database */
                conn.Open();
                string sql = null;
                MySqlCommand cmd = null;
                foreach (DataRow row in billList.Rows)
                {
                    if (Convert.ToBoolean(row["isPending"]) == false)
                    {
                        string request = row["Request"].ToString();
                        string building = request.Substring(0, 3), room = request.Substring(4, 4);
                        sql = "UPDATE Rooms SET Bill = 0, Reviewer = '" + Name + "' WHERE Building = '" + building + "' AND Number = '" + room + "'";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        row.Delete();
                    }
                }
                sql = "DELETE FROM Requests WHERE 1";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                foreach (DataRow row in billList.Rows)
                {
                    sql = "INSERT INTO Requests VALUES ('" + row["Request"] + "', '" + row["Payer"] + "')";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Non-pending pay requests are checked to be correct!", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            public void updateData(string name, string email)
            {
                Name = name;
                Email = email;
            }

            public override void SaveData()
            {
                //Save the changes of Password, Name and Email to table Users
                conn.Open();
                string sql = "UPDATE Users SET Password = '" + Password + "', Name = '" + Name + "', Email = '" + Email + "' WHERE Username = '" + Username + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
