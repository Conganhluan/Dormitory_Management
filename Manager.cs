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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        

        private void btnPro_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Hide();
        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            StudentMana studentMana = new StudentMana();
            studentMana.Show();
            this.Hide();

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            BillsMana billsMana = new BillsMana();
            billsMana.Show();
            this.Hide();
        }
    }
}
