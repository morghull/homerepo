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
            _toolStripButton_Exit.Click += (s, e) =>
            {
                if (ISLibrary.msg.Show("Желаете завершить работу с программой?", ISLibrary.msg.DialogButtons.YesNo, ISLibrary.msg.DialogImage.Question) == DialogResult.Yes) Application.Exit();
            };
            _toolStripButton_Ok.Click += (s, e) =>
            {
                ISLibrary.msg.Show("Ошибка при работе с SQL-сервером!", "Ошибка", ISLibrary.msg.DialogButtons.Ok, ISLibrary.msg.DialogImage.Error);
            };
            _radioButton_NcInclude.Click += (s, e) =>
            {
                var dt = DatabaseManager.doQuery(new Npgsql.NpgsqlCommand("select nceh,nc,kd from vd.tabceh order by nceh;"));
                var result = ISLibrary.select.Show(dt);
                if (result.Rows.Count == 0) _radioButton_NcAll.Checked = true;
            };
        }
    }
}
