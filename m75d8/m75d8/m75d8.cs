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
            var directoryToSearchIn = "d:\\rasch";//to start seaching in this directory
            Dictionary<string, string> filePathes = new Dictionary<string, string>();

            foreach (var item in new List<string>() { "mm75030.dbf", "mm75040.dbf" })
            {
                filePathes.Add(item, System.IO.Directory.Exists(directoryToSearchIn) ? System.IO.Directory.GetFiles(directoryToSearchIn, item, System.IO.SearchOption.AllDirectories).FirstOrDefault() : null);
            }
            _textBox_mm75030Path.Text = filePathes["mm75030.dbf"] ?? _textBox_mm75030Path.Text;
            _textBox_mm75040Path.Text = filePathes["mm75040.dbf"] ?? _textBox_mm75040Path.Text;
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
            #region Click handlers for buttons with OpenFileDialog
            var list = new[]
            {
                new { fileName = "mm75030.dbf", button = _btnGetPathTo_mm75030 },
                new { fileName = "mm75040.dbf", button = _btnGetPathTo_mm75040 }
            };
            foreach (var obj in list)
            {
                obj.button.Click += (s, e) =>
                {
                    var initialDirectoryForFileDialog = "";
                    //if we found more then one file and picked wrong one
                    if (filePathes[obj.fileName] != null) initialDirectoryForFileDialog = System.IO.Path.GetDirectoryName(filePathes[obj.fileName]);
                    //if we didn't found any
                    else if (System.IO.Directory.Exists(directoryToSearchIn)) initialDirectoryForFileDialog = directoryToSearchIn;
                    //if we have wrong start directory to search in
                    else initialDirectoryForFileDialog = Application.StartupPath;
                    OpenFileDialog fd = new OpenFileDialog()
                    {
                        Filter = System.IO.Path.GetFileNameWithoutExtension(obj.fileName) + "|" + obj.fileName,
                        InitialDirectory = initialDirectoryForFileDialog
                    };
                    var result = fd.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK) _textBox_mm75030Path.Text = fd.FileName;
                };
            }
            #endregion
        }
    }
}
