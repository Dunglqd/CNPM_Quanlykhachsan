using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class BOOK_ROOM
    {
        DAO.PHONG phongDAO;
        DAO.NHOM nhomDAO;

        public BOOK_ROOM()
        {
            phongDAO = new DAO.PHONG();
            nhomDAO = new DAO.NHOM();
        }

        public DataTable getPhongTrong()
        {
            DataTable dt = phongDAO.getPhongTrong();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getNhomTrong()
        {
            DataTable dt = nhomDAO.getNhomTrong();
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
