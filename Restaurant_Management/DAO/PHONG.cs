using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Restaurant_Management.models;

namespace Restaurant_Management.DAO
{
    internal class PHONG
    {
        private dbConnection conn;

        public PHONG()
        {
            conn = new dbConnection();
        }

        public DataTable getPhongTrong()
        {
            string sql =
                "SELECT *" +
                "FROM PHONG " +
                "JOIN LOAI_TT " +
                "ON PHONG.MATT = LOAI_TT.MATT " +
                "JOIN LOAIPHONG " +
                "ON PHONG.MALOAI = LOAIPHONG.MALOAI " +
                "WHERE PHONG.MATT != 'TT3' ";

            return conn.excuteReader(sql);
        }

        public DataTable getPHONG_ALL()
        {
            string sql =
                "SELECT MAPHONG, PHONG.MALOAI, TENLOAI, PHONG.MATT, TEN_TT, GHICHU " +
                "FROM PHONG " +
                "JOIN LOAI_TT " +
                "ON PHONG.MATT = LOAI_TT.MATT " +
                "JOIN LOAIPHONG " +
                "ON PHONG.MALOAI = LOAIPHONG.MALOAI ";

            return conn.excuteReader(sql);
        }

        public void deletePH(string MAPHONG)
        {
            string sql =
                "DELETE FROM PHONG WHERE MAPHONG = @MAPHONG";

            SqlParameter[] sqlParameters = conn.createSqlParameters(
                "MAPHONG".pair(SqlDbType.NChar, MAPHONG)
            );

            conn.excuteNonQuery(sql, sqlParameters);
        }

        public void insertPH(params SQL_PARAMS[] sqlParams)
        {
            conn.excuteInsert("PHONG", sqlParams);
        }
    }
}
