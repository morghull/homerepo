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
            #region horizontal toolbar events
            _toolStripButton_Ok.Click += (s, e) =>
            {
                ((DataTable)_dataGridView_Left.DataSource).AcceptChanges();
                ((DataTable)_dataGridView_Right.DataSource).AcceptChanges();
                this.Close();
            };
            _toolStripButton_Cancel.Click += (s, e) =>
            {
                ((DataTable)_dataGridView_Left.DataSource).RejectChanges();
                ((DataTable)_dataGridView_Right.DataSource).RejectChanges();
                this.Close();
            };
            #endregion
            #region vertical toolbar buttons events
            _toolStripButton_SingleRight.Click += (s, e) =>
            {
                DataTable dtRight = (DataTable)_dataGridView_Right.DataSource;
                foreach (DataGridViewRow row in _dataGridView_Left.SelectedRows)
                {
                    DataRow dr = ((DataRowView)row.DataBoundItem).Row;
                    dtRight.Rows.Add(dr.ItemArray);
                    dr.Delete();
                }
            };
            _toolStripButton_DoubleRight.Click += (s, e) =>
            {
                DataTable dtLeft = (DataTable)_dataGridView_Left.DataSource;
                DataTable dtRight = (DataTable)_dataGridView_Right.DataSource;
                foreach (DataRow row in dtLeft.Rows)
                {
                    dtRight.Rows.Add(row.ItemArray);
                }
                dtLeft.Rows.Clear();
            };
            _toolStripButton_DoubleLeft.Click += (s, e) =>
            {
                DataTable dtLeft = (DataTable)_dataGridView_Left.DataSource;
                DataTable dtRight = (DataTable)_dataGridView_Right.DataSource;
                foreach (DataRow row in dtRight.Rows)
                {
                    dtLeft.Rows.Add(row.ItemArray);
                }
                dtRight.Rows.Clear();
            };
            _toolStripButton_SingleLeft.Click += (s, e) =>
            {
                DataTable dtLeft = (DataTable)_dataGridView_Left.DataSource;
                foreach (DataGridViewRow row in _dataGridView_Right.SelectedRows)
                {
                    DataRow dr = ((DataRowView)row.DataBoundItem).Row;
                    dtLeft.Rows.Add(dr.ItemArray);
                    dr.Delete();
                }
            };
            #endregion
        }
        public static DataTable Show(DataTable dtSource)
        {
            select sel = new select();
            var dt_right = dtSource.Clone();
            sel._dataGridView_Left.DataSource = dtSource;
            sel._dataGridView_Right.DataSource = dt_right;
            sel._dataGridView_Left.Sort(sel._dataGridView_Left.Columns[0], ListSortDirection.Ascending);
            sel._dataGridView_Right.Sort(sel._dataGridView_Right.Columns[0], ListSortDirection.Ascending);
            var maximumLengthForColumns =
                Enumerable.Range(0, dtSource.Columns.Count)
                .Select(col => dtSource.AsEnumerable()
                                     .Select(row => row[col]).OfType<string>()
                                     .Max(val => val.Length)).ToList();
            var maxColumnIndex = maximumLengthForColumns.IndexOf(maximumLengthForColumns.Max());
            sel._dataGridView_Left.Columns[(maximumLengthForColumns.Max() > 15) ? maxColumnIndex : sel._dataGridView_Left.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel._dataGridView_Right.Columns[(maximumLengthForColumns.Max() > 15) ? maxColumnIndex : sel._dataGridView_Right.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel.ShowDialog();
            return dt_right;
        }
    }
}
