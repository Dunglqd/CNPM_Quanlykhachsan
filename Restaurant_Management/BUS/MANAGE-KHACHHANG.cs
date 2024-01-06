using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class MANAGE_KHACHHANG
    {
        private DAO.KHACHHANG khDAO;
        private DAO.LOAIKH l_khDAO;
        DAO.DK_PHUTHU ptDAO;

        public MANAGE_KHACHHANG()
        {
            khDAO = new DAO.KHACHHANG();
            l_khDAO = new DAO.LOAIKH();
            ptDAO = new DAO.DK_PHUTHU();
        }

        public DataTable getKhachHang()
        {
            DataTable dt = khDAO.getKhachHang();

            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getLoaiKHByMa(string MAKH)
        {
            DataTable dt = l_khDAO.getLoaiKHByMa(MAKH);
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getDK_PTByNhom(string MANHOM)
        {
            DataTable dt = ptDAO.getDK_PTByNhom(MANHOM);
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
