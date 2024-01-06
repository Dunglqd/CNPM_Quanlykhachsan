using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class LOGIN
    {
        private DAO.HETHONG userDAO;

        public LOGIN()
        {
            userDAO = new DAO.HETHONG();
        }

        public DataTable getUser(string USERNAME, string PASSWORD)
        {
            return userDAO.getUser(USERNAME, PASSWORD);
        }
    }
}
