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
using System.Data.SqlClient;

namespace DormitoryManagment
{
    internal static partial class Program
    {
        // The program starts here
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartScreen());
        }

        // Static users
        internal static Manager manager = null;
        internal static Student student = null;
        internal static Admin admin = null;

        // Static needed attributes for connection
        internal static MySqlConnection conn = new MySqlConnection(
            "server=103.200.22.212;user=luanapco_admin;database=luanapco_Database;port=3306;password=AWb@8AzpaqzH9Ev");

        // Static needed attributes for interaction with tables
        internal static MySqlDataAdapter adapter = null;
    }
}
