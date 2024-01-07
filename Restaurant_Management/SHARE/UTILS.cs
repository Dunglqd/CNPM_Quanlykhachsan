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
        public static bool selectRow(DataGridViewCellEventArgs e, ref DataGridView dtv, ref DataGridViewRow currentRow, bool isReturn = false)
        {
            if (isReturn) { return false; }

            if (currentRow != null)
            { 
                currentRow.Cells["Chọn"].Value = false;
                currentRow.Selected = false;

                if (currentRow == dtv.Rows[e.RowIndex])
                {
                    currentRow = null;
                    
                    return false;
                }
            }

            dtv["Chọn", e.RowIndex].Value = true;
            currentRow = dtv.Rows[e.RowIndex];
            currentRow.Selected = true;

            return true;
        }

        public static void selectMultiRow(ref DataGridView dtv, ref List<DataGridViewRow> currentRows, DataTable dt = null, string key = "")
        {
            if (dt == null) return;

            currentRows.Clear();
            deselectTable(ref dtv);

            List<string> values = dt.AsEnumerable()
                .Select(x => x[key].ToString()).ToList();

            foreach (DataGridViewRow currentRow in dtv.Rows)
            {
                if (!values.Contains(currentRow.Cells[key].Value.ToString())) continue;
                
                currentRow.Cells["Chọn"].Value = true;
                currentRow.Selected = true;

                currentRows.Add(currentRow);
            }
        }

        public static bool selectMultiRow(DataGridViewCellEventArgs e, ref DataGridView dtv, ref List<DataGridViewRow> currentRows, bool isReturn = false)
        {
            if (isReturn) { return false; }

            DataGridViewRow currentRow = dtv.Rows[e.RowIndex];

            if (currentRows.Contains(currentRow))
            {
                currentRow.Cells["Chọn"].Value = false;
                currentRow.Selected = false;

                currentRows.Remove(currentRow);
                return false;
            }

            currentRow.Cells["Chọn"].Value = true;
            currentRow.Selected = true;

            currentRows.Add(currentRow);

            return true;
        }

        public static void deselectRow(ref DataGridView dtv, ref DataGridViewRow currentRow)
        {
            dtv.ClearSelection();

            if (currentRow == null) return;
            
            currentRow.Cells["Chọn"].Value = false;
            currentRow = null;
        }

        public static void deselectTable(ref DataGridView dtv)
        {
            dtv.ClearSelection();

            foreach(DataGridViewRow row in dtv.Rows)
            {
                row.Cells["Chọn"].Value = false;
            }
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

            foreach (string col in columns)
            {
                dtv.Columns[col].Visible = true;
            }
        }

        public static void hideColmn(ref DataGridView dtv, string[] columns = null)
        {
            if (dtv.Columns.Contains("Chọn"))
            {
                dtv.Columns["Chọn"].Visible = true;
            }

            if (columns == null) { return; }

            foreach (DataGridViewColumn col in dtv.Columns)
            {
                if (col.Name == "Chọn") continue;

                col.Visible = true;
            }

            foreach (string col in columns)
            {
                dtv.Columns[col].Visible = false;
            }
        }

        public static bool clickHeader(DataGridViewCellEventArgs e)
        {
            return e.RowIndex == -1;
        }

        public static bool notString(string text)
        {
            return String.IsNullOrWhiteSpace(text);
        }
    }
}
