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
            var directoryToSearchIn = "d:\\rasch";
            if (System.IO.Directory.Exists(directoryToSearchIn))
                _textBox_mm75030Path.Text = System.IO.Directory.GetFiles(directoryToSearchIn, "mm75030.dbf", System.IO.SearchOption.AllDirectories).FirstOrDefault() ?? _textBox_mm75030Path.Text;
            if (System.IO.Directory.Exists(directoryToSearchIn))
                _textBox_mm75040Path.Text = System.IO.Directory.GetFiles(directoryToSearchIn, "mm75040.dbf", System.IO.SearchOption.AllDirectories).FirstOrDefault() ?? _textBox_mm75040Path.Text;

            #region _toolStripButton_Exit Click
            _toolStripButton_Exit.Click += (s, e) =>
                {
                    if (ISLibrary.msg.Show("Желаете завершить работу с программой?", ISLibrary.msg.DialogButtons.YesNo, ISLibrary.msg.DialogImage.Question) == DialogResult.Yes) Application.Exit();
                };
            #endregion
            #region _toolStripButton_Ok Click
            _toolStripButton_Ok.Click += (s, e) =>
                {
                    ISLibrary.msg.Show("Ошибка при работе с SQL-сервером!", "Ошибка", ISLibrary.msg.DialogButtons.Ok, ISLibrary.msg.DialogImage.Error);
                };
            #endregion
            #region _radioButton_NcInclude Click
            _radioButton_NcInclude.Click += (s, e) =>
                {
                    var dt = DatabaseManager.doQuery(new Npgsql.NpgsqlCommand("select nceh,nc,kd from vd.tabceh order by nceh;"));
                    var result = ISLibrary.select.Show(dt);
                    if (result.Rows.Count == 0) _radioButton_NcAll.Checked = true;
                };
            #endregion
            #region _btnGetPathTo_mm75030 Click
            _btnGetPathTo_mm75030.Click += (s, e) =>
                {
                    OpenFileDialog fd = new OpenFileDialog();
                    fd.Filter = "mm75030|mm75030.dbf";
                    fd.InitialDirectory = (System.IO.Directory.Exists(directoryToSearchIn)) ? directoryToSearchIn : Application.StartupPath;
                    var result = fd.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK) _textBox_mm75030Path.Text = fd.FileName;
                };
            #endregion
        }
    }
}
