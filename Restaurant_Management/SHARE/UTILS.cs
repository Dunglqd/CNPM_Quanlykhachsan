using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.SHARE
{
    class UTILS
    {
        public static bool SelectRow(DataGridViewCellEventArgs e, ref DataGridView dtv, ref DataGridViewRow currentRow, bool isReturn = false)
        {
            if (isReturn) { return false; }

            if (currentRow != null)
            { 
                currentRow.Cells["Chọn"].Value = false;

                if (currentRow == dtv.Rows[e.RowIndex])
                {
                    currentRow = null;
                    
                    return false;
                }
            }

            dtv["Chọn", e.RowIndex].Value = true;
            currentRow = dtv.Rows[e.RowIndex];
            
            return true;
        }

        public static void DeselectCell(ref DataGridView dtv, ref DataGridViewRow currentRow)
        {
            dtv.ClearSelection();

            if (currentRow == null) return;
            
            currentRow.Cells["Chọn"].Value = false;
            currentRow = null;
        }

        public static void addBtnCol(ref DataTable dt)
        {
            dt.Columns.Add(new DataColumn("Chọn", typeof(bool)));
        }

        public static void showColumn(ref DataGridView dtv, string[] columns = null) 
        {
            if (dtv.Columns.Contains("Chọn"))
            {
                dtv.Columns["Chọn"].Visible = true;
            }

            if (columns == null) { return; }

            foreach (DataGridViewColumn col in dtv.Columns)
            {
                if (col.Name == "Chọn") continue;
                
                col.Visible = false;
            }

            Console.WriteLine(columns);

            foreach (string col in columns)
            {
                dtv.Columns[col].Visible = true;
            }
        }

        public static bool clickHeader(DataGridViewCellEventArgs e)
        {
            return e.RowIndex == -1;
        }
    }
}
