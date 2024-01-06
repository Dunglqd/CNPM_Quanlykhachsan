using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class BOOKROOM : Form
    {
        public BOOKROOM()
        {
            InitializeComponent();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btnBangDatPhong_Click(object sender, EventArgs e)
        {
            Bang_Dat_Phong Bang_Dat_Phong = new Bang_Dat_Phong();

            Bang_Dat_Phong.StartPosition = FormStartPosition.CenterScreen;

            Bang_Dat_Phong.BringToFront();
            Bang_Dat_Phong.Show();
        }
    }
}
