namespace WallpaperChanger
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveImg = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.type = new MetroFramework.Controls.MetroComboBox();
            this.width = new MetroFramework.Controls.MetroTextBox();
            this.height = new MetroFramework.Controls.MetroTextBox();
            this.source = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.autoChange = new MetroFramework.Controls.MetroToggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.keywords = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerSec = new MetroFramework.Controls.MetroTextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customImage = new MetroFramework.Controls.MetroTextBox();
            this.setCustomImg = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.save = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.setCurr = new MetroFramework.Controls.MetroButton();
            this.folder = new MetroFramework.Controls.MetroButton();
            this.ContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveImg
            // 
            this.saveImg.AutoSize = true;
            this.saveImg.Checked = true;
            this.saveImg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveImg.Location = new System.Drawing.Point(118, 56);
            this.saveImg.Name = "saveImg";
            this.saveImg.Size = new System.Drawing.Size(80, 17);
            this.saveImg.TabIndex = 0;
            this.saveImg.Text = "On";
            this.saveImg.UseSelectable = true;
            this.saveImg.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Auto save";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(22, 27);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(163, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Change Wallpaper";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.ItemHeight = 23;
            this.type.Items.AddRange(new object[] {
            "any",
            "collection",
            "user"});
            this.type.Location = new System.Drawing.Point(92, 89);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(121, 29);
            this.type.TabIndex = 3;
            this.type.UseSelectable = true;
            this.type.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // width
            // 
            // 
            // 
            // 
            this.width.CustomButton.Image = null;
            this.width.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.width.CustomButton.Name = "";
            this.width.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.width.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.width.CustomButton.TabIndex = 1;
            this.width.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.width.CustomButton.UseSelectable = true;
            this.width.CustomButton.Visible = false;
            this.width.Lines = new string[] {
        "1366"};
            this.width.Location = new System.Drawing.Point(92, 187);
            this.width.MaxLength = 32767;
            this.width.Name = "width";
            this.width.PasswordChar = '\0';
            this.width.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.width.SelectedText = "";
            this.width.SelectionLength = 0;
            this.width.SelectionStart = 0;
            this.width.ShortcutsEnabled = true;
            this.width.Size = new System.Drawing.Size(52, 23);
            this.width.TabIndex = 4;
            this.width.Text = "1366";
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.width.UseSelectable = true;
            this.width.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.width.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.width.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // height
            // 
            // 
            // 
            // 
            this.height.CustomButton.Image = null;
            this.height.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.height.CustomButton.Name = "";
            this.height.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.height.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.height.CustomButton.TabIndex = 1;
            this.height.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.height.CustomButton.UseSelectable = true;
            this.height.CustomButton.Visible = false;
            this.height.Lines = new string[] {
        "768"};
            this.height.Location = new System.Drawing.Point(161, 186);
            this.height.MaxLength = 32767;
            this.height.Name = "height";
            this.height.PasswordChar = '\0';
            this.height.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.height.SelectedText = "";
            this.height.SelectionLength = 0;
            this.height.SelectionStart = 0;
            this.height.ShortcutsEnabled = true;
            this.height.Size = new System.Drawing.Size(52, 23);
            this.height.TabIndex = 5;
            this.height.Text = "768";
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.height.UseSelectable = true;
            this.height.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.height.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // source
            // 
            // 
            // 
            // 
            this.source.CustomButton.Image = null;
            this.source.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.source.CustomButton.Name = "";
            this.source.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.source.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.source.CustomButton.TabIndex = 1;
            this.source.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.source.CustomButton.UseSelectable = true;
            this.source.CustomButton.Visible = false;
            this.source.Lines = new string[] {
        "1065396"};
            this.source.Location = new System.Drawing.Point(226, 95);
            this.source.MaxLength = 32767;
            this.source.Name = "source";
            this.source.PasswordChar = '\0';
            this.source.PromptText = "Id or username";
            this.source.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.source.SelectedText = "";
            this.source.SelectionLength = 0;
            this.source.SelectionStart = 0;
            this.source.ShortcutsEnabled = true;
            this.source.Size = new System.Drawing.Size(76, 23);
            this.source.TabIndex = 6;
            this.source.Text = "1065396";
            this.source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.source.UseSelectable = true;
            this.source.WaterMark = "Id or username";
            this.source.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.source.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.source.TextChanged += new System.EventHandler(this.source_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(32, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Size";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Source";
            // 
            // autoChange
            // 
            this.autoChange.AutoSize = true;
            this.autoChange.Location = new System.Drawing.Point(118, 223);
            this.autoChange.Name = "autoChange";
            this.autoChange.Size = new System.Drawing.Size(80, 17);
            this.autoChange.TabIndex = 9;
            this.autoChange.Text = "Off";
            this.autoChange.UseSelectable = true;
            this.autoChange.CheckedChanged += new System.EventHandler(this.autoChange_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Auto change";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // keywords
            // 
            // 
            // 
            // 
            this.keywords.CustomButton.Image = null;
            this.keywords.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.keywords.CustomButton.Name = "";
            this.keywords.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keywords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keywords.CustomButton.TabIndex = 1;
            this.keywords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keywords.CustomButton.UseSelectable = true;
            this.keywords.CustomButton.Visible = false;
            this.keywords.Lines = new string[] {
        "nature"};
            this.keywords.Location = new System.Drawing.Point(92, 140);
            this.keywords.MaxLength = 32767;
            this.keywords.Name = "keywords";
            this.keywords.PasswordChar = '\0';
            this.keywords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keywords.SelectedText = "";
            this.keywords.SelectionLength = 0;
            this.keywords.SelectionStart = 0;
            this.keywords.ShortcutsEnabled = true;
            this.keywords.Size = new System.Drawing.Size(121, 23);
            this.keywords.TabIndex = 11;
            this.keywords.Text = "nature";
            this.keywords.UseSelectable = true;
            this.keywords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keywords.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.keywords.TextChanged += new System.EventHandler(this.keywords_TextChanged);
            this.keywords.Click += new System.EventHandler(this.keywords_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(22, 140);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Keywords";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerSec
            // 
            // 
            // 
            // 
            this.TimerSec.CustomButton.Image = null;
            this.TimerSec.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.TimerSec.CustomButton.Name = "";
            this.TimerSec.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TimerSec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TimerSec.CustomButton.TabIndex = 1;
            this.TimerSec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TimerSec.CustomButton.UseSelectable = true;
            this.TimerSec.CustomButton.Visible = false;
            this.TimerSec.Lines = new string[] {
        "5"};
            this.TimerSec.Location = new System.Drawing.Point(226, 217);
            this.TimerSec.MaxLength = 32767;
            this.TimerSec.Name = "TimerSec";
            this.TimerSec.PasswordChar = '\0';
            this.TimerSec.PromptText = "Seconds";
            this.TimerSec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TimerSec.SelectedText = "";
            this.TimerSec.SelectionLength = 0;
            this.TimerSec.SelectionStart = 0;
            this.TimerSec.ShortcutsEnabled = true;
            this.TimerSec.Size = new System.Drawing.Size(76, 23);
            this.TimerSec.TabIndex = 13;
            this.TimerSec.Text = "5";
            this.TimerSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimerSec.UseSelectable = true;
            this.TimerSec.WaterMark = "Seconds";
            this.TimerSec.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TimerSec.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TimerSec.TextChanged += new System.EventHandler(this.TimerSec_TextChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "WallpaperChanger";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // customImage
            // 
            // 
            // 
            // 
            this.customImage.CustomButton.Image = null;
            this.customImage.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.customImage.CustomButton.Name = "";
            this.customImage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.customImage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.customImage.CustomButton.TabIndex = 1;
            this.customImage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.customImage.CustomButton.UseSelectable = true;
            this.customImage.CustomButton.Visible = false;
            this.customImage.Lines = new string[0];
            this.customImage.Location = new System.Drawing.Point(314, 31);
            this.customImage.MaxLength = 32767;
            this.customImage.Name = "customImage";
            this.customImage.PasswordChar = '\0';
            this.customImage.PromptText = "URL";
            this.customImage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.customImage.SelectedText = "";
            this.customImage.SelectionLength = 0;
            this.customImage.SelectionStart = 0;
            this.customImage.ShortcutsEnabled = true;
            this.customImage.Size = new System.Drawing.Size(277, 23);
            this.customImage.TabIndex = 15;
            this.customImage.UseSelectable = true;
            this.customImage.WaterMark = "URL";
            this.customImage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.customImage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.customImage.TextChanged += new System.EventHandler(this.customImage_TextChanged);
            // 
            // setCustomImg
            // 
            this.setCustomImg.Location = new System.Drawing.Point(597, 31);
            this.setCustomImg.Name = "setCustomImg";
            this.setCustomImg.Size = new System.Drawing.Size(37, 23);
            this.setCustomImg.TabIndex = 16;
            this.setCustomImg.Text = "OK";
            this.setCustomImg.UseSelectable = true;
            this.setCustomImg.Click += new System.EventHandler(this.setCustomImg_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(226, 31);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 17;
            this.metroLabel6.Text = "Set Custom";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(545, 262);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(89, 23);
            this.save.TabIndex = 18;
            this.save.Text = "Save Current";
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(314, 262);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(89, 23);
            this.metroButton2.TabIndex = 19;
            this.metroButton2.Text = "Show Next";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // setCurr
            // 
            this.setCurr.Location = new System.Drawing.Point(432, 262);
            this.setCurr.Name = "setCurr";
            this.setCurr.Size = new System.Drawing.Size(89, 23);
            this.setCurr.TabIndex = 20;
            this.setCurr.Text = "Set Current";
            this.setCurr.UseSelectable = true;
            this.setCurr.Click += new System.EventHandler(this.setCurr_Click);
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(22, 262);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(122, 23);
            this.folder.TabIndex = 21;
            this.folder.Text = "Open Saved folder";
            this.folder.UseSelectable = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWallpaperToolStripMenuItem,
            this.AutoChangeMenu,
            this.MenuAutoSave,
            this.exitToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(186, 114);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // changeWallpaperToolStripMenuItem
            // 
            this.changeWallpaperToolStripMenuItem.Name = "changeWallpaperToolStripMenuItem";
            this.changeWallpaperToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changeWallpaperToolStripMenuItem.Text = "Change Wallpaper";
            this.changeWallpaperToolStripMenuItem.Click += new System.EventHandler(this.changeWallpaperToolStripMenuItem_Click);
            // 
            // AutoChangeMenu
            // 
            this.AutoChangeMenu.Name = "AutoChangeMenu";
            this.AutoChangeMenu.Size = new System.Drawing.Size(185, 22);
            this.AutoChangeMenu.Text = "On/Off Auto Change";
            this.AutoChangeMenu.Click += new System.EventHandler(this.AutoChangeMenu_Click);
            // 
            // MenuAutoSave
            // 
            this.MenuAutoSave.Name = "MenuAutoSave";
            this.MenuAutoSave.Size = new System.Drawing.Size(185, 22);
            this.MenuAutoSave.Text = "On/Off auto save";
            this.MenuAutoSave.Click += new System.EventHandler(this.MenuAutoSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 312);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.setCurr);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.setCustomImg);
            this.Controls.Add(this.customImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TimerSec);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.keywords);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.autoChange);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.source);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.type);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.saveImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Wallpaper Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroToggle saveImg;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox type;
        private MetroFramework.Controls.MetroTextBox width;
        private MetroFramework.Controls.MetroTextBox height;
        private MetroFramework.Controls.MetroTextBox source;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle autoChange;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox keywords;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox TimerSec;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox customImage;
        private MetroFramework.Controls.MetroButton setCustomImg;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton save;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton setCurr;
        private MetroFramework.Controls.MetroButton folder;
        private MetroFramework.Controls.MetroContextMenu ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWallpaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoChangeMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAutoSave;
    }
}

