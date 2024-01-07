using Restaurant_Management.SHARE;
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
    public partial class MANAGE_NHANVIEN : Form
    {
        private BUS.MANAGE_NHANVIEN nvBUS;
        private DataGridViewRow currentNV = null;

        public MANAGE_NHANVIEN()
        {
            nvBUS = new BUS.MANAGE_NHANVIEN();
            InitializeComponent();
            loadData();
            resetLb();
        }

        private void loadData()
        {
            dtvNV.DataSource = nvBUS.getNV();
            UTILS.showColumn(ref dtvNV, new string[] { "MANV", "TENNV", "TENLOAI", "TENQUYEN" });
        }

        private void resetLb()
        {
            lbCV.Text = String.Empty;
            lbLOAI.Text = String.Empty;
            lbMANV.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbMANV_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCV_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool select = UTILS.selectRow(e, ref dtvNV, ref currentNV);

            if (!select)
            {
                resetLb();
                return;
            }

            lbCV.Text = currentNV.Cells["TENLOAI"].Value.ToString();
            lbLOAI.Text = currentNV.Cells["TENQUYEN"].Value.ToString();
            lbMANV.Text = currentNV.Cells["MANV"].Value.ToString();
        }

        private void MANAGE_NHANVIEN_Shown(object sender, EventArgs e)
        {
            dtvNV.ClearSelection();
        }
    }
}
