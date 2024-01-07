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
    public partial class MANAGE_QUYEN : Form
    {
        private BUS.MANAGE_QUYEN qBUS;

        private DataGridViewRow currentQ;
        public MANAGE_QUYEN()
        {
            qBUS = new BUS.MANAGE_QUYEN();
            InitializeComponent();
            loadData();
            resetLb();
        }

        private void loadData()
        {
            dtvQUYEN.DataSource = qBUS.getHT();

            Console.WriteLine(dtvQUYEN.Columns);

            UTILS.hideColmn(ref dtvQUYEN, new string[] { "MA_QUYEN1" });
        }

        private void MANAGE_QUYEN_Shown(object sender, EventArgs e)
        {
            dtvQUYEN.ClearSelection();
        }

        private void resetLb()
        {
            lbMANV.Text = String.Empty;
            lbMA_QUYEN.Text = String.Empty;
            lbPASSWORD.Text = String.Empty;
            lbUSERNAME.Text = String.Empty;
        }

        private void dtvQUYEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) { return; }

            bool select = UTILS.selectRow(e, ref dtvQUYEN, ref currentQ);

            if (!select)
            {
                resetLb();
                return;
            }

            lbMANV.Text = currentQ.Cells["MANV"].Value.ToString();
            lbMA_QUYEN.Text = currentQ.Cells["MA_QUYEN"].Value.ToString();
            lbPASSWORD.Text = currentQ.Cells["PASSWORD"].Value.ToString();
            lbUSERNAME.Text = currentQ.Cells["USERNAME"].Value.ToString();
        }
    }
}
