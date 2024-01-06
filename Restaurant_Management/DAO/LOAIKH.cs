using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class LOAIKH
    {
        private dbConnection conn;

        public LOAIKH()
        {
            conn = new dbConnection();
        }

        public DataTable getLoaiKHByMa(string MALOAI)
        {
            string sql =
                "SELECT * " +
                "FROM LOAI_KH " +
                "WHERE MALOAI = @MALOAI";

            SqlParameter[] sqlParameters = conn.createSqlParameters(
                new string[]    { "@MALOAI" },
                new SqlDbType[] { SqlDbType.NChar },
                new object[]    { MALOAI }
            );

            return conn.excuteReader(sql, sqlParameters);
        }
    }
}
