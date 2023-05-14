using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class CommonMethods
    {
        public static List<DataGridViewTextBoxColumn> GetTable()
        {
            var result = new List<DataGridViewTextBoxColumn>();
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            columnId.Name = "Id";
            columnId.HeaderText = "Id";
            result.Add(columnId);

            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            columnName.Name = "Name";
            columnName.HeaderText = "Name";
            result.Add(columnName);

            DataGridViewTextBoxColumn columnLengthMy = new DataGridViewTextBoxColumn();
            columnLengthMy.Name = "LengthMy";
            columnLengthMy.HeaderText = "LengthMy";
            result.Add(columnLengthMy);

            DataGridViewTextBoxColumn columnWidthMy = new DataGridViewTextBoxColumn();
            columnWidthMy.Name = "WidthMy";
            columnWidthMy.HeaderText = "WidthMy";
            result.Add(columnWidthMy);

            DataGridViewTextBoxColumn columnHeightMy = new DataGridViewTextBoxColumn();
            columnHeightMy.Name = "HeightMy";
            columnHeightMy.HeaderText = "HeightMy";
            result.Add(columnHeightMy);

            DataGridViewTextBoxColumn columnStatusMy = new DataGridViewTextBoxColumn();
            columnStatusMy.Name = "StatusMy";
            columnStatusMy.HeaderText = "StatusMy";
            result.Add(columnStatusMy);

            return result;
        }
    }
}
