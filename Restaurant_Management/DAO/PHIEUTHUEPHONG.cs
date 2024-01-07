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
                "FROM HOADON";

            return conn.excuteReader(sql);
        }
    }
}
