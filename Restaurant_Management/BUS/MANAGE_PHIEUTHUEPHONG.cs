using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class MANAGE_PHIEUTHUEPHONG
    {
        private DAO.PHIEUTHUEPHONG ptpDAO;
        private DAO.NHOM nhDAO;

        public MANAGE_PHIEUTHUEPHONG ()
        {
            ptpDAO = new DAO.PHIEUTHUEPHONG();
            nhDAO = new DAO.NHOM();
        }

        public DataTable getPTP()
        {
            DataTable dt = ptpDAO.getPTP();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public float getgetTyleByMaNH(string MANHOM) 
        {
            DataTable dt = nhDAO.getTyleByMa(MANHOM);

            return float.Parse(dt.Rows[0]["TYLE"].ToString());
        }
    }
}
