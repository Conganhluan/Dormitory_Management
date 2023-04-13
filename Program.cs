<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> 5bb73dcdc23bbe145ceae671046f668b422984b3
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
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> 5bb73dcdc23bbe145ceae671046f668b422984b3

namespace DormitoryManagment
{
    internal static partial class Program
    {
        // The program starts here
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            conn.Open();
            Application.Run(new StartScreen());
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
        internal static Manager manager = null;
        internal static Student student = null;
        internal static Admin admin = null;

        // Static needed attributes for connection
        internal static MySqlConnection conn = new MySqlConnection(
            "server=103.200.22.212;user=luanapco_admin;database=luanapco_Database;port=3306;password=AWb@8AzpaqzH9Ev");
    }
}
=======
            Application.Run(new startScreen());
        }

        // Static users
        static Manager manager = null;
        public static Student student = null;
        static Admin admin = null;
        static User root = new User();

        // Static needed attributes for connection
        static MySqlConnection conn = new MySqlConnection(
            "server=103.200.22.212;user=luanapco_admin;database=luanapco_Database;port=3306;password=AWb@8AzpaqzH9Ev");
    }
}
>>>>>>> 5bb73dcdc23bbe145ceae671046f668b422984b3
