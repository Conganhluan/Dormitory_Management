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

namespace DormitoryManagment
{
    internal static class Program
    {
        static void Main(string[] args)
        {

        }

        private static Manager manager = null;
        private static Student student = null;
        private static Admin admin = null;
        private static User root = new User();

        private static void LogIn(string username, string password)
        {
            // Login using table Users
        }

        private static void LogOut()
        {
            root.MainScreen();
            manager = null;
            student = null;
            admin = null;
        }
    }
}
