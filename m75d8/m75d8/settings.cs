using System;
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
            this._settingsTabControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::m75d8.Properties.Settings.Default, "PathToSettingsXml", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._settingsTabControl.PathToSettingsXml = global::m75d8.Properties.Settings.Default.PathToSettingsXml;
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
