using Restaurant_Management.models;
using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class MANAGE_ROOM
    {
        private DAO.PHONG phDAO;
        private DAO.LOAI_TT ttDAO;
        private DAO.LOAIPHONG lpDAO;

        public MANAGE_ROOM()
        {
            phDAO = new DAO.PHONG();
            ttDAO = new DAO.LOAI_TT();
            lpDAO = new DAO.LOAIPHONG();
        }

        public DataTable getPHONG_ALL()
        {
            DataTable dt = phDAO.getPHONG_ALL();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getTT()
        {
            DataTable dt = ttDAO.getTT();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable getLP()
        {
            DataTable dt = lpDAO.getLP();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public void deletePH(string MAPHONG)
        {
            phDAO.deletePH(MAPHONG);
        }

        public void insertPH(params SQL_PARAMS[] sqlParams)
        {
            phDAO.insertPH(sqlParams);
        }

        public List<string> getLPTrong()
        {
            DataTable dt = lpDAO.getLPTrong();

            return dt.AsEnumerable().Select(r => r.Field<string>("MALOAI")).ToList();
        }

        public void deleteLP(SQL_PARAMS sqlParam)
        {
            lpDAO.deleteLP(sqlParam);
        }

        public List<string> getLTTrong()
        {
            DataTable dt = ttDAO.getTTTrong();

            return dt.AsEnumerable().Select(r => r.Field<string>("MATT")).ToList();
        }

        public void deleteTT(SQL_PARAMS sqlParam)
        {
            lpDAO.deleteLP(sqlParam);
        }
    }
}
