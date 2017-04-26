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
            _toolStripButton_Cancel.Click += (s, e) => 
            {
                this.Close();
            };
        }
        public static DataTable Show(DataTable dtSource)
        {
            select sel = new select();
            var dt_right = dtSource.Clone();
            sel._dataGridView_Left.DataSource = dtSource;
            sel._dataGridView_Right.DataSource = dt_right;
            var maximumLengthForColumns =
                Enumerable.Range(0, dtSource.Columns.Count)
                .Select(col => dtSource.AsEnumerable()
                                     .Select(row => row[col]).OfType<string>()
                                     .Max(val => val.Length )).ToList();
            var maxColumnIndex = maximumLengthForColumns.IndexOf(maximumLengthForColumns.Max());
            //sel._dataGridView_Left.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel._dataGridView_Left.Columns[maxColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel._dataGridView_Right.Columns[maxColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sel.ShowDialog();
            return dt_right;
        }
    }
}
