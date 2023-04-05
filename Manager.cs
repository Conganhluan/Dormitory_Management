using System;
using System.Collections.Generic;
using System.Data;
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
        internal class Manager : User
        {
            public Manager(string username)
            {
                Username = username;
                // Complete the Password, Name and Email from table Users
            }

            public override void MainScreen()
            {
                previousForm = null;
                currentForm = new ManagerMainScreen();
                currentForm.Show();
            }

            public void AddStudentList(string filepath)
            {
                /* You should see the file format in advance on the Figma - Interface diagram
                 * Use AddStudent() below to support this method
                 * Create a file formatted as:
                 *      name, email, <name>+<citizenID> for every student each line */
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
            }

            public void AddBills(string filepath)
            {
                /* Add bills to table Rooms through a file with format:
                 *     building_1, roomNum_1, bill_1,
                 *     building_2, roomNum_2, bill_2,...
                 * the Last bill Time will be "today" and the Review will be null for all bills
                 * The new bill will be updated as: new Bill = old Bill * (1 + 1% * dayLate) + new Bill */
            }

            public void PrintBills(DataTable lateBills)
            {
                /* Create the file LateBills.csv with format:
                 *     building_1, roomNum_1, bill_1, lateTime_1,
                 *     building_2, roomNum_2, bill_2, lateTime_2,...
                 * the data will be from the DataTable.
                 * If existing the file LateBills.csv, then notify the user and write over it */
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
            }

            public override void SaveData()
            {
                //Save the changes of Password, Name and Email to table Users
            }
        }
    }
}
