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
    internal class MANAGE_NHANVIEN
    {
        private DAO.NHANVIEN nvDAO;

        public MANAGE_NHANVIEN()
        {
            nvDAO = new DAO.NHANVIEN();
        }

        public DataTable getNV()
        {
            DataTable dt = nvDAO.getNV();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable searchNV(params SQL_PARAMS[] sqlParmas)
        {
            DataTable dt = nvDAO.searchNV(sqlParmas);
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
