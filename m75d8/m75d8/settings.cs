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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            this._textBox_DirToSearchIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::m75d8.Properties.Settings.Default, "DirectoryToSearchIn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBox_DirToSearchIn.Text = global::m75d8.Properties.Settings.Default.DirectoryToSearchIn;
            this._textBox_PathToSettingsXml.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::m75d8.Properties.Settings.Default, "PathToSettingsXml", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._textBox_PathToSettingsXml.Text = global::m75d8.Properties.Settings.Default.PathToSettingsXml;
            #region buttons event handlers
            _toolStripButton_Ok.Click += (s, e) =>
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            };
            _toolStripButton_Cancel.Click += (s, e) =>
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            };
            _btnGetDirToSearchIn.Click += (s, e) =>
            {
                FolderBrowserDialog fd = new FolderBrowserDialog()
                {
                    RootFolder = Environment.SpecialFolder.MyComputer,
                    ShowNewFolderButton = false
                };
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK) _textBox_DirToSearchIn.Text = fd.SelectedPath.ToLower();
            };
            _btnGetPathToSettingsXml.Click += (s, e) =>
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    var dirName = (_textBox_PathToSettingsXml.Text != String.Empty) ? System.IO.Path.GetDirectoryName(_textBox_PathToSettingsXml.Text) : "";
                    fd.Filter = "XML-файлы|*.xml";
                    fd.Title = "Открыть файл настроек";
                    fd.InitialDirectory = (dirName != String.Empty && System.IO.Directory.Exists(dirName)) ? dirName : Application.StartupPath;
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK) _textBox_PathToSettingsXml.Text = fd.FileName;
                }
            };
            #endregion
        }
        public static DialogResult CreateNewAnShow()
        {
            settings settings = new settings();
            var result = settings.ShowDialog();
            if (result == DialogResult.OK) Properties.Settings.Default.Save();
            else Properties.Settings.Default.Reload();
            return result;
        }
    }
}
