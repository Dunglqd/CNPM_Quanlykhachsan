using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class NHOM
    {
        private dbConnection conn;

        public NHOM()
        {
            conn = new dbConnection();
        }

        public DataTable getNhomTrong()
        {
            string sql =
                "SELECT * " +
                "FROM NHOM " +
                "WHERE MANHOM " +
                "NOT IN ( " +
                    "SELECT MANHOM " +
                    "FROM PHIEUTHUEPHONG " +
                ") AND MANHOM != 'NH1'";


            return conn.excuteReader(sql);
        }

        public DataTable getTyleByMa(string MANHOM)
        {
            string sql =
                "SELECT * " +
                "FROM NHOM " +
                "WHERE MANHOM = @MANHOM";

            SqlParameter[] sqlParameters = conn.createSqlParameters(
                new string[] { "@MANHOM" },
                new SqlDbType[] { SqlDbType.NChar },
                new object[] { MANHOM }
            ); ;

            return conn.excuteReader(sql, sqlParameters);
        }
    }
}
