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
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }

        private int calcDIENNUOC(int sodien, int sonuoc)
        {
            int diennuoc = 0;
            diennuoc = (sodien * 3000) + (sonuoc * 1000);
            return diennuoc;
        }
        Phong phong = new Phong();
        Bill bill = new Bill();
        private void FrmBill_Load(object sender, EventArgs e)
        {
            cbMaphong.DataSource = phong.GETROOM();
            cbMaphong.DisplayMember = "Chọn";
            cbMaphong.ValueMember = "IDROOM";
            dgvTiendiennuoc.DataSource = bill.GETBILL();
            cbTrangthai.Items.Add("Đã thanh toán");
            cbTrangthai.Items.Add("Chưa thanh toán");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int soluongdien = int.Parse(textDienNum.Text);
                int soluongnuoc = int.Parse(textNuocNum.Text);
                if (soluongdien < 0 || soluongnuoc < 0) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Chỉ số điện/nước phải là số dương", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMaphong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbTrangthai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textDienNum.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chỉ số điện", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textNuocNum.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chỉ số nước", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bill.UPBILL(cbMaphong.Text, calcDIENNUOC(int.Parse(textDienNum.Text), int.Parse(textNuocNum.Text)));
            bill.INSERT(textMa.Text, cbMaphong.Text, dtpNgaylap.Value, int.Parse(textDienNum.Text), int.Parse(textNuocNum.Text), calcDIENNUOC(int.Parse(textDienNum.Text), int.Parse(textNuocNum.Text)), cbTrangthai.Text);

            btnUp_Click(sender, e);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            FrmBill_Load(sender, e);
            ClearBox();
            cbMaphong.Enabled = true;
            dtpNgaylap.Enabled = true;
            cbTrangthai.Enabled = true;
            textDienNum.Enabled = true;
            textNuocNum.Enabled = true;
        }

        private void ClearBox()
        {
            cbMaphong.Text = "";
            dtpNgaylap.Text = "";
            cbTrangthai.Text = "";
            textDienNum.Text = "";
            textNuocNum.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMaphong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbTrangthai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn trạng thái!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bill.UPDATE(textMa.Text, cbMaphong.Text, dtpNgaylap.Value, int.Parse(textDienNum.Text), int.Parse(textNuocNum.Text), calcDIENNUOC(int.Parse(textDienNum.Text), int.Parse(textNuocNum.Text)), cbTrangthai.Text);
            btnUp_Click(sender, e);
        }

        private void dgvTiendiennuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
               textMa.Text = dgvTiendiennuoc.Rows[index].Cells[0].Value.ToString();
                cbMaphong.Text = dgvTiendiennuoc.Rows[index].Cells[1].Value.ToString();
                textDienNum.Text = dgvTiendiennuoc.Rows[index].Cells[3].Value.ToString();
                textNuocNum.Text = dgvTiendiennuoc.Rows[index].Cells[4].Value.ToString() ;
                cbTrangthai.Text = dgvTiendiennuoc.Rows[index].Cells[6].Value.ToString();
                //if (cbTrangthai.Text == "Chưa thanh toán")
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textMa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bill.DELETE(textMa.Text);
                btnUp_Click(sender, e);
            }
            else if (dlr == DialogResult.No) { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                if (cbMaphong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvTiendiennuoc.DataSource = bill.SEARCH(cbMaphong.Text, "IDROOM");
            }
            else if (rb2.Checked)
            {
                if (cbTrangthai.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn trạng thái tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvTiendiennuoc.DataSource = bill.SEARCH(cbTrangthai.Text, "STATUSBILL");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn trạng thái tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
