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
    public partial class BOOK_ROOM : Form
    {
        private BUS.BOOK_ROOM bookRoomBUS;

        private DataGridViewRow currentPH = null;
        private DataGridViewRow currentNH = null;

        public BOOK_ROOM()
        {
            bookRoomBUS = new BUS.BOOK_ROOM();
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            dtvPH.DataSource = bookRoomBUS.getPhongTrong();
            dtvNH.DataSource = bookRoomBUS.getNhomTrong();


            UTILS.showColumn(ref dtvPH, new string[] { "MAPHONG", "TEN_TT", "GHICHU" });
            UTILS.showColumn(ref dtvNH, new string[] { "MANHOM" });
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            UTILS.DeselectCell(ref dtvNH, ref currentNH);
            UTILS.DeselectCell(ref dtvPH, ref currentPH);
        }

        private void btnBangDatPhong_Click(object sender, EventArgs e)
        {
            Bang_Dat_Phong Bang_Dat_Phong = new Bang_Dat_Phong(currentPH, currentNH);

            Bang_Dat_Phong.StartPosition = FormStartPosition.CenterScreen;

            Bang_Dat_Phong.BringToFront();
            Bang_Dat_Phong.Show();
        }

        private void BOOK_ROOM_Shown(object sender, EventArgs e)
        {
            dtvNH.ClearSelection();
            dtvPH.ClearSelection();
        }

        

        private void dtvNH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            bool selected = UTILS.SelectRow(e, ref dtvNH, ref currentNH);
        }

        private void dtvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UTILS.clickHeader(e)) return;

            string tinhTrang = dtvPH["TEN_TT", e.RowIndex].Value.ToString();

            bool isReturn = tinhTrang.Contains("Đ");

            bool selected = UTILS.SelectRow(e, ref dtvPH, ref currentPH, isReturn);
        }
    }
}
