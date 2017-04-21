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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_ok = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_xls = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_txt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_exit = new System.Windows.Forms.ToolStripButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGod = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ok,
            this.toolStripButton_xls,
            this.toolStripButton_txt,
            this.toolStripButton_exit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(565, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_ok
            // 
            this.toolStripButton_ok.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ok.Image = global::m75d8.Properties.Resources._24px_png_ok;
            this.toolStripButton_ok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ok.Name = "toolStripButton_ok";
            this.toolStripButton_ok.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_ok.Text = "toolStripButton1";
            // 
            // toolStripButton_xls
            // 
            this.toolStripButton_xls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_xls.Image = global::m75d8.Properties.Resources._24px_png_print_xls;
            this.toolStripButton_xls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_xls.Name = "toolStripButton_xls";
            this.toolStripButton_xls.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_xls.Text = "toolStripButton1";
            // 
            // toolStripButton_txt
            // 
            this.toolStripButton_txt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_txt.Image = global::m75d8.Properties.Resources._24px_png_view;
            this.toolStripButton_txt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_txt.Name = "toolStripButton_txt";
            this.toolStripButton_txt.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_txt.Text = "toolStripButton1";
            // 
            // toolStripButton_exit
            // 
            this.toolStripButton_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_exit.Image = global::m75d8.Properties.Resources._24px_png_exit;
            this.toolStripButton_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_exit.Name = "toolStripButton_exit";
            this.toolStripButton_exit.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton_exit.Text = "toolStripButton1";
            // 
            // lblTitle
            // 
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
            this.lblGod.Location = new System.Drawing.Point(61, 67);
            this.lblGod.Name = "lblGod";
            this.lblGod.Size = new System.Drawing.Size(49, 16);
            this.lblGod.TabIndex = 3;
            this.lblGod.Text = "на год";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(54, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // m75d8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 284);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblGod);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "m75d8";
            this.Text = "Потребность в материалах на год. Цеха. Изделия. XLS-файл. Формирование";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_ok;
        private System.Windows.Forms.ToolStripButton toolStripButton_xls;
        private System.Windows.Forms.ToolStripButton toolStripButton_txt;
        private System.Windows.Forms.ToolStripButton toolStripButton_exit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

