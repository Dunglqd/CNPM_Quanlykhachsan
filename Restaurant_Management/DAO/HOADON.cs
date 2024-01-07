using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class HOADON
    {
        private dbConnection conn;
        public HOADON() 
        { 
            conn = new dbConnection();
        }

        public DataTable getHD()
        {
            string sql =
                "SELECT * " +
                "FROM HOADON";

            return conn.excuteReader(sql);
        }
    }
}
