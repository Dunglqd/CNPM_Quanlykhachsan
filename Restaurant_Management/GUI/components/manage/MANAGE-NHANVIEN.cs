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
            resetBox();
        }

        private void loadData(DataTable dt = null)
        {
            if (dt == null)
                dtvNV.DataSource = nvBUS.getNV();
            else
                dtvNV.DataSource = dt;

            UTILS.showColumn(ref dtvNV, new string[] { "MANV", "TENNV", "TENLOAI", "TENQUYEN" });
            dtvNV.ClearSelection();
        }

        private void resetBox()
        {
            boxCV.Text = String.Empty;
            boxLOAI.Text = String.Empty;
            boxMANV.Text = String.Empty;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool select = UTILS.selectRow(e, ref dtvNV, ref currentNV);

            if (!select)
            {
                resetBox();
                return;
            }

            boxCV.Text = currentNV.Cells["TENLOAI"].Value.ToString();
            boxLOAI.Text = currentNV.Cells["TENQUYEN"].Value.ToString();
            boxMANV.Text = currentNV.Cells["MANV"].Value.ToString().Trim();
        }

        private void MANAGE_NHANVIEN_Shown(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {

        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            resetBox();
            loadData();
            dtvNV.ClearSelection();
            currentNV = null;
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            if (UTILS.notString(boxCV.Text)) boxCV.Text = null;
            if (UTILS.notString(boxLOAI.Text)) boxLOAI.Text = null;
            if (UTILS.notString(boxMANV.Text)) boxMANV.Text = null;

            DataTable dt = nvBUS.searchNV(
                "TENQUYEN".pair(SqlDbType.NText, boxLOAI.Text),
                "TENLOAI".pair(SqlDbType.NText, boxCV.Text),
                "NHANVIEN.MANV".pair(SqlDbType.NChar, boxMANV.Text, "MANV")
            );

            loadData(dt);
        }
    }
}
