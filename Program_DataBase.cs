using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DormitoryManagment
{
    internal static class DataBase
    {
        internal static DataTable GetDataSource(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlConnection tableConn = new MySqlConnection(
            "server=103.200.22.212;user=luanapco_admin;database=luanapco_Database;port=3306;password=AWb@8AzpaqzH9Ev");
                
                Program.adapter = new MySqlDataAdapter(sql, tableConn);
                Program.adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        internal static void SaveChanges(DataTable dataTable)
        {
            try
            {
                Program.adapter.UpdateCommand = new MySqlCommandBuilder(Program.adapter).GetUpdateCommand();
                Program.adapter.Update(dataTable);
                MessageBox.Show("Save changes successfully", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
