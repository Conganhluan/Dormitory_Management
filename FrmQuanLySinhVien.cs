using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagment
{
    public partial class FrmQuanLySinhVien : Form
    {
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
        }
        SinhVien sv = new SinhVien();
        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            textPhong.DataSource = sv.GetRoom();
            textPhong.ValueMember = "IDROOM";
            dataGridSV.DataSource = sv.GetSV();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*if (textMS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textGen.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textCC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập CCCD!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textAdd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textToa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tòa!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập phòng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textGmail.Text== "")
            {
                MessageBox.Show("Bạn chưa nhập Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/
            
            sv.INSERTSV(textMS.Text, textName.Text, textGen.Text, dateTimePicker1.Value, textCC.Text, textAdd.Text, cmbKhoa.Text, cmbSchool.Text, textToa.Text, textPhong.Text, textSDT.Text, textGmail.Text);
            btnUp_Click(sender, e);


        }
        private void dataGridSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > 0)
            {
                textMS.Text = dataGridSV.Rows[index].Cells[0].Value.ToString();
                textName.Text = dataGridSV.Rows[index].Cells[1].Value.ToString();
                textGen.Text = dataGridSV.Rows[index].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridSV.Rows[index].Cells[3].Value.ToString();
                textCC.Text = dataGridSV.Rows[index].Cells[4].Value.ToString();
                textAdd.Text = dataGridSV.Rows[index].Cells[5].Value.ToString();
                cmbKhoa.Text = dataGridSV.Rows[index].Cells[6].Value.ToString();
                cmbSchool.Text = dataGridSV.Rows[index].Cells[7].Value.ToString();
                textToa.Text  = dataGridSV.Rows[index].Cells[8].Value.ToString();
                textPhong.Text = dataGridSV.Rows[index].Cells[9].Value.ToString();
                textSDT.Text = dataGridSV.Rows[index].Cells[10].Value.ToString();
                textGmail.Text = dataGridSV.Rows[index].Cells[11].Value.ToString();
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            FrmQuanLySinhVien_Load(sender, e);
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (textMS.Text=="")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                sv.DELETE(textMS.Text);
                btnUp_Click(sender, e);
            }
            else if (dlr == DialogResult.No) { return; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* if (textMS.Text == "")
             {
                 MessageBox.Show("Vui lòng chọn 1 dòng để sửa",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textName.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập tên sinh viên",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textGen.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập giới tính",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textCC.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập CCCD",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textAdd.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập địa chỉ",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textToa.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập tòa",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textPhong.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập phòng",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textSDT.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập SĐT",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
             else if (textGmail.Text == "")
             {
                 MessageBox.Show("Vui lòng nhập Email",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;     
             }*/
            
            string idroomold = sv.GETIDROOMOLD(textMS.Text).Rows[0][0].ToString();
            sv.UpdateNumRoom(idroomold, -1);
            sv.UPDATE(textMS.Text, textName.Text, textGen.Text, dateTimePicker1.Value, textCC.Text, textAdd.Text, cmbKhoa.Text, cmbSchool.Text, textToa.Text, textPhong.Text, textSDT.Text, textGmail.Text);
            sv.UpdateNumRoom(textPhong.Text, 1);
            btnUp_Click(sender, e);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textFind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(rb1.Checked)
            {
                dataGridSV.DataSource = sv.SEARCH(textFind.Text, "ID");
            }
            else if(rb2.Checked)
            {
                dataGridSV.DataSource = sv.SEARCH(textFind.Text, "NAME");
            }
            else if (rb3.Checked)
            {
                dataGridSV.DataSource = sv.SEARCH(textFind.Text, "IDROOM");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 trường để tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
    
}
