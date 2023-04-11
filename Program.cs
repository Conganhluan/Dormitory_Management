using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System.Net;

namespace DormitoryManagment
{
    internal static partial class Program
    {
        // The program starts here
        static void Main(string[] args)
        {
            conn.Open();

            command.CommandText = "Rooms";
            command.CommandType = CommandType.TableDirect;
          
            MySqlDataReader rdr = command.ExecuteReader();
            Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10} {rdr.GetName(2),10} {rdr.GetName(3),18} {rdr.GetName(4),26}");
            //Console.WriteLine($"{rdr.GetName(0),-4} {rdr.GetName(1),-10}");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr.GetString(0),-4} {rdr.GetString(1),-10} {rdr.GetString(2),10} {rdr.GetString(3),18} {rdr.GetString(4), 26}");
               // Console.WriteLine($"{rdr.GetString(0),-4} {rdr.GetString(1),-10}");
                //MessageBox.Show("Successfull!!!");
            }
        }
        // Static users
        static Manager manager = null;
        static Student student = null;
        static Admin admin = null;
        static User root = new User();

        // Static needed attributes for connection
        static MySqlConnection conn = new MySqlConnection(
            "server=103.200.22.212;user=luanapco_admin;database=luanapco_Database;port=3306;password=AWb@8AzpaqzH9Ev");
        static MySqlCommand command = new MySqlCommand("",conn);

        
        // Static needed attributes for navigating between forms
        static Form currentForm = null;
        static Stack<Form> previousForm = null;
        static void LogIn(string username, string password)
        {
            // Login using table Users
            
        }

        static void LogOut()
        {
            root.MainScreen();
            manager = null;
            student = null;
            admin = null;
            conn.Close();
        }
    }
}
