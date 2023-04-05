using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
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

        public override void MainScreen()
        {
            Form AdminMainScreen = new AdminMainScreen();
            AdminMainScreen.Show();
        }

        public void AddBuilding(string name, string gender, byte numOfFloor)
        {
            /* Add a new building to the table Buildings
             * Use AddFloor() below to create rooms for this building */
        }

        private void AddFloor(byte floorNum, byte numOfRoom, byte typeOfRoom)
        {
            /* Supporting the AddBuilding() above (which already has the building's name)
             * Create rooms for the floor, room number will be formatted as: <floorNum>+<num>[2]
             *      Ex: floor 1, number 2 -> 102
             *      Ex: floor 13, number 4 -> 1304 */
        }

        public void ModifyBuilding(string field, string newValue)
        {
            // Save the changes of wanted field to table Buildings
        }

        public void AddManagers(string filepath)
        {
            /* Read a file with format:
             *      username_1, name_1, email_1,
             *      username_2, name_2, email_2,...
             * Create new Manager users whose password will be "manager" and add them to table Users */
        }

        public void AddStudents(string filepath)
        {
            /* Read a file with format:
             *      username_1, name_1, email_1,
             *      username_2, name_2, email_2,...
             * Create new Student users whose password will be "student" and add them to table Users */
        }

        public void RemoveUsers(string filepath)
        {
            /* Remove any users whose username are listed in the file
             * If there is non-exist user, notify the current user this error and continue after he/she is "Ok" */
        }

        public override void SaveData()
        {
            // Save the changes of Password into table Users
        }
    }
}
