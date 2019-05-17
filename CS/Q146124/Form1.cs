using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Q146124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CanCheck(GridView view, Point location)
        {
            GridHitInfo hitInfo = view.CalcHitInfo(location);
            return view.SelectedRowsCount > 1 && hitInfo.InRowCell && hitInfo.Column == colAllDay &&
                view.IsRowSelected(hitInfo.RowHandle);
        }

        private void DoCheck(GridView view)
        {
            List<int> selectedRows = new List<int>();
            bool value = false;
            for(int i = 0; i < view.RowCount; i++)
                if(view.IsRowSelected(i))
                {
                    selectedRows.Add(i);
                    if(!value) value = !(bool)view.GetRowCellValue(i, colAllDay);
                }
            foreach(int row in selectedRows) view.SetRowCellValue(row, colAllDay, value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = GetCarSchedulingDataTable();
        }
        DataTable GetCarSchedulingDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "CarScheduling";
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            table.Columns.Add(new DataColumn("CarId", typeof(string)));
            table.Columns.Add(new DataColumn("UserId", typeof(string)));
            table.Columns.Add(new DataColumn("AllDay", typeof(bool)));
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                int index = i + 1;
                table.Rows.Add(index, "Car " + random.Next(0, 100), "User " + random.Next(0, 1000), random.Next(2) == 0);
            }
            return table;
        }
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left) return;
            GridView view = (GridView)sender;
            if(!CanCheck(view, e.Location)) return;
            DoCheck(view);
            ((DXMouseEventArgs)e).Handled = true;
        }
    }
}