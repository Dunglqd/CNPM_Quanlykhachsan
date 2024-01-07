using Restaurant_Management;
using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class MANAGE_DKPT
    {
        private DAO.NH_DK_PT nh_dkptDAO;
        private DAO.DK_PHUTHU dkptDAO;

        public MANAGE_DKPT ()
        {
            nh_dkptDAO = new DAO.NH_DK_PT ();
            dkptDAO = new DAO.DK_PHUTHU ();
        }

        public DataTable getNH_DKPT()
        {
            DataTable dt = nh_dkptDAO.getNH_DKPT();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getDK_PTByNhom(string MANHOM)
        {
            DataTable dt = dkptDAO.getDK_PTByNhom(MANHOM);
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getDK_PT()
        {
            DataTable dt = dkptDAO.getDK_PT();
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
