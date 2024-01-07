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
    public partial class MANAGE_DKPT : Form
    {
        private BUS.MANAGE_DKPT dkptBUS;
        private DataGridViewRow currentNH_DKPT;
        private List<DataGridViewRow> currentDKPTs;
        public MANAGE_DKPT()
        {
            dkptBUS = new BUS.MANAGE_DKPT();
            InitializeComponent();
            loadData();
            resetLb();

            currentDKPTs = new List<DataGridViewRow> { };
        }

        private void loadData()
        {
            dtvNH_DK.DataSource = dkptBUS.getNH_DKPT();
            dtvDK.DataSource = dkptBUS.getDK_PT();
        }

        public void resetLb()
        {
            lbMANH_DK.Text = String.Empty;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dtvNH_DK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool select = UTILS.selectRow(e, ref dtvNH_DK, ref currentNH_DKPT);

            if (!select)
            {
                resetLb();
                UTILS.deselectTable(ref dtvDK);
                return;
            }

            lbMANH_DK.Text = currentNH_DKPT.Cells["MANH_DK_PT"].Value.ToString();

            DataTable dt = dkptBUS.getDK_PTByNhom(lbMANH_DK.Text);

            Console.WriteLine(dt.Rows.Count);

            UTILS.selectMultiRow(ref dtvDK, ref currentDKPTs, dt, "MADK_PT");
        }

        private void dtvDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool select = UTILS.selectMultiRow(e, ref dtvDK, ref currentDKPTs);
        }

        private void MANAGE_DKPT_Shown(object sender, EventArgs e)
        {
            dtvNH_DK.ClearSelection();
            dtvDK.ClearSelection();
        }
    }
}
