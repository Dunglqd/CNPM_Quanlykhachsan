using Restaurant_Management.models;
using Restaurant_Management.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    internal class dbConnection
    {
        private SqlConnection conn;

        public dbConnection()
        {
            conn = getConnection();
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(Settings.Default.ConnStr);
        }

        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed ||
                conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }

            return conn;
        }

        private SqlCommand prepareSqlCommand(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                if (sqlParameters == null)
                {
                    sqlParameters = new SqlParameter[0];
                }

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameters);

                return sqlCommand;
            }
        }

        public void excuteNonQuery(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = prepareSqlCommand(query, sqlParameters))
            {
                sqlCommand.ExecuteNonQuery();
            }
        }

        public object excuteScalar(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = prepareSqlCommand(query, sqlParameters))
            {
                object result = sqlCommand.ExecuteScalar();
                return result;
            }
        }

        public DataTable excuteReader(string query, SqlParameter[] sqlParameters = null)
        {
            using (SqlCommand sqlCommand = prepareSqlCommand(query, sqlParameters))
            {
                DataTable dt = new DataTable();

                SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dataReader);

                return dt;
            }
        }

        public SqlParameter[] createSqlParameters(string[] vars, SqlDbType[] dbTypes, Object[] objects)
        {
            SqlParameter[] sqlParameters = new SqlParameter[vars.Length];


            for (int i = 0; i < vars.Length; i++)
            {
                sqlParameters[i] = new SqlParameter(vars[i], dbTypes[i]);
                sqlParameters[i].Value = objects[i];
            }

            return sqlParameters;
        }

        public SqlParameter[] createSqlParameters(params SQL_PARAMS[] sqlParams)
        {
            SqlParameter[] sqlParameters = new SqlParameter[sqlParams.Length];

            int i = 0;
            foreach (SQL_PARAMS sqlParam in sqlParams)
            {
                sqlParameters[i] = new SqlParameter(sqlParam.key, sqlParam.dbType);
                sqlParameters[i].Value = sqlParam.value;
                i += 1;

            }

            return sqlParameters;
        }

        public DataTable excuteReaderWhere(string sql, params SQL_PARAMS[] sqlParams)
        {
            sql += " WHERE ";

            bool addAnd = false;
            foreach(SQL_PARAMS sqlParam in sqlParams)
            {
                if (String.IsNullOrWhiteSpace(sqlParam.value.ToString()) || sqlParam.value == null)
                {
                    continue;
                }
                
                sql += sqlParam.column;

                if (sqlParam.dbType == SqlDbType.NText)
                    sql += " LIKE ";
                else
                    sql += " = ";

                sql += "@" + sqlParam.key;

                sql += " COLLATE SQL_Latin1_General_CP1_CS_AS ";


                if (addAnd)
                {
                    sql += " AND ";
                }

                addAnd = true;
            }
            
            SqlParameter[] sqlParameters = createSqlParameters(sqlParams);

            return excuteReader(sql, sqlParameters);
        }
    }
}
