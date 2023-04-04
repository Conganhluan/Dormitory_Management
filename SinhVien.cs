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
    internal class SinhVien
    {
        DATA dal = new DATA();

        public DataTable GetSV()
        {
            string sql = "SELECT * FROM SINHVIEN";
            return dal.GetTable(sql);
        }

        public DataTable GetID()
        {
            string sql = "SELECT ID FROM SINHVIEN";
            return dal.GetTable(sql);
        }

        public DataTable GetRoom()
        {
            string st = "Thiếu";
            string sql = "SELECT * FROM ROOM WHERE STATUS = N'" + st + "'";
            return dal.GetTable(sql);
        }

        public DataTable GETNUM(string map)
        {
            string sql = "SELECT NUMST, NUMSTMAX FROM ROOM WHERE IDROOM = '" + map + "'";
            return dal.GetTable(sql);
        }
        public DataTable GETIDROOMOLD(string id)
        {
            string sql = "SELECT IDROOM FROM SINHVIEN WHERE ID ='" + id + "'";
            return dal.GetTable(sql);
        }
        public void UpdateSt(string map, string st)
        {
            try
            {
                string sql = "UPDATE ROOM SET STATUS = N'" + st + "' WHERE IDROOM = '" + map + "' ";
                dal.ExecNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void UpdateNumRoom(string map, int sl)
        {
            try
            {
                string sql = "UPDATE ROOM SET NUMST = NUMST+'" + sl + "' WHERE IDROOM = '" + map + "' ";
                dal.ExecNonQuery(sql);
                int num = int.Parse(GETNUM(map).Rows[0][0].ToString());
                int nummax = int.Parse(GETNUM(map).Rows[0][1].ToString());
                if (num == nummax) UpdateSt(map, "Đủ");
                if (num < nummax) UpdateSt(map, "Thiếu");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void INSERTSV(String ID, String name, String gen, DateTime dt, String add, String CC, String khoa, String school, String toa, String idroom, String sdt, String mail)
        {
            try
            {
                String sql = "SET IDENTITY_INSERT [dbo].[SINHVIEN] ON INSERT [dbo].[SINHVIEN] ([ID], [NAME], [GENDER], [DATE], [ADDRESS], [CCCD], [KHOA], [SCHOOL], [TOA], [IDROOM], [PHONE], [EMAIL])  VALUES('" + ID + "', N'" + name + "', N'" + gen + "','" + dt.ToString("yyyy-MM-dd") + "'," +
                    "N'" + CC + "',N'" + add + "','" + khoa + "','" + school + "', N'" + toa + "','" + idroom + "',N'" + sdt + "',N'" + mail + "') SET IDENTITY_INSERT [dbo].[SINHVIEN] OFF";
                dal.ExecNonQuery(sql);
                UpdateNumRoom(idroom, 1);
                MessageBox.Show("Đã thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DELETE(String ID)
        {
            try
            {
                string sqld = "SELECT ID FROM SINHVIEN WHERE ID ='" + ID + "'";
                DataTable dt = dal.GetTable(sqld);
                if (dt.Rows[0][0].ToString() == "") throw new Exception();
                string sql = "DELETE SINHVIEN WHERE ID ='" + ID + "'";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không tồn tại mã sinh viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UPDATE(String ID, String name, String gen, DateTime dt, String add, String CC, String khoa, String school, String toa, String idroom, String sdt, String mail)
        {
            try
            {
                string sqlUp = "SELECT ID FROM SINHVIEN WHERE ID ='" + ID + "'";
                DataTable dt1 = dal.GetTable(sqlUp);
                if (dt1.Rows[0][0].ToString() == "") throw new Exception("Không tồn tại mã số sinh viên");
                string sql = "UPDATE SINHVIEN SET NAME= N'" + name + "' ,GENDER=N'" + gen + "' ,DATE=N'" + dt.ToString("yyyy-MM-dd") + "' ," +
                    "ADDRESS= N'" + add + "' , CCCD='" + CC + "' ,KHOA=N'" + khoa + "', SCHOOL= N'" + school + "' ,TOA=N'" + toa + "' ,IDROOM=N'"
                    + idroom + "', PHONE=N'" + sdt + "', EMAIL=N'" + mail + "' ";
                dal.ExecNonQuery(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã sinh viên không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public DataTable SEARCH(String chuoi, String truong)
        {
            string sql = "SELECT * FROM SINHVIEN WHERE " + truong + " LIKE N'%" + chuoi + "%'";
            return dal.GetTable(sql);

        }
    }
}
