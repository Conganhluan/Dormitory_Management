using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DormitoryManagment
{
    internal class Tang
    {
        DATA dal = new DATA();
        public DataTable GETTANG()
        {
            string sql = "SELECT * FROM TANG";
            return dal.GetTable(sql);
        }
        public void UPDATE(String toa, String tentang, String quanly, String trangthai)
        {
            try
            {
                string sql1 = "SELECT IDTANG FROM TANG WHERE IDTANG = '" + tentang + "'";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception("Không tồn tại tầng này!");

               string sql = "UPDATE TANG SET IDTOA = '" + toa + "', MANAGER = N'" + quanly + "' , STATUS = N'" + trangthai + "' WHERE IDTANG = '" + tentang + "'";
                dal.ExecNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }   


    }
}
