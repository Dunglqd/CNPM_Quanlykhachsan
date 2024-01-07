using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        
        public DataTable getLPTrong()
        {
            string sql =
                "SELECT MALOAI " +
                "FROM LOAIPHONG " +
                "WHERE MALOAI NOT IN( SELECT MALOAI FROM PHONG )";

            return conn.excuteReader(sql);
        }

        public void deleteLP(SQL_PARAMS sqlParams)
        {
            conn.excuteDelete("LOAIPHONG", sqlParams);
        }
    }
}
