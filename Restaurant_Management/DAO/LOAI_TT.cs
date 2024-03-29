﻿using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class LOAI_TT
    {
        private dbConnection conn;

        public LOAI_TT()
        {
            conn = new dbConnection();
        }

        public DataTable getTT()
        {
            string sql =
                "SELECT * " +
                "FROM LOAI_TT";

            return conn.excuteReader(sql);
        }

        public DataTable getTTTrong()
        {
            string sql =
                "SELECT MATT " +
                "FROM LOAI_TT " +
                "WHERE MATT NOT IN( SELECT MATT FROM PHONG )";

            return conn.excuteReader(sql);
        }

        public void deleteTT(SQL_PARAMS sqlParams)
        {
            conn.excuteDelete("LOAI_TT", sqlParams);
        }
    }
}
