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
    public partial class SEARCH_NHANVIEN : Form
    {
        private BUS.SEARCH_NHANVIEN nvBUS;
        private DataGridViewRow currentRow;
        private bool select = false;
        public SEARCH_NHANVIEN()
        {
            nvBUS = new BUS.SEARCH_NHANVIEN();
            InitializeComponent();
            loadData();
            resetBox();
        }

        private void resetBox()
        {
            boxCV.Text = String.Empty;
            boxLOAI.Text = String.Empty;
            boxMANV.Text = String.Empty;
        }

        private void loadData(DataTable dt = null)
        {
            dtvContent.Columns.Clear();


            if (dt == null)
                dtvContent.DataSource = nvBUS.getNV();
            else
                dtvContent.DataSource = dt;

            UTILS.showColumn(ref dtvContent, new string[] { "MANV", "TENNV", "TENLOAI", "TENQUYEN" });
            dtvContent.ClearSelection();
        }

        private void dtvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            select = UTILS.selectRow(e, ref dtvContent, ref currentRow);

            if (!select)
            {
                resetBox();
                return;
            }

            boxCV.Text = currentRow.Cells["TENLOAI"].Value.ToString();
            boxLOAI.Text = currentRow.Cells["TENQUYEN"].Value.ToString();
            boxMANV.Text = currentRow.Cells["MANV"].Value.ToString().Trim();

            select = false;
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            loadData();
            dtvContent.ClearSelection();
            currentRow = null;

            resetBox();
        }

        private void SEARCH_NHANVIEN_Shown(object sender, EventArgs e)
        {
            dtvContent.ClearSelection();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxTextChanged(object sender, EventArgs e)
        {
            if (select) { return; }

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
