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
    public partial class SEARCH_PTP : Form
    {
        private DataGridViewRow currentRow;
        private bool select = false;

        private BUS.SEARCH_PHIEUTHUEPHONG ptpBUS;

        public SEARCH_PTP()
        {
            ptpBUS = new BUS.SEARCH_PHIEUTHUEPHONG();
            InitializeComponent();
            loadData();
            resetBox();
        }


        private void resetBox()
        {
            boxMAKH.Text = String.Empty;
            boxMANV.Text = String.Empty;
            boxMP.Text = String.Empty;
            boxNGBD.Text = String.Empty;
            boxNH.Text = String.Empty;
            boxPT.Text = String.Empty;
            boxTL.Text = String.Empty;
            
            boxNGBD.Enabled = false;
        }

        private void loadData(DataTable dt = null)
        {
            dtvContent.Columns.Clear();


            if (dt == null)
                dtvContent.DataSource = ptpBUS.getPTP();
            else
                dtvContent.DataSource = dt;

            UTILS.showColumn(ref dtvContent);
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

            boxMAKH.Text = currentRow.Cells["MAKH"].Value.ToString();
            boxMANV.Text = currentRow.Cells["MANV"].Value.ToString();
            boxMP.Text = currentRow.Cells["MAPHONG"].Value.ToString();
            boxNGBD.Text = currentRow.Cells["NGBD"].Value.ToString();
            boxNH.Text = currentRow.Cells["MANHOM"].Value.ToString();
            boxPT.Text = currentRow.Cells["MAPT"].Value.ToString();
            boxTL.Text = currentRow.Cells["TYLE"].Value.ToString();

            select = false;
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            loadData();
            dtvContent.ClearSelection();
            currentRow = null;

            resetBox();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxTextChanged(object sender, EventArgs e)
        {
            if (select) { return; }

            if (UTILS.notString(boxMAKH.Text)) boxMAKH.Text = null;
            if (UTILS.notString(boxMANV.Text)) boxMANV.Text = null;
            if (UTILS.notString(boxMP.Text)) boxMP.Text = null;
            if (UTILS.notString(boxNH.Text)) boxNH.Text = null;
            if (UTILS.notString(boxPT.Text)) boxPT.Text = null;

            DataTable dt = ptpBUS.searchPTP(
                "MAKH".pair(SqlDbType.NChar, boxMAKH.Text),
                "MANV".pair(SqlDbType.NChar, boxMANV.Text),
                "MAPHONG".pair(SqlDbType.NChar, boxMP.Text),
                "PHIEUTHUEPHONG.MANHOM".pair(SqlDbType.NChar, boxNH.Text, "MANHOM"),
                "MAPT".pair(SqlDbType.NChar, boxPT.Text)
            );

            if (!UTILS.notString(boxTL.Text))
            { 
                dt = ptpBUS.searchPTP(
                    "MAKH".pair(SqlDbType.NChar, boxMAKH.Text),
                    "MANV".pair(SqlDbType.NChar, boxMANV.Text),
                    "MAPHONG".pair(SqlDbType.NChar, boxMP.Text),
                    "PHIEUTHUEPHONG.MANHOM".pair(SqlDbType.NChar, boxNH.Text, "MANHOM"),
                    "MAPT".pair(SqlDbType.NChar, boxPT.Text),
                    "TYLE".pair(SqlDbType.Float, float.Parse(boxTL.Text))
                );
            }


            loadData(dt);


        }
    }
}
