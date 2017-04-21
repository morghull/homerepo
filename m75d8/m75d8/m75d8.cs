using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace m75d8
{
    public partial class m75d8 : Form
    {
        public m75d8()
        {
            InitializeComponent();
            toolStripButton_exit.Click += (s, e) => { MessageBox.Show("Завершить работу с программой?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question); };
        }
    }
}
