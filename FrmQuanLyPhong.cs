using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
{
    public partial class FrmQuanLyPhong : Form
    {
        public FrmQuanLyPhong()
        {
            InitializeComponent();
        }
        Tang tang = new Tang();
        Phong phong = new Phong();


        private void FrmQuanLyPhong_Load(object sender, EventArgs e)
        {
            cmbTang.DataSource = tang.GETTANG();
            cmbTang.ValueMember = "IDTANG";
            dtGVPhong.DataSource = phong.GETROOM(); 

        }
        private void ClearBox()
        {
            textName.Text = "";
            cmbStyle.Text = "";
            textNumReal.Text = "";
            textNumRoom.Text = "";
            cmbStyle.Text = "";
            textStatus.Text = "";
            txtBill.Text = "";
            textStBill.Text = "";
        }   

        private void btnUp_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhong_Load(sender, e);
            checkBox1.Checked = false;
            ClearBox();
        }

        private void dtGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                textName.Text = dtGVPhong.Rows[index].Cells[0].Value.ToString();
                cmbStyle.Text = dtGVPhong.Rows[index].Cells[1].Value.ToString();
                textNumReal.Text = dtGVPhong.Rows[index].Cells[2].Value.ToString();
                textNumRoom.Text = dtGVPhong.Rows[index].Cells[3].Value.ToString();
                cmbStyle.Text = dtGVPhong.Rows[index].Cells[4].Value.ToString();
                textStatus.Text = dtGVPhong.Rows[index].Cells[5].Value.ToString();
                txtBill.Text = dtGVPhong.Rows[index].Cells[6].Value.ToString();
                textStBill.Text = dtGVPhong.Rows[index].Cells[7].Value.ToString();

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textFind.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu cần tìm", "Error", MessageBoxButtons.OK);
                return;
            }
            if (rb1.Checked)
            {
                dtGVPhong.DataSource = phong.SEARCH(textFind.Text, "IDROOM");
            }
            else if (rb2.Checked)
            {
                dtGVPhong.DataSource = phong.SEARCH(textFind.Text, "STYLE");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                dtGVPhong.DataSource = phong.GETROOMHAVESLOT();
            else
                dtGVPhong.DataSource = phong.GETROOM();
        }
    }
}
