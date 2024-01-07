using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class NH_DK_PT
    {
        private dbConnection conn;

        public NH_DK_PT()
        {
            conn = new dbConnection();
        }

        public DataTable getNH_DKPT()
        {
            string sql =
                "SELECT * " +
                "FROM NH_DK_PT " + 
                "WHERE MANH_DK_PT != 'NH_DK1'";

            return conn.excuteReader(sql);
        }
    }
}
