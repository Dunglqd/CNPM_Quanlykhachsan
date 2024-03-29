﻿using Restaurant_Management.models;
using Restaurant_Management.SHARE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.BUS
{
    internal class SEARCH_NHANVIEN
    {
        private DAO.NHANVIEN nvDAO;

        public SEARCH_NHANVIEN()
        {
            nvDAO = new DAO.NHANVIEN();
        }

        public DataTable getNV()
        {
            DataTable dt = nvDAO.getNV();
            UTILS.addBtnCol(ref dt);

            return dt;
        }

        public DataTable searchNV(params SQL_PARAMS[] sqlParams)
        {
            DataTable dt = nvDAO.searchNV(sqlParams);
            UTILS.addBtnCol(ref dt);

            return dt;
        }
    }
}
