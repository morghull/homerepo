using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ISLibrary
{
    [Designer(typeof(SettingsControlDesigner))]
    public partial class SettingsTabControl : UserControl
    {
        public SettingsTabControl()
        {
            InitializeComponent();
            _btnGetPathToSettingsXml.Click += (s, e) =>
            {
                using (OpenFileDialog fd = new OpenFileDialog())
                {
                    var dirName = "";
                    if (_textBox_PathToSettingsXml.Text != String.Empty && System.IO.Directory.Exists(_textBox_PathToSettingsXml.Text))
                        dirName = _textBox_PathToSettingsXml.Text;
                    else if (_textBox_PathToSettingsXml.Text != String.Empty && System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(_textBox_PathToSettingsXml.Text)))
                        dirName = System.IO.Path.GetDirectoryName(_textBox_PathToSettingsXml.Text);
                    else dirName = "";
                    //dirName = (_textBox_PathToSettingsXml.Text != String.Empty) ? System.IO.Path.GetDirectoryName(_textBox_PathToSettingsXml.Text) : "";
                    fd.Filter = "XML-файлы|*.xml";
                    fd.Title = "Открыть файл настроек";
                    fd.InitialDirectory = (dirName != String.Empty) ? dirName : Application.StartupPath;
                    if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK) _textBox_PathToSettingsXml.Text = fd.FileName;
                }
            };
        }
        /// <summary>
        /// Surface the Caption to allow the user to 
        /// change it
        /// </summary>
        [Category("Appearance"), DefaultValue(typeof(String), "")]
        public string PathToSettingsXml
        {
            get { return this._textBox_PathToSettingsXml.Text; }

            set { this._textBox_PathToSettingsXml.Text = value; }
        }
        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel WorkingArea
        {
            get
            {
                return this._panel_LocalWorkingArea;
            }
        }
    }
    public class SettingsControlDesigner : ParentControlDesigner
    {
        public override void Initialize(System.ComponentModel.IComponent component)
        {
            base.Initialize(component);

            if (this.Control is SettingsTabControl)
            {
                this.EnableDesignMode((
                   (SettingsTabControl)this.Control).WorkingArea, "WorkingArea");
            }
        }
    }
}
