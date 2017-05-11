namespace ISLibrary
{
    partial class SettingsTabControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tabControl_Settings = new System.Windows.Forms.TabControl();
            this._tabPage_Local = new System.Windows.Forms.TabPage();
            this._tableLayoutPanel_LocalContent = new System.Windows.Forms.TableLayoutPanel();
            this._panel_LocalProtectedArea = new System.Windows.Forms.Panel();
            this._btnGetPathToSettingsXml = new System.Windows.Forms.Button();
            this._textBox_PathToSettingsXml = new System.Windows.Forms.TextBox();
            this._lblPathToSettingsXml = new System.Windows.Forms.Label();
            this._tabPage_Global = new System.Windows.Forms.TabPage();
            this._panel_LocalWorkingArea = new ISLibrary.SettingsWorkingAreaControl();
            this._tabControl_Settings.SuspendLayout();
            this._tabPage_Local.SuspendLayout();
            this._tableLayoutPanel_LocalContent.SuspendLayout();
            this._panel_LocalProtectedArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControl_Settings
            // 
            this._tabControl_Settings.Controls.Add(this._tabPage_Local);
            this._tabControl_Settings.Controls.Add(this._tabPage_Global);
            this._tabControl_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl_Settings.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabControl_Settings.Location = new System.Drawing.Point(0, 0);
            this._tabControl_Settings.Name = "_tabControl_Settings";
            this._tabControl_Settings.SelectedIndex = 0;
            this._tabControl_Settings.Size = new System.Drawing.Size(618, 330);
            this._tabControl_Settings.TabIndex = 0;
            // 
            // _tabPage_Local
            // 
            this._tabPage_Local.Controls.Add(this._tableLayoutPanel_LocalContent);
            this._tabPage_Local.Location = new System.Drawing.Point(4, 25);
            this._tabPage_Local.Name = "_tabPage_Local";
            this._tabPage_Local.Size = new System.Drawing.Size(610, 301);
            this._tabPage_Local.TabIndex = 0;
            this._tabPage_Local.Text = "Локальные";
            this._tabPage_Local.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel_LocalContent
            // 
            this._tableLayoutPanel_LocalContent.ColumnCount = 1;
            this._tableLayoutPanel_LocalContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel_LocalContent.Controls.Add(this._panel_LocalProtectedArea, 0, 0);
            this._tableLayoutPanel_LocalContent.Controls.Add(this._panel_LocalWorkingArea, 0, 1);
            this._tableLayoutPanel_LocalContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel_LocalContent.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel_LocalContent.Name = "_tableLayoutPanel_LocalContent";
            this._tableLayoutPanel_LocalContent.RowCount = 2;
            this._tableLayoutPanel_LocalContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._tableLayoutPanel_LocalContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel_LocalContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel_LocalContent.Size = new System.Drawing.Size(610, 301);
            this._tableLayoutPanel_LocalContent.TabIndex = 2;
            // 
            // _panel_LocalProtectedArea
            // 
            this._panel_LocalProtectedArea.Controls.Add(this._btnGetPathToSettingsXml);
            this._panel_LocalProtectedArea.Controls.Add(this._textBox_PathToSettingsXml);
            this._panel_LocalProtectedArea.Controls.Add(this._lblPathToSettingsXml);
            this._panel_LocalProtectedArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel_LocalProtectedArea.Location = new System.Drawing.Point(0, 0);
            this._panel_LocalProtectedArea.Margin = new System.Windows.Forms.Padding(0);
            this._panel_LocalProtectedArea.Name = "_panel_LocalProtectedArea";
            this._panel_LocalProtectedArea.Size = new System.Drawing.Size(610, 30);
            this._panel_LocalProtectedArea.TabIndex = 1;
            // 
            // _btnGetPathToSettingsXml
            // 
            this._btnGetPathToSettingsXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnGetPathToSettingsXml.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnGetPathToSettingsXml.Location = new System.Drawing.Point(583, 3);
            this._btnGetPathToSettingsXml.Name = "_btnGetPathToSettingsXml";
            this._btnGetPathToSettingsXml.Size = new System.Drawing.Size(24, 24);
            this._btnGetPathToSettingsXml.TabIndex = 16;
            this._btnGetPathToSettingsXml.Text = "...";
            this._btnGetPathToSettingsXml.UseVisualStyleBackColor = true;
            // 
            // _textBox_PathToSettingsXml
            // 
            this._textBox_PathToSettingsXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBox_PathToSettingsXml.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBox_PathToSettingsXml.Location = new System.Drawing.Point(253, 4);
            this._textBox_PathToSettingsXml.Name = "_textBox_PathToSettingsXml";
            this._textBox_PathToSettingsXml.Size = new System.Drawing.Size(324, 23);
            this._textBox_PathToSettingsXml.TabIndex = 15;
            // 
            // _lblPathToSettingsXml
            // 
            this._lblPathToSettingsXml.AutoSize = true;
            this._lblPathToSettingsXml.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblPathToSettingsXml.Location = new System.Drawing.Point(3, 7);
            this._lblPathToSettingsXml.Name = "_lblPathToSettingsXml";
            this._lblPathToSettingsXml.Size = new System.Drawing.Size(249, 16);
            this._lblPathToSettingsXml.TabIndex = 14;
            this._lblPathToSettingsXml.Text = "Путь к глобальному файлу настроек";
            // 
            // _tabPage_Global
            // 
            this._tabPage_Global.Location = new System.Drawing.Point(4, 25);
            this._tabPage_Global.Name = "_tabPage_Global";
            this._tabPage_Global.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage_Global.Size = new System.Drawing.Size(610, 301);
            this._tabPage_Global.TabIndex = 1;
            this._tabPage_Global.Text = "Глобальные";
            this._tabPage_Global.UseVisualStyleBackColor = true;
            // 
            // _panel_LocalWorkingArea
            // 
            //this._panel_LocalWorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel_LocalWorkingArea.Location = new System.Drawing.Point(0, 30);
            this._panel_LocalWorkingArea.Margin = new System.Windows.Forms.Padding(0);
            this._panel_LocalWorkingArea.Name = "_panel_LocalWorkingArea";
            this._panel_LocalWorkingArea.Size = new System.Drawing.Size(610, 271);
            this._panel_LocalWorkingArea.TabIndex = 2;
            // 
            // SettingsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tabControl_Settings);
            this.Name = "SettingsTabControl";
            this.Size = new System.Drawing.Size(618, 330);
            this._tabControl_Settings.ResumeLayout(false);
            this._tabPage_Local.ResumeLayout(false);
            this._tableLayoutPanel_LocalContent.ResumeLayout(false);
            this._panel_LocalProtectedArea.ResumeLayout(false);
            this._panel_LocalProtectedArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl_Settings;
        private System.Windows.Forms.TabPage _tabPage_Local;
        private System.Windows.Forms.TabPage _tabPage_Global;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel_LocalContent;
        private System.Windows.Forms.Panel _panel_LocalProtectedArea;
        private System.Windows.Forms.Button _btnGetPathToSettingsXml;
        private System.Windows.Forms.TextBox _textBox_PathToSettingsXml;
        private System.Windows.Forms.Label _lblPathToSettingsXml;
        private SettingsWorkingAreaControl _panel_LocalWorkingArea;
    }
}
