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
    public partial class MANAGE_ROOM : Form
    {
        private BUS.MANAGE_ROOM phBUS;
        private DataGridViewRow currentRow;
        private Button currentOption;
        public MANAGE_ROOM()
        {
            phBUS = new BUS.MANAGE_ROOM();
            InitializeComponent();
        }

        private void dtvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool select = UTILS.selectRow(e, ref dtvContent, ref currentRow);
        }

        private void MANAGE_ROOM_Shown(object sender, EventArgs e)
        {
            btnPH.PerformClick();
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            UTILS.deselectRow(ref dtvContent, ref currentRow);
            
            dtvContent.Columns.Clear();
            dtvContent.DataSource = phBUS.getPHONG_ALL();
            currentOption = btnPH;

            dtvContent.ClearSelection();


        }

        private void btnLP_Click(object sender, EventArgs e)
        {
            UTILS.deselectRow(ref dtvContent, ref currentRow);

            dtvContent.Columns.Clear();
            dtvContent.DataSource = phBUS.getLP();
            currentOption = btnLP;

            dtvContent.ClearSelection();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            UTILS.deselectRow(ref dtvContent, ref currentRow);

            dtvContent.Columns.Clear();
            dtvContent.DataSource = phBUS.getTT();
            currentOption = btnTT;

            dtvContent.ClearSelection();

        }
    }
}
