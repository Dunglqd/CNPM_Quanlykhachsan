using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class LOAIPHONG
    {
        private dbConnection conn;

        public LOAIPHONG()
        {
            conn = new dbConnection();
        }

        public DataTable getLP()
        {
            string sql =
                "SELECT * " +
                "FROM LOAIPHONG";

            return conn.excuteReader(sql);
        }
    }
}
