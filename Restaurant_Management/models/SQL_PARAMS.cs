using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.models
{
    internal class SQL_PARAMS
    {
        public string column;
        public string key;
        public SqlDbType dbType;
        public object value;
        public SQL_PARAMS(string column, SqlDbType dbType = SqlDbType.NText, object value = null, string key = "")
        {
            this.column = column;
            
            if (key == "") key = column;
            this.key = key;

            this.dbType = dbType;
            this.value = value;
        }
    }
}
