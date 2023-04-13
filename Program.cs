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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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