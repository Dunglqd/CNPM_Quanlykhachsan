using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class HETHONG
    {
        private dbConnection conn;

        public HETHONG()
        {
            conn = new dbConnection();
        }

        public DataTable getUser(string USERNAME, string PASSWORD)
        {
            string sql =
                "SELECT * " +
                "FROM HETHONG " +
                "WHERE USERNAME = @USERNAME " +
                "AND [PASSWORD] LIKE @PASSWORD";

            SqlParameter[] sqlParameters = conn.createSqlParameters(
                new string[] { "@USERNAME", "@PASSWORD" },
                new SqlDbType[] { SqlDbType.NChar, SqlDbType.NText },
                new object[] { USERNAME, PASSWORD }
            );

            return conn.excuteReader(sql, sqlParameters);
        }

        public DataTable getHT()
        {
            string sql =
                "SELECT * " +
                "FROM HETHONG " +
                "JOIN LOAI_QUYEN " +
                "ON HETHONG.MA_QUYEN = LOAI_QUYEN.MA_QUYEN ";

            return conn.excuteReader(sql);
        }
    }
}

