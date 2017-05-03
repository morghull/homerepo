namespace m75d8
{
    partial class m75d8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m75d8));
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._toolStripButton_Ok = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton_XlsView = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton_TxtView = new System.Windows.Forms.ToolStripButton();
            this._toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGod = new System.Windows.Forms.Label();
            this._dateTimePicker_Year = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._grpBox_Kiz = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this._grpBox_Nc = new System.Windows.Forms.GroupBox();
            this._radioButton_NcExclude = new System.Windows.Forms.RadioButton();
            this._radioButton_NcInclude = new System.Windows.Forms.RadioButton();
            this._radioButton_NcAll = new System.Windows.Forms.RadioButton();
            this._btnGetPathTo_mm75030 = new System.Windows.Forms.Button();
            this._textBox_mm75030Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._textBox_mm75040Path = new System.Windows.Forms.TextBox();
            this._btnGetPathTo_mm75040 = new System.Windows.Forms.Button();
            this._toolStripButton_Settings = new System.Windows.Forms.ToolStripButton();
            this._toolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this._grpBox_Kiz.SuspendLayout();
            this._grpBox_Nc.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStrip
            // 
            this._toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._toolStrip.AutoSize = false;
            this._toolStrip.BackColor = System.Drawing.Color.Transparent;
            this._toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripButton_Ok,
            this._toolStripButton_XlsView,
            this._toolStripButton_TxtView,
            this._toolStripButton_Exit,
            this._toolStripButton_Settings});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(571, 31);
            this._toolStrip.TabIndex = 1;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _toolStripButton_Ok
            // 
            this._toolStripButton_Ok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripButton_Ok.Image = global::m75d8.Properties.Resources._24px_png_ok;
            this._toolStripButton_Ok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton_Ok.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this._toolStripButton_Ok.Name = "_toolStripButton_Ok";
            this._toolStripButton_Ok.Size = new System.Drawing.Size(28, 28);
            this._toolStripButton_Ok.Text = "Начать формирование xls-файла";
            // 
            // _toolStripButton_XlsView
            // 
            this._toolStripButton_XlsView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripButton_XlsView.Enabled = false;
            this._toolStripButton_XlsView.Image = global::m75d8.Properties.Resources._24px_png_print_xls;
            this._toolStripButton_XlsView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton_XlsView.Name = "_toolStripButton_XlsView";
            this._toolStripButton_XlsView.Size = new System.Drawing.Size(28, 28);
            this._toolStripButton_XlsView.Text = "Просмотреть сформированный xls-файл";
            // 
            // _toolStripButton_TxtView
            // 
            this._toolStripButton_TxtView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripButton_TxtView.Enabled = false;
            this._toolStripButton_TxtView.Image = global::m75d8.Properties.Resources._24px_png_view;
            this._toolStripButton_TxtView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton_TxtView.Name = "_toolStripButton_TxtView";
            this._toolStripButton_TxtView.Size = new System.Drawing.Size(28, 28);
            this._toolStripButton_TxtView.Text = "Просмотреть протокол работы";
            // 
            // _toolStripButton_Exit
            // 
            this._toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripButton_Exit.Image = global::m75d8.Properties.Resources._24px_png_exit;
            this._toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton_Exit.Name = "_toolStripButton_Exit";
            this._toolStripButton_Exit.Size = new System.Drawing.Size(28, 28);
            this._toolStripButton_Exit.Text = "Выйти из программы";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(15, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(536, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Потребность в материалах на год. Цеха. Изделия. XLS-файл. Формирование.";
            // 
            // lblGod
            // 
            this.lblGod.AutoSize = true;
            this.lblGod.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGod.Location = new System.Drawing.Point(61, 62);
            this.lblGod.Name = "lblGod";
            this.lblGod.Size = new System.Drawing.Size(49, 16);
            this.lblGod.TabIndex = 3;
            this.lblGod.Text = "на год";
            // 
            // _dateTimePicker_Year
            // 
            this._dateTimePicker_Year.CustomFormat = "yyyy";
            this._dateTimePicker_Year.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._dateTimePicker_Year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._dateTimePicker_Year.Location = new System.Drawing.Point(115, 60);
            this._dateTimePicker_Year.Name = "_dateTimePicker_Year";
            this._dateTimePicker_Year.ShowUpDown = true;
            this._dateTimePicker_Year.Size = new System.Drawing.Size(54, 23);
            this._dateTimePicker_Year.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._grpBox_Kiz, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._grpBox_Nc, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 153);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 104);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // _grpBox_Kiz
            // 
            this._grpBox_Kiz.Controls.Add(this.radioButton1);
            this._grpBox_Kiz.Controls.Add(this.radioButton2);
            this._grpBox_Kiz.Controls.Add(this.radioButton3);
            this._grpBox_Kiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grpBox_Kiz.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._grpBox_Kiz.Location = new System.Drawing.Point(272, 3);
            this._grpBox_Kiz.Name = "_grpBox_Kiz";
            this._grpBox_Kiz.Size = new System.Drawing.Size(264, 98);
            this._grpBox_Kiz.TabIndex = 7;
            this._grpBox_Kiz.TabStop = false;
            this._grpBox_Kiz.Text = "Номер цеха";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(177, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "За исключением цехов";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(163, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "По указанным цехам";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "По всем цехам";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // _grpBox_Nc
            // 
            this._grpBox_Nc.Controls.Add(this._radioButton_NcExclude);
            this._grpBox_Nc.Controls.Add(this._radioButton_NcInclude);
            this._grpBox_Nc.Controls.Add(this._radioButton_NcAll);
            this._grpBox_Nc.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grpBox_Nc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._grpBox_Nc.Location = new System.Drawing.Point(3, 3);
            this._grpBox_Nc.Name = "_grpBox_Nc";
            this._grpBox_Nc.Size = new System.Drawing.Size(263, 98);
            this._grpBox_Nc.TabIndex = 6;
            this._grpBox_Nc.TabStop = false;
            this._grpBox_Nc.Text = "Номер цеха";
            // 
            // _radioButton_NcExclude
            // 
            this._radioButton_NcExclude.AutoSize = true;
            this._radioButton_NcExclude.Location = new System.Drawing.Point(6, 68);
            this._radioButton_NcExclude.Name = "_radioButton_NcExclude";
            this._radioButton_NcExclude.Size = new System.Drawing.Size(177, 20);
            this._radioButton_NcExclude.TabIndex = 2;
            this._radioButton_NcExclude.Text = "За исключением цехов";
            this._radioButton_NcExclude.UseVisualStyleBackColor = true;
            // 
            // _radioButton_NcInclude
            // 
            this._radioButton_NcInclude.AutoSize = true;
            this._radioButton_NcInclude.Location = new System.Drawing.Point(6, 45);
            this._radioButton_NcInclude.Name = "_radioButton_NcInclude";
            this._radioButton_NcInclude.Size = new System.Drawing.Size(163, 20);
            this._radioButton_NcInclude.TabIndex = 1;
            this._radioButton_NcInclude.Text = "По указанным цехам";
            this._radioButton_NcInclude.UseVisualStyleBackColor = true;
            // 
            // _radioButton_NcAll
            // 
            this._radioButton_NcAll.AutoSize = true;
            this._radioButton_NcAll.Checked = true;
            this._radioButton_NcAll.Location = new System.Drawing.Point(6, 22);
            this._radioButton_NcAll.Name = "_radioButton_NcAll";
            this._radioButton_NcAll.Size = new System.Drawing.Size(124, 20);
            this._radioButton_NcAll.TabIndex = 0;
            this._radioButton_NcAll.TabStop = true;
            this._radioButton_NcAll.Text = "По всем цехам";
            this._radioButton_NcAll.UseVisualStyleBackColor = true;
            // 
            // _btnGetPathTo_mm75030
            // 
            this._btnGetPathTo_mm75030.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnGetPathTo_mm75030.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnGetPathTo_mm75030.Location = new System.Drawing.Point(528, 90);
            this._btnGetPathTo_mm75030.Name = "_btnGetPathTo_mm75030";
            this._btnGetPathTo_mm75030.Size = new System.Drawing.Size(24, 24);
            this._btnGetPathTo_mm75030.TabIndex = 8;
            this._btnGetPathTo_mm75030.Text = "...";
            this._btnGetPathTo_mm75030.UseVisualStyleBackColor = true;
            // 
            // _textBox_mm75030Path
            // 
            this._textBox_mm75030Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBox_mm75030Path.Enabled = false;
            this._textBox_mm75030Path.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBox_mm75030Path.Location = new System.Drawing.Point(160, 91);
            this._textBox_mm75030Path.Name = "_textBox_mm75030Path";
            this._textBox_mm75030Path.Size = new System.Drawing.Size(362, 23);
            this._textBox_mm75030Path.TabIndex = 9;
            this._textBox_mm75030Path.Text = "укажите путь к файлу mm76030.dbf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "путь к mm75030.dbf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "путь к mm75040.dbf";
            // 
            // _textBox_mm75040Path
            // 
            this._textBox_mm75040Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._textBox_mm75040Path.Enabled = false;
            this._textBox_mm75040Path.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._textBox_mm75040Path.Location = new System.Drawing.Point(160, 122);
            this._textBox_mm75040Path.Name = "_textBox_mm75040Path";
            this._textBox_mm75040Path.Size = new System.Drawing.Size(362, 23);
            this._textBox_mm75040Path.TabIndex = 12;
            this._textBox_mm75040Path.Text = "укажите путь к файлу mm76040.dbf";
            // 
            // _btnGetPathTo_mm75040
            // 
            this._btnGetPathTo_mm75040.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnGetPathTo_mm75040.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnGetPathTo_mm75040.Location = new System.Drawing.Point(528, 121);
            this._btnGetPathTo_mm75040.Name = "_btnGetPathTo_mm75040";
            this._btnGetPathTo_mm75040.Size = new System.Drawing.Size(24, 24);
            this._btnGetPathTo_mm75040.TabIndex = 11;
            this._btnGetPathTo_mm75040.Text = "...";
            this._btnGetPathTo_mm75040.UseVisualStyleBackColor = true;
            // 
            // _toolStripButton_Settings
            // 
            this._toolStripButton_Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripButton_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripButton_Settings.Image = global::m75d8.Properties.Resources._24px_png_settings;
            this._toolStripButton_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButton_Settings.Name = "_toolStripButton_Settings";
            this._toolStripButton_Settings.Size = new System.Drawing.Size(28, 28);
            this._toolStripButton_Settings.Text = "toolStripButton1";
            // 
            // m75d8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._textBox_mm75040Path);
            this.Controls.Add(this._btnGetPathTo_mm75040);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._textBox_mm75030Path);
            this.Controls.Add(this._btnGetPathTo_mm75030);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._dateTimePicker_Year);
            this.Controls.Add(this.lblGod);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this._toolStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 307);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(580, 307);
            this.Name = "m75d8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потребность в материалах на год. Цеха. Изделия. XLS-файл. Формирование";
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this._grpBox_Kiz.ResumeLayout(false);
            this._grpBox_Kiz.PerformLayout();
            this._grpBox_Nc.ResumeLayout(false);
            this._grpBox_Nc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _toolStripButton_Ok;
        private System.Windows.Forms.ToolStripButton _toolStripButton_XlsView;
        private System.Windows.Forms.ToolStripButton _toolStripButton_TxtView;
        private System.Windows.Forms.ToolStripButton _toolStripButton_Exit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGod;
        private System.Windows.Forms.DateTimePicker _dateTimePicker_Year;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox _grpBox_Kiz;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox _grpBox_Nc;
        private System.Windows.Forms.RadioButton _radioButton_NcExclude;
        private System.Windows.Forms.RadioButton _radioButton_NcInclude;
        private System.Windows.Forms.RadioButton _radioButton_NcAll;
        private System.Windows.Forms.Button _btnGetPathTo_mm75030;
        private System.Windows.Forms.TextBox _textBox_mm75030Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _textBox_mm75040Path;
        private System.Windows.Forms.Button _btnGetPathTo_mm75040;
        private System.Windows.Forms.ToolStripButton _toolStripButton_Settings;
    }
}

