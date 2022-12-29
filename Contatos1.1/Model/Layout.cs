using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Contatos1._1.Model
{
    public class Layout
    {
        public void DataGridViewLayout(DataGridView view)
        {
            view.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view.AutoSize = true;
            view.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
