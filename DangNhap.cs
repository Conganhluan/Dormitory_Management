using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public bool IsLoggedIn { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DATA dal = new DATA();
            string sql = "select * from Users where Username='" + textUser.Text + "' and Password='" + textPass.Text + "'";
            if (dal.login(sql) == true)
            {
                //select cell Permission SQL

                string sql1 = "select * from Users where Username='" + textUser.Text + "'and Quyen='" + "ADMIN" + "'";
                DataTable dt = new DataTable();
                dt = dal.GetTable(sql1);
                if (dal.login(sql1) == true)
                {
                    FrmMenu form1 = new FrmMenu();
                    form1.Show();

                    this.Hide();
                }
                
                //if Row[0][3] is ADMIN show form1
                
                    
                
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
