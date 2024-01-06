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
            lbCMND.Text = String.Empty;
            lbDC.Text = String.Empty;
            lbMAKH.Text = String.Empty;
            lbTENKH.Text = String.Empty;
        }

        private void resetLbLKH()
        {
            lbMALOAI.Text = String.Empty;
            lbTENLOAI.Text = String.Empty;
        }

        private void resetLbPT()
        {
            lbMAPT.Text = String.Empty;
            lbSL.Text = String.Empty;
            lbPT.Text = String.Empty;
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

            bool selected = UTILS.SelectRow(e, ref dtvKH, ref currentKH);

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

            lbCMND.Text = currentKH.Cells["CMND"].Value.ToString();
            lbDC.Text = currentKH.Cells["DIACHI"].Value.ToString();
            lbMAKH.Text = currentKH.Cells["MAKH"].Value.ToString();
            lbTENKH.Text = currentKH.Cells["TENKH"].Value.ToString();
        }

        private void dtvLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool selected = UTILS.SelectRow(e, ref dtvLKH, ref currentL_KH);

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

            lbMALOAI.Text = currentL_KH.Cells["MALOAI"].Value.ToString();
            lbTENLOAI.Text = currentL_KH.Cells["TENLOAI"].Value.ToString();
        }

        private void dtvNH_PT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool selected = UTILS.SelectRow(e, ref dtvNH_PT, ref currentPT);

            if (!selected)
            {
                resetLbPT();
                return;
            }

            lbMAPT.Text = currentPT.Cells["MADK_PT"].Value.ToString();
            lbSL.Text = currentPT.Cells["SL"].Value.ToString();
            lbPT.Text = currentPT.Cells["PHUTHU"].Value.ToString();

        }
    }
}
