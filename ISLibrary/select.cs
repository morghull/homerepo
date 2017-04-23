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
            sel._dataGridView_Left.DataSource = dtSource;
            var dt_right = dtSource.Clone();
            sel._dataGridView_Right.DataSource = dt_right;
            sel.ShowDialog();
            return dt_right;
        }
    }
}
