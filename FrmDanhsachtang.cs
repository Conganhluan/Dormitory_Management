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
    public partial class FrmDanhsachtang : Form
    {
        public FrmDanhsachtang()
        {
            InitializeComponent();
        }
        Tang tang = new Tang();
        private void ClearBox()
        {
            textBox1.Text = "";
            txtTentang.Text = "";
            txtTrangthai.Text = "";
            cbQuanly.Text = "";
        }
        private void FrmDanhsachtang_Load(object sender, EventArgs e)
        {
            dgvTang.DataSource = tang.GETTANG();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbQuanly.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tên người quản lý!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tang.UPDATE(textBox1.Text, txtTentang.Text, cbQuanly.Text, txtTrangthai.Text);
            btnUp_Click(sender, e);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            FrmDanhsachtang_Load(sender, e);
            ClearBox();
        }

        private void dgvTang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > 0)
            {
                textBox1.Text = dgvTang.Rows[index].Cells[1].Value.ToString();
                txtTentang.Text = dgvTang.Rows[index].Cells[0].Value.ToString();
                cbQuanly.Text = dgvTang.Rows[index].Cells[2].Value.ToString();
                txtTrangthai.Text = dgvTang.Rows[index].Cells[3].Value.ToString();
            }
        }
    }
}
