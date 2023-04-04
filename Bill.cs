using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace DormitoryManagment
{
    internal class Bill
    {
        DATA dal = new DATA();

        public DataTable GETBILL()
        {
            string sql = "SELECT * FROM BILL";
            return dal.GetTable(sql);
        }

        public void UPBILL(string map, int bill)
        {
            try
            {
                string sql1 = "SELECT IDROOM FROM ROOM WHERE IDROOM='" + map + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "UPDATE ROOM SET MONEYBILL = '" + bill + "' WHERE IDROOM = '" + map + "' ";
                dal.ExecNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UPSTROOM(string map, string st)
        {
            try
            {
                string sql1 = "SELECT IDROOM FROM ROOM WHERE IDROOM='" + map + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "UPDATE ROOM SET STATUSBILL = '" + st + "' WHERE IDROOM = '" + map + "' ";
                dal.ExecNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        public void UPSTBILL(string idbill, string st)
        {
            try
            {
                string sql1 = "SELECT IDBILL FROM BILL WHERE IDBILL = '" + idbill + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "UPDATE BILL SET STATUS = N'" + st + "' WHERE IDBILL ='" + idbill + "' ";
                dal.ExecNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void INSERT(string idbill, string idroom, DateTime date, int dien, int nuoc, int bill, string st)
        {
            try
            {
                string sql = "SET IDENTITY_INSERT [dbo].[BILL] ON INSERT INTO BILL (IDBILL,IDROOM,DATE,DIENNUM,NUOCNUM,MONEYBILL,STATUSBILL) VALUES ('"
                    + idbill + "','" + idroom + "','" + date.ToString("yyyy-MM-dd") + "','" + dien + "','" + nuoc + "','"
                    + bill + "',N'" + st + "') SET IDENTITY_INSERT [dbo].[BILL] OFF";
                dal.ExecNonQuery(sql);

                MessageBox.Show("Đã thêm 1 hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UPDATE(string idbill, string idroom, DateTime date, int dien, int nuoc, int bill, string st)
        {
            try
            {
                string sql1 = "SELECT IDBILL FROM BILL WHERE IDBILL = '" + idbill + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "UPDATE BILL SET IDROOM='" + idroom + "' ,DATE='" + date.ToString("yyyy-MM-dd") + "',DIENNUM='"
                    + dien + "' ,NUOCNUM='" + nuoc + "' ,MONEYBILL='" + bill + "' ,STATUSBILL='" + st + "' WHERE IDBILL ='" + idbill +"' ";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DELETE(string idbill)
        {
            try
            {
                string sql1 = "SELECT IDBILL FROM BILL WHERE IDBILL ='" + idbill + "' ";
                DataTable dt = dal.GetTable(sql1);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "DELETE BILL WHERE IDBILL='" + idbill + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã hóa đơn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable SEARCH(string chuoi, string truong)
        {
            string sql = "SELECT * FROM BILL WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            DataTable dt = dal.GetTable(sql);
            return dt;
        }
    }
}
