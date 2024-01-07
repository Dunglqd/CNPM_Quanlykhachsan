using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    internal class NHANVIEN
    {
        private dbConnection conn;

        public NHANVIEN()
        {
            conn = new dbConnection();
        }

        public DataTable getNV()
        {
            string sql =
                "SELECT * " +
                "FROM NHANVIEN " +
                "JOIN LOAI_NV " +
                "ON NHANVIEN.MALOAINV = LOAI_NV.MALOAINV " +
                "JOIN HETHONG " +
                "ON NHANVIEN.MANV = HETHONG.MANV " +
                "JOIN LOAI_QUYEN " +
                "ON HETHONG.MA_QUYEN = LOAI_QUYEN.MA_QUYEN";

            return conn.excuteReader(sql);
        }

        public DataTable searchNV(params SQL_PARAMS[] sqlParams)
        {
            string sql =
               "SELECT *" +
               "FROM NHANVIEN " +
               "JOIN LOAI_NV " +
               "ON NHANVIEN.MALOAINV = LOAI_NV.MALOAINV " +
               "JOIN HETHONG " +
               "ON NHANVIEN.MANV = HETHONG.MANV " +
               "JOIN LOAI_QUYEN " +
               "ON HETHONG.MA_QUYEN = LOAI_QUYEN.MA_QUYEN";

            return conn.excuteReaderWhere(
                sql,
                sqlParams
            );
        }
    }
}
