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
    public partial class MANAGE_KHACHHANG : Form
    {
        private BUS.MANAGE_KHACHHANG khBUS;

        private DataGridViewRow currentKH = null;
        private DataGridViewRow currentL_KH = null;
        private DataGridViewRow currentPT = null;

        public MANAGE_KHACHHANG()
        {
            khBUS = new BUS.MANAGE_KHACHHANG();
            InitializeComponent();
            loadData();
            resetLabel();
        }

        private void resetLbKH()
        {
            BOX_CMND.Text = String.Empty;
            BOX_DIACHI.Text = String.Empty;
            BOX_MAKH.Text = String.Empty;
            BOX_TENKH.Text = String.Empty;
        }

        private void resetLbLKH()
        {
            BOX_MALOAI.Text = String.Empty;
            BOX_TENLOAI.Text = String.Empty;
        }

        private void resetLbPT()
        {
            BOX_MADK.Text = String.Empty;
            BOX_SLDK.Text = String.Empty;
            BOX_DKPT.Text = String.Empty;
        }

        private void resetLabel()
        {
            resetLbKH();
            resetLbLKH();
            resetLbPT();
        }

        private void loadData()
        {
            dtvKH.DataSource = khBUS.getKhachHang();

            UTILS.showColumn(ref dtvKH, new string[] { "MAKH", "TENKH", "CMND", "DIACHI" });
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MANAGE_KHACHHANG_Shown(object sender, EventArgs e)
        {
            dtvKH.ClearSelection();
        }

        private void dtvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool selected = UTILS.selectRow(e, ref dtvKH, ref currentKH);

            dtvLKH.DataSource = null;
            currentL_KH = null;

            dtvNH_PT.DataSource = null;
            currentPT = null;

            if (!selected)
            {
                resetLabel();
                return;
            }

            dtvLKH.DataSource = khBUS.getLoaiKHByMa(currentKH.Cells["MALOAI"].Value.ToString());
            UTILS.showColumn(ref dtvLKH, new string[] {"MALOAI", "TENLOAI"});
            dtvLKH.ClearSelection();

            BOX_CMND.Text = currentKH.Cells["CMND"].Value.ToString();
            BOX_DIACHI.Text = currentKH.Cells["DIACHI"].Value.ToString();
            BOX_MAKH.Text = currentKH.Cells["MAKH"].Value.ToString();
            BOX_TENKH.Text = currentKH.Cells["TENKH"].Value.ToString();
        }

        private void dtvLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool selected = UTILS.selectRow(e, ref dtvLKH, ref currentL_KH);

            dtvNH_PT.DataSource = null;
            currentPT = null;

            if (!selected)
            {
                resetLbLKH();
                resetLbPT();
                return;
            }

            dtvNH_PT.DataSource = khBUS.getDK_PTByNhom(currentL_KH.Cells["MANH_DK_PT"].Value.ToString());
            UTILS.showColumn(ref dtvNH_PT, new string[] {"MADK_PT", "PHUTHU", "SL"});
            dtvNH_PT.ClearSelection();

            BOX_MALOAI.Text = currentL_KH.Cells["MALOAI"].Value.ToString();
            BOX_TENLOAI.Text = currentL_KH.Cells["TENLOAI"].Value.ToString();
        }

        private void dtvNH_PT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool selected = UTILS.selectRow(e, ref dtvNH_PT, ref currentPT);

            if (!selected)
            {
                resetLbPT();
                return;
            }

            BOX_MADK.Text = currentPT.Cells["MADK_PT"].Value.ToString();
            BOX_SLDK.Text = currentPT.Cells["SL"].Value.ToString();
            BOX_DKPT.Text = currentPT.Cells["PHUTHU"].Value.ToString();

        }
    }
}
