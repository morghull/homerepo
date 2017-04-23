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
            toolStripButton_exit.Click += (s, e) =>
            {
                if (ISLibrary.msg.Show("Желаете завершить работу с программой?", ISLibrary.msg.DialogButtons.YesNo, ISLibrary.msg.DialogImage.Question) == DialogResult.Yes) Application.Exit();
            };
            toolStripButton_ok.Click += (s, e) =>
            {
                ISLibrary.msg.Show("Ошибка при работе с SQL-сервером!", "Ошибка", ISLibrary.msg.DialogButtons.Ok, ISLibrary.msg.DialogImage.Error);
            };
        }
    }
}
