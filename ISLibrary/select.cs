using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISLibrary
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
            _dataGridView_Left.DoubleBuffered(true);
            _dataGridView_Right.DoubleBuffered(true);
            _toolStripButton_Cancel.Click += (s, e) =>
            {
                ((DataTable)_dataGridView_Right.DataSource).RejectChanges();
                this.Close();
            };
            _toolStripButton_SingleRight.Click += (s, e) =>
            {
                DataTable dtRight = (DataTable)_dataGridView_Right.DataSource;
                DataTable dtLeft = (DataTable)_dataGridView_Left.DataSource;
                foreach (DataGridViewRow row in _dataGridView_Left.SelectedRows)
                {
                    dtRight.ImportRow(((DataRowView)row.DataBoundItem).Row);
                    dtRight.Rows[dtRight.Rows.Count - 1].SetAdded();
                    ((DataRowView)row.DataBoundItem).Row.Delete();
                }
                //dtRight.AcceptChanges();
                //dtLeft.AcceptChanges();
            };
        }
        public static DataTable Show(DataTable dtSource)
        {
            select sel = new select();
            var dt_right = dtSource.Clone();
            sel._dataGridView_Left.DataSource = dtSource;
            sel._dataGridView_Right.DataSource = dt_right;
            //sel._dataGridView_Left.Sort(sel._dataGridView_Left.Columns[0], ListSortDirection.Ascending);
            //sel._dataGridView_Right.Sort(sel._dataGridView_Right.Columns[0], ListSortDirection.Ascending);
            var maximumLengthForColumns =
                Enumerable.Range(0, dtSource.Columns.Count)
                .Select(col => dtSource.AsEnumerable()
                                     .Select(row => row[col]).OfType<string>()
                                     .Max(val => val.Length)).ToList();
            var maxColumnIndex = maximumLengthForColumns.IndexOf(maximumLengthForColumns.Max());
            //sel._dataGridView_Left.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel._dataGridView_Left.Columns[maxColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel._dataGridView_Right.Columns[maxColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel.ShowDialog();
            return dt_right;
        }
    }
}
