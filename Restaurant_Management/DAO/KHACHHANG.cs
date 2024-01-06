using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class KHACHHANG
    {
        private dbConnection conn;

        public KHACHHANG()
        {
            conn = new dbConnection();
        }

        public DataTable getKhachHang()
        {
            string sql =
                "SELECT * " +
                "FROM KHACHHANG";

            return conn.excuteReader(sql);
        }
    }
}
