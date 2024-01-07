using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class PHIEUTHUEPHONG
    {
        private dbConnection conn;

        public PHIEUTHUEPHONG()
        {
            conn = new dbConnection();
        }

        public DataTable getPTP()
        {
            string sql =
                "SELECT * " +
                "FROM PHIEUTHUEPHONG " +
                "JOIN NHOM " +
                "ON PHIEUTHUEPHONG.MANHOM = NHOM.MANHOM";

            return conn.excuteReader(sql);
        }

        public DataTable searchPTP(params SQL_PARAMS[] sqlParams)
        {
            string sql =
                "SELECT * " +
                "FROM PHIEUTHUEPHONG " +
                "JOIN NHOM " +
                "ON PHIEUTHUEPHONG.MANHOM = NHOM.MANHOM";


            return conn.excuteReaderWhere(sql, sqlParams);
        }
    }
}
