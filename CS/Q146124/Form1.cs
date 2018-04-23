using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace Q146124 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);

        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) return;
            GridView view = (GridView)sender;
            if (!CanCheck(view, e.Location)) return;
            DoCheck(view);
            ((DXMouseEventArgs)e).Handled = true;
        }

        private bool CanCheck(GridView view, Point location) {
            GridHitInfo hitInfo = view.CalcHitInfo(location);
            return view.SelectedRowsCount > 1 && hitInfo.InRowCell && hitInfo.Column == colAllDay &&
                view.IsRowSelected(hitInfo.RowHandle);
        }

        private void DoCheck(GridView view) {
            List<int> selectedRows = new List<int>();
            bool value = false;
            for (int i = 0; i < view.RowCount; i++)
                if (view.IsRowSelected(i)) {
                    selectedRows.Add(i);
                    if (!value) value = !(bool)view.GetRowCellValue(i, colAllDay);
                }
            foreach (int row in selectedRows) view.SetRowCellValue(row, colAllDay, value);
        }
    }
}