﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace m75d8
{
    public partial class m75d8 : Form
    {
        private DataSet ds = new DataSet();
        public m75d8()
        {
            InitializeComponent();
            _toolStripButton_Test.Click += (s,e) => {
                //ISLibrary.GlobalSettings gs = ISLibrary.GlobalSettings.CreateWithDefaults();
                //gs.WriteToXml(@"d:\global.xml");
                //testForm tf = new testForm();
                //tf.ShowDialog();
            };
            var directoryToSearchIn = Properties.Settings.Default["DirectoryToSearchIn"].ToString();//to start seaching in this directory
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
            #region _toolStripButton_Settings Click
            _toolStripButton_Settings.Click += (s, e) =>
            {
                settings.CreateNewAnShow();
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
                if (!ds.Tables.Contains("dtNceh_left"))
                {
                    var dt = DatabaseManager.doQuery(new Npgsql.NpgsqlCommand("select nceh,nc,kd from vd.tabceh order by nceh;"));
                    dt.TableName = "dtNceh_left";
                    ds.Tables.Add(dt);
                }
                if (!ds.Tables.Contains("dtNceh_right"))
                {
                    var dt = ds.Tables["dtNceh_left"].Clone();
                    dt.TableName = "dtNceh_right";
                    ds.Tables.Add(dt);
                }
                var result = ISLibrary.select.Show(ds.Tables["dtNceh_left"], ds.Tables["dtNceh_right"]);
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
                    using (OpenFileDialog fd = new OpenFileDialog())
                    {
                        fd.Filter = System.IO.Path.GetFileNameWithoutExtension(obj.fileName) + "|" + obj.fileName;
                        fd.InitialDirectory = initialDirectoryForFileDialog;
                        fd.Title = "Открыть " + obj.fileName;
                        if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK) _textBox_mm75030Path.Text = fd.FileName;
                    };
                };
            }
            #endregion
        }
    }
}
