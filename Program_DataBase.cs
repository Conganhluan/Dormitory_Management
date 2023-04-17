using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DormitoryManagment
{
    internal static class DataBase
    {
        internal static DataTable GetDataSouce(string sql)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, Program.conn);
            adapter.Fill(dt);
            return dt;
        }
    }
}
