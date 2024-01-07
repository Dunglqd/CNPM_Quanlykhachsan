using Restaurant_Management.models;
using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class SEARCH_PHIEUTHUEPHONG
    {
        private DAO.PHIEUTHUEPHONG ptpDAO;

        public SEARCH_PHIEUTHUEPHONG()
        {
            ptpDAO = new DAO.PHIEUTHUEPHONG();
        }

        public DataTable searchPTP(params SQL_PARAMS[] sqlParams)
        {
            DataTable dt = ptpDAO.searchPTP(sqlParams);
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getPTP()
        {
            DataTable dt = ptpDAO.getPTP();
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
