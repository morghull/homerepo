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
            Dictionary<string, string> filePathes = new Dictionary<string,string>();
            string filePath_mm75030 = null, filePath_mm75040 = null;

            if (System.IO.Directory.Exists(directoryToSearchIn))
            {
                filePath_mm75030 = System.IO.Directory.GetFiles(directoryToSearchIn, "mm75030.dbf", System.IO.SearchOption.AllDirectories).FirstOrDefault();
                filePath_mm75040 = System.IO.Directory.GetFiles(directoryToSearchIn, "mm75040.dbf", System.IO.SearchOption.AllDirectories).FirstOrDefault();
            }
            _textBox_mm75030Path.Text = filePath_mm75030 ?? _textBox_mm75030Path.Text;
            _textBox_mm75040Path.Text = filePath_mm75040 ?? _textBox_mm75040Path.Text;

            foreach (var item in new List<string>() { "mm75030.dbf", "mm75040.dbf" })
            {

            }

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
                    var initialDirectoryForFileDialog = "";
                    //if we found more then one file and picked wrong one
                    if (filePath_mm75030 != null) initialDirectoryForFileDialog = System.IO.Path.GetDirectoryName(filePath_mm75030);
                    //if we didn't found any
                    else if (System.IO.Directory.Exists(directoryToSearchIn)) initialDirectoryForFileDialog = directoryToSearchIn;
                    //if we have wrong start directory to search in
                    else initialDirectoryForFileDialog = Application.StartupPath;
                    OpenFileDialog fd = new OpenFileDialog()
                    {
                        Filter = "mm75030|mm75030.dbf",
                        InitialDirectory = initialDirectoryForFileDialog
                    };
                    var result = fd.ShowDialog();
                    if (result == System.Windows.Forms.DialogResult.OK) _textBox_mm75030Path.Text = fd.FileName;
                };
            #endregion
            #region _btnGetPathTo_mm75040 Click
            _btnGetPathTo_mm75040.Click += (s, e) =>
            {
                var initialDirectoryForFileDialog = "";
                //if we found more then one file and picked wrong one
                if (filePath_mm75040 != null) initialDirectoryForFileDialog = System.IO.Path.GetDirectoryName(filePath_mm75040);
                //if we didn't found any
                else if (System.IO.Directory.Exists(directoryToSearchIn)) initialDirectoryForFileDialog = directoryToSearchIn;
                //if we have wrong start directory to search in
                else initialDirectoryForFileDialog = Application.StartupPath;
                OpenFileDialog fd = new OpenFileDialog()
                {
                    Filter = "mm75040|mm75040.dbf",
                    InitialDirectory = initialDirectoryForFileDialog
                };
                var result = fd.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK) _textBox_mm75040Path.Text = fd.FileName;
            };
            #endregion
        }
    }
}
