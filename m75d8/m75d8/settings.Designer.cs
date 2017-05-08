namespace m75d8
{
    partial class settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.label1 = new System.Windows.Forms.Label();
            this._textBox_DirToSearchIn = new System.Windows.Forms.TextBox();
            this._toolStrip_Horizontal = new System.Windows.Forms.ToolStrip();
            this._textBox_PathToSettingsXml = new System.Windows.Forms.TextBox();
            this._lblPathToSettingsXml = new System.Windows.Forms.Label();
            this._btnGetPathToSettingsXml = new System.Windows.Forms.Button();
            this._btnGetDirToSearchIn = new System.Windows.Forms.Button();
            this._toolStripButton_Ok = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton_Cancel = new System.Windows.Forms.ToolStripButton();
            this._toolStrip_Horizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Директория для поиска dbf-файлов";
            // 
            // _textBox_DirToSearchIn
            // 
            this._textBox_DirToSearchIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBox_DirToSearchIn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBox_DirToSearchIn.Location = new System.Drawing.Point(262, 43);
            this._textBox_DirToSearchIn.Name = "_textBox_DirToSearchIn";
            this._textBox_DirToSearchIn.Size = new System.Drawing.Size(232, 23);
            this._textBox_DirToSearchIn.TabIndex = 1;
            // 
            // _toolStrip_Horizontal
            // 
            this._toolStrip_Horizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._toolStrip_Horizontal.AutoSize = false;
            this._toolStrip_Horizontal.BackColor = System.Drawing.Color.Transparent;
            this._toolStrip_Horizontal.Dock = System.Windows.Forms.DockStyle.None;
            this._toolStrip_Horizontal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip_Horizontal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._toolStrip_Horizontal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripButton_Ok,
            this._toolStripButton_Cancel});
            this._toolStrip_Horizontal.Location = new System.Drawing.Point(0, 0);
            this._toolStrip_Horizontal.Name = "_toolStrip_Horizontal";
            this._toolStrip_Horizontal.Size = new System.Drawing.Size(543, 31);
            this._toolStrip_Horizontal.TabIndex = 10;
            this._toolStrip_Horizontal.Text = "_toolStrip_Horizontal";
            // 
            // _textBox_PathToSettingsXml
            // 
            this._textBox_PathToSettingsXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBox_PathToSettingsXml.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBox_PathToSettingsXml.Location = new System.Drawing.Point(262, 74);
            this._textBox_PathToSettingsXml.Name = "_textBox_PathToSettingsXml";
            this._textBox_PathToSettingsXml.Size = new System.Drawing.Size(232, 23);
            this._textBox_PathToSettingsXml.TabIndex = 12;
            // 
            // _lblPathToSettingsXml
            // 
            this._lblPathToSettingsXml.AutoSize = true;
            this._lblPathToSettingsXml.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblPathToSettingsXml.Location = new System.Drawing.Point(12, 77);
            this._lblPathToSettingsXml.Name = "_lblPathToSettingsXml";
            this._lblPathToSettingsXml.Size = new System.Drawing.Size(249, 16);
            this._lblPathToSettingsXml.TabIndex = 11;
            this._lblPathToSettingsXml.Text = "Путь к глобальному файлу настроек";
            // 
            // _btnGetPathToSettingsXml
            // 
            this._btnGetPathToSettingsXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnGetPathToSettingsXml.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnGetPathToSettingsXml.Location = new System.Drawing.Point(500, 73);
            this._btnGetPathToSettingsXml.Name = "_btnGetPathToSettingsXml";
            this._btnGetPathToSettingsXml.Size = new System.Drawing.Size(24, 24);
            this._btnGetPathToSettingsXml.TabIndex = 13;
            this._btnGetPathToSettingsXml.Text = "...";
            this._btnGetPathToSettingsXml.UseVisualStyleBackColor = true;
            // 
            // _btnGetDirToSearchIn
            // 
            this._btnGetDirToSearchIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnGetDirToSearchIn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnGetDirToSearchIn.Location = new System.Drawing.Point(500, 42);
            this._btnGetDirToSearchIn.Name = "_btnGetDirToSearchIn";
            this._btnGetDirToSearchIn.Size = new System.Drawing.Size(24, 24);
            this._btnGetDirToSearchIn.TabIndex = 9;
            this._btnGetDirToSearchIn.Text = "...";
            this._btnGetDirToSearchIn.UseVisualStyleBackColor = true;
            // 
            // _toolStripButton_Ok
            // 
            this._toolStripButton_Ok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripButton_Ok.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButton_Ok.Image")));
            this._toolStripButton_Ok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton_Ok.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this._toolStripButton_Ok.Name = "_toolStripButton_Ok";
            this._toolStripButton_Ok.Size = new System.Drawing.Size(28, 28);
            this._toolStripButton_Ok.Text = "_toolStripButton_Ok";
            // 
            // _toolStripButton_Cancel
            // 
            this._toolStripButton_Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripButton_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButton_Cancel.Image")));
            this._toolStripButton_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton_Cancel.Name = "_toolStripButton_Cancel";
            this._toolStripButton_Cancel.Size = new System.Drawing.Size(28, 28);
            this._toolStripButton_Cancel.Text = "_toolStripButton_Cancel";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 108);
            this.Controls.Add(this._btnGetPathToSettingsXml);
            this.Controls.Add(this._textBox_PathToSettingsXml);
            this.Controls.Add(this._lblPathToSettingsXml);
            this.Controls.Add(this._toolStrip_Horizontal);
            this.Controls.Add(this._btnGetDirToSearchIn);
            this.Controls.Add(this._textBox_DirToSearchIn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки программы";
            this._toolStrip_Horizontal.ResumeLayout(false);
            this._toolStrip_Horizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBox_DirToSearchIn;
        private System.Windows.Forms.Button _btnGetDirToSearchIn;
        private System.Windows.Forms.ToolStrip _toolStrip_Horizontal;
        private System.Windows.Forms.ToolStripButton _toolStripButton_Ok;
        private System.Windows.Forms.ToolStripButton _toolStripButton_Cancel;
        private System.Windows.Forms.TextBox _textBox_PathToSettingsXml;
        private System.Windows.Forms.Label _lblPathToSettingsXml;
        private System.Windows.Forms.Button _btnGetPathToSettingsXml;
    }
}