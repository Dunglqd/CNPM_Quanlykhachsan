using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class MANAGE_PTP : Form
    {
        private BUS.MANAGE_PHIEUTHUEPHONG ptpBUS;

        private DataGridViewRow currentPTP = null;

        public MANAGE_PTP()
        {
            ptpBUS = new BUS.MANAGE_PHIEUTHUEPHONG();
            InitializeComponent();
            loadData();
            resetLb();
        }

        private void loadData()
        {
            dtvPTP.DataSource = ptpBUS.getPTP();
            UTILS.showColumn(ref dtvPTP);
        }

        private void resetLb()
        {
            lbMAKH.Text = string.Empty;
            lbMANHOM.Text = string.Empty;
            lbMANV.Text = string.Empty;
            lbMAPHONG.Text = string.Empty;
            lbMAPT.Text = string.Empty;
            lbNGBD.Text = string.Empty;
            lbTYLE.Text = string.Empty;
        }

        private void dtvPTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool select = UTILS.selectRow(e, ref dtvPTP, ref currentPTP);

            if (!select)
            {
                resetLb();
                return;
            }

            lbMAKH.Text = currentPTP.Cells["MAKH"].Value.ToString();
            lbMANHOM.Text = currentPTP.Cells["MANHOM"].Value.ToString();
            lbMANV.Text = currentPTP.Cells["MANV"].Value.ToString();
            lbMAPHONG.Text = currentPTP.Cells["MAPHONG"].Value.ToString();
            lbMAPT.Text = currentPTP.Cells["MAPT"].Value.ToString();
            lbNGBD.Text = currentPTP.Cells["NGBD"].Value.ToString();
            lbTYLE.Text = ptpBUS.getgetTyleByMaNH(currentPTP.Cells["MANHOM"].Value.ToString()).ToString();
        }

        private void MANAGE_PTP_Shown(object sender, EventArgs e)
        {
            dtvPTP.ClearSelection();
        }
    }
}
