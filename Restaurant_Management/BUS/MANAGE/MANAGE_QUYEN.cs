using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class MANAGE_QUYEN
    {
        private DAO.HETHONG htDAO;

        public MANAGE_QUYEN()
        {
            htDAO = new DAO.HETHONG();
        }

        public DataTable getHT()
        {
            DataTable dt = htDAO.getHT();
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
