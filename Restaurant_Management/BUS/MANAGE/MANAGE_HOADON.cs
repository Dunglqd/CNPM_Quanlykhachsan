using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class MANAGE_HOADON
    {
        private DAO.HOADON hdDao;

        public MANAGE_HOADON ()
        {
            hdDao = new DAO.HOADON ();
        }

        public DataTable getHD()
        {
            DataTable dt = hdDao.getHD();
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
