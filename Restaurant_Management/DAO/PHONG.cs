using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
    }
}
