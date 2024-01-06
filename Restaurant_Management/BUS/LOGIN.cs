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
        private DAO.USER userDAO;

        public LOGIN()
        {
            userDAO = new DAO.USER();
        }

        public DataTable getUser(string USERNAME, string PASSWORD)
        {
            return userDAO.getUser(USERNAME, PASSWORD);
        }
    }
}
