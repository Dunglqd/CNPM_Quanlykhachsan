using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;
using Restaurant_Management.models;
static class Pairing
{
    public static SQL_PARAMS pair(this string column, SqlDbType dbType, object value, string key = "")
    {
        return new SQL_PARAMS(column, dbType, value, key);
    }
}


namespace Restaurant_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MANAGE_NHANVIEN());
        }
    }
}
