using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.DAO
{
    internal class DK_PHUTHU
    {
        private dbConnection conn;

        public DK_PHUTHU()
        {
            conn = new dbConnection();
        }

        public DataTable getDK_PTByNhom(string MANHOM)
        {
            string sql =
                "SELECT * " +
                "FROM DK_PHUTHU " +
                "WHERE MANH_DK_PT = @MANHOM";

            SqlParameter[] sqlParameters = conn.createSqlParameters(
                new string[] { "@MANHOM" },
                new SqlDbType[] { SqlDbType.NChar },
                new object[] { MANHOM }
            );

            return conn.excuteReader(sql, sqlParameters);
        }
    }
}
