using Restaurant_Management.DAO;
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

        private DataGridViewRow currentPH;
        private DataGridViewRow currentLP;
        private DataGridViewRow currentTT;

        private Button currentOption;
        public MANAGE_ROOM()
        {
            phBUS = new BUS.MANAGE_ROOM();
            InitializeComponent();
        }

        private void dtvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool select = false;
            
            
            if (currentOption == btnPH)
                select = UTILS.selectRow(e, ref dtvContent, ref currentPH);
            else if (currentOption == btnLP)
                select = UTILS.selectRow(e, ref dtvContent, ref currentLP);
            else
                select = UTILS.selectRow(e, ref dtvContent, ref currentTT);
        }

        private void MANAGE_ROOM_Shown(object sender, EventArgs e)
        {
            btnPH.PerformClick();
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            UTILS.deselectRow(ref dtvContent, ref currentPH);
            
            dtvContent.Columns.Clear();
            dtvContent.DataSource = phBUS.getPHONG_ALL();
            currentOption = btnPH;

            dtvContent.ClearSelection();


        }

        private void btnLP_Click(object sender, EventArgs e)
        {
            UTILS.deselectRow(ref dtvContent, ref currentLP);

            dtvContent.Columns.Clear();
            dtvContent.DataSource = phBUS.getLP();
            currentOption = btnLP;

            dtvContent.ClearSelection();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            UTILS.deselectRow(ref dtvContent, ref currentTT);

            dtvContent.Columns.Clear();
            dtvContent.DataSource = phBUS.getTT();
            currentOption = btnTT;

            dtvContent.ClearSelection();

        }

        private void btnDEL_Click(object sender, EventArgs e)
        {

            if (currentOption == btnPH)
            {
                if (currentPH == null) return;

                if (currentPH.Cells["MATT"].Value.ToString().Trim() != "TT1")
                {
                    MessageBox.Show("Chỉ phòng chưa sử dụng mới được xoá");
                    return;
                }

                phBUS.deletePH(currentPH.Cells["MAPHONG"].Value.ToString().Trim());
                btnPH.PerformClick();
            }
            else if (currentOption == btnLP)
            {
                if (currentLP == null) return;

                string ML = currentLP.Cells["MALOAI"].Value.ToString().Trim();
                if (!phBUS.getLPTrong().Contains(ML))
                {
                    MessageBox.Show("Chỉ loại phòng chưa sử dụng mới được xoá");
                    return;
                }

                phBUS.deleteLP("MALOAI".pair(SqlDbType.NChar, currentLP.Cells["MALOAI"].Value.ToString().Trim()));
                btnLP.PerformClick();
            }
            else
            {
                if (currentTT == null) return;

                string ML = currentTT.Cells["MATT"].Value.ToString().Trim();
                if (!phBUS.getLPTrong().Contains(ML))
                {
                    MessageBox.Show("Chỉ loại tình trạng chưa sử dụng mới được xoá");
                    return;
                }

                phBUS.deleteTT("MATT".pair(SqlDbType.NChar, currentTT.Cells["MATT"].Value.ToString().Trim()));
                btnTT.PerformClick();
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (currentLP == null || currentOption != btnLP)
            {
                MessageBox.Show("Hãy chọn loại phòng");
                return;
            }

            string MALOAI = currentLP.Cells["MALOAI"].Value.ToString().Trim();
            phBUS.insertPH(
                "MAPHONG".pair(SqlDbType.NChar, UTILS.getMA("PHONG", "MAPHONG")),
                "MALOAI".pair(SqlDbType.NChar, MALOAI),
                "GHICHU".pair(SqlDbType.NText, ""),
                "MATT".pair(SqlDbType.NChar, "TT1")
            );

            btnPH.PerformClick();
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            dtvContent.ClearSelection();

            if (currentOption == btnPH)
            {
                UTILS.deselectRow(ref dtvContent, ref currentPH);
                currentPH = null;
            }
            else if (currentOption == btnLP)
            {
                UTILS.deselectRow(ref dtvContent, ref currentLP);
                currentLP = null;
            }
            else
            {
                UTILS.deselectRow(ref dtvContent, ref currentTT);
                currentTT = null;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
