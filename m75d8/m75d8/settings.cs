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
            _textBox_Password.PasswordChar = (char)0x25CF;//'●'
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
        public static DialogResult _Show()
        {
            settings settings = new settings();
            var result = settings.ShowDialog();
            if (result == DialogResult.OK) Properties.Settings.Default.Save();
            else Properties.Settings.Default.Reload();
            return result;
        }
    }
}
