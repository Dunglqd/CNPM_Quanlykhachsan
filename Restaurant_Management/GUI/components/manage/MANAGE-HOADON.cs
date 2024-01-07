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
    public partial class MANAGE_HOADON : Form
    {
        private BUS.MANAGE_HOADON hdBUS;

        private DataGridViewRow currentHD;

        public MANAGE_HOADON()
        {
            hdBUS = new BUS.MANAGE_HOADON();
            InitializeComponent();
            loadData();
            resetLb();
        }

        private void loadData()
        {
            dtvHD.DataSource = hdBUS.getHD();
            dtvHD.ClearSelection();

            UTILS.showColumn(ref dtvHD);
        }

        private void resetLb()
        {
            lbHD.Text = String.Empty;
            lbKH.Text = String.Empty;
            lbKT.Text = String.Empty;
            lbNV.Text = String.Empty;
            lbPT.Text = String.Empty;
            lbSN.Text = String.Empty;
            lbTT.Text = String.Empty;
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) { return; }
            
            bool select = UTILS.selectRow(e, ref dtvHD, ref currentHD);

            if (!select)
            {
                resetLb();
                return;
            }

            lbHD.Text = currentHD.Cells["MAHD"].Value.ToString();
            lbKH.Text = currentHD.Cells["MAKH"].Value.ToString();
            lbKT.Text = currentHD.Cells["NGKT"].Value.ToString();
            lbNV.Text = currentHD.Cells["MANV"].Value.ToString();
            lbPT.Text = currentHD.Cells["MAPT"].Value.ToString();
            lbSN.Text = currentHD.Cells["SONGAY"].Value.ToString();
            lbTT.Text = currentHD.Cells["THANHTIEN"].Value.ToString();
        }

        private void MANAGE_HOADON_Shown(object sender, EventArgs e)
        {
            dtvHD.ClearSelection();
        }
    }
}
