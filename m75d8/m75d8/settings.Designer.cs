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
            this._btnGetDirToSearchIn = new System.Windows.Forms.Button();
            this._toolStrip_Horizontal = new System.Windows.Forms.ToolStrip();
            this._toolStripButton_Ok = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton_Cancel = new System.Windows.Forms.ToolStripButton();
            this._groupBox_sqlconnection = new System.Windows.Forms.GroupBox();
            this._textBox_Password = new System.Windows.Forms.TextBox();
            this._textBox_UserName = new System.Windows.Forms.TextBox();
            this._lblPassword = new System.Windows.Forms.Label();
            this._lblUserName = new System.Windows.Forms.Label();
            this._toolStrip_Horizontal.SuspendLayout();
            this._groupBox_sqlconnection.SuspendLayout();
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
            this._textBox_DirToSearchIn.Location = new System.Drawing.Point(260, 43);
            this._textBox_DirToSearchIn.Name = "_textBox_DirToSearchIn";
            this._textBox_DirToSearchIn.Size = new System.Drawing.Size(234, 23);
            this._textBox_DirToSearchIn.TabIndex = 1;
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
            // _groupBox_sqlconnection
            // 
            this._groupBox_sqlconnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBox_sqlconnection.Controls.Add(this._textBox_Password);
            this._groupBox_sqlconnection.Controls.Add(this._textBox_UserName);
            this._groupBox_sqlconnection.Controls.Add(this._lblPassword);
            this._groupBox_sqlconnection.Controls.Add(this._lblUserName);
            this._groupBox_sqlconnection.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._groupBox_sqlconnection.Location = new System.Drawing.Point(15, 74);
            this._groupBox_sqlconnection.Name = "_groupBox_sqlconnection";
            this._groupBox_sqlconnection.Size = new System.Drawing.Size(509, 97);
            this._groupBox_sqlconnection.TabIndex = 11;
            this._groupBox_sqlconnection.TabStop = false;
            this._groupBox_sqlconnection.Text = "Настройки подключения к sql-серверу";
            // 
            // _textBox_Password
            // 
            this._textBox_Password.Location = new System.Drawing.Point(153, 62);
            this._textBox_Password.Name = "_textBox_Password";
            this._textBox_Password.Size = new System.Drawing.Size(173, 23);
            this._textBox_Password.TabIndex = 2;
            // 
            // _textBox_UserName
            // 
            this._textBox_UserName.Location = new System.Drawing.Point(152, 27);
            this._textBox_UserName.Name = "_textBox_UserName";
            this._textBox_UserName.Size = new System.Drawing.Size(174, 23);
            this._textBox_UserName.TabIndex = 1;
            // 
            // _lblPassword
            // 
            this._lblPassword.AutoSize = true;
            this._lblPassword.Location = new System.Drawing.Point(94, 65);
            this._lblPassword.Name = "_lblPassword";
            this._lblPassword.Size = new System.Drawing.Size(56, 16);
            this._lblPassword.TabIndex = 0;
            this._lblPassword.Text = "пароль";
            // 
            // _lblUserName
            // 
            this._lblUserName.AutoSize = true;
            this._lblUserName.Location = new System.Drawing.Point(19, 30);
            this._lblUserName.Name = "_lblUserName";
            this._lblUserName.Size = new System.Drawing.Size(130, 16);
            this._lblUserName.TabIndex = 0;
            this._lblUserName.Text = "имя пользователя";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 183);
            this.Controls.Add(this._groupBox_sqlconnection);
            this.Controls.Add(this._toolStrip_Horizontal);
            this.Controls.Add(this._btnGetDirToSearchIn);
            this.Controls.Add(this._textBox_DirToSearchIn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки программы";
            this._toolStrip_Horizontal.ResumeLayout(false);
            this._toolStrip_Horizontal.PerformLayout();
            this._groupBox_sqlconnection.ResumeLayout(false);
            this._groupBox_sqlconnection.PerformLayout();
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
        private System.Windows.Forms.GroupBox _groupBox_sqlconnection;
        private System.Windows.Forms.TextBox _textBox_Password;
        private System.Windows.Forms.TextBox _textBox_UserName;
        private System.Windows.Forms.Label _lblPassword;
        private System.Windows.Forms.Label _lblUserName;
    }
}