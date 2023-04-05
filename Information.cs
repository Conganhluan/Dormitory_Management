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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void lbChange_Click(object sender, EventArgs e)
        {
            Changepass changepass = new Changepass();
            changepass.Show();
            this.Hide();

        }
    }
}
