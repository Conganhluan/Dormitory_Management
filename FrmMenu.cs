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
    public partial class FrmMenu : Form
    {
        private Button currentButton;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sender, int r, int g, int b)
        {
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(r, g, b);
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = SystemColors.Window;
                    previousBtn.ForeColor = SystemColors.ControlText;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm, Size size, Point point)
        {
            if (activeForm != null)
                activeForm.Close();
            //panelControl.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnOut.Visible = true;

        }
        private void customizeDesign()
        {
            panel1.Visible = false;
            
        }

        private void hideSubMenu()
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, 255, 152, 0);
            openChildForm(new FrmQuanLySinhVien(), new Size(180, 26), new Point(325, 15));
        }

        private void btnToa_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, 199, 220, 91);
            showSubMenu(panel1);
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDanhsachtang(), new Size(180, 26), new Point(325, 15)); 
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyPhong(),  new Size(180, 26), new Point(325, 15));
            
        }

        private void btnDienNuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmBill(), new Size(180, 26), new Point(325, 15));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();

            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangnhap = new DangNhap();
            dangnhap.Show();
        }
    }
}
