﻿namespace Clock
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cmShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.cmShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.cmChooseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.cmColor = new System.Windows.Forms.ToolStripMenuItem();
			this.cmBackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.cmForeColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.cmAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.cmLoadOnWinStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cmExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.cbShowDate = new System.Windows.Forms.CheckBox();
			this.btnHideControls = new System.Windows.Forms.Button();
			this.cbShowWeekDay = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.contextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenu;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(19, 11);
			this.labelTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(459, 108);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "labelTime";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenu
			// 
			this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmTopmost,
            this.cmShowControls,
            this.toolStripSeparator1,
            this.cmShowDate,
            this.cmShowConsole,
            this.cmShowWeekday,
            this.toolStripSeparator2,
            this.cmChooseFont,
            this.cmColor,
            this.toolStripSeparator5,
            this.cmAlarms,
            this.toolStripSeparator4,
            this.cmLoadOnWinStartup,
            this.toolStripSeparator3,
            this.cmExit});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(392, 474);
			// 
			// cmTopmost
			// 
			this.cmTopmost.CheckOnClick = true;
			this.cmTopmost.Name = "cmTopmost";
			this.cmTopmost.Size = new System.Drawing.Size(391, 44);
			this.cmTopmost.Text = "Topmost";
			this.cmTopmost.CheckedChanged += new System.EventHandler(this.cmTopmost_CheckedChanged);
			// 
			// cmShowControls
			// 
			this.cmShowControls.CheckOnClick = true;
			this.cmShowControls.Name = "cmShowControls";
			this.cmShowControls.Size = new System.Drawing.Size(391, 44);
			this.cmShowControls.Text = "Show controls";
			this.cmShowControls.CheckedChanged += new System.EventHandler(this.cmShowControls_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(388, 6);
			// 
			// cmShowDate
			// 
			this.cmShowDate.CheckOnClick = true;
			this.cmShowDate.Name = "cmShowDate";
			this.cmShowDate.Size = new System.Drawing.Size(391, 44);
			this.cmShowDate.Text = "Show date";
			this.cmShowDate.CheckedChanged += new System.EventHandler(this.cmShowDate_CheckedChanged);
			// 
			// cmShowConsole
			// 
			this.cmShowConsole.CheckOnClick = true;
			this.cmShowConsole.Name = "cmShowConsole";
			this.cmShowConsole.Size = new System.Drawing.Size(391, 44);
			this.cmShowConsole.Text = "Show console ";
			this.cmShowConsole.CheckedChanged += new System.EventHandler(this.cmShowConsole_CheckedChanged);
			// 
			// cmShowWeekday
			// 
			this.cmShowWeekday.CheckOnClick = true;
			this.cmShowWeekday.Name = "cmShowWeekday";
			this.cmShowWeekday.Size = new System.Drawing.Size(391, 44);
			this.cmShowWeekday.Text = "Show weekday";
			this.cmShowWeekday.CheckedChanged += new System.EventHandler(this.cmShowWeekday_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(388, 6);
			// 
			// cmChooseFont
			// 
			this.cmChooseFont.Name = "cmChooseFont";
			this.cmChooseFont.Size = new System.Drawing.Size(391, 44);
			this.cmChooseFont.Text = "Choose font";
			this.cmChooseFont.Click += new System.EventHandler(this.cmChooseFont_Click);
			// 
			// cmColor
			// 
			this.cmColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmBackColor,
            this.cmForeColor});
			this.cmColor.Name = "cmColor";
			this.cmColor.Size = new System.Drawing.Size(391, 44);
			this.cmColor.Text = "Colors";
			// 
			// cmBackColor
			// 
			this.cmBackColor.Name = "cmBackColor";
			this.cmBackColor.Size = new System.Drawing.Size(375, 48);
			this.cmBackColor.Text = "Background color";
			this.cmBackColor.Click += new System.EventHandler(this.SetColor);
			// 
			// cmForeColor
			// 
			this.cmForeColor.Name = "cmForeColor";
			this.cmForeColor.Size = new System.Drawing.Size(375, 48);
			this.cmForeColor.Text = "Foreground color";
			this.cmForeColor.Click += new System.EventHandler(this.SetColor);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(388, 6);
			// 
			// cmAlarms
			// 
			this.cmAlarms.Name = "cmAlarms";
			this.cmAlarms.Size = new System.Drawing.Size(391, 44);
			this.cmAlarms.Text = "Alarms";
			this.cmAlarms.Click += new System.EventHandler(this.cmAlarm_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(388, 6);
			// 
			// cmLoadOnWinStartup
			// 
			this.cmLoadOnWinStartup.CheckOnClick = true;
			this.cmLoadOnWinStartup.Name = "cmLoadOnWinStartup";
			this.cmLoadOnWinStartup.Size = new System.Drawing.Size(391, 44);
			this.cmLoadOnWinStartup.Text = "Load on Windovs startup";
			this.cmLoadOnWinStartup.CheckedChanged += new System.EventHandler(this.cmLoadOnWinStartup_CheckedChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(388, 6);
			// 
			// cmExit
			// 
			this.cmExit.Name = "cmExit";
			this.cmExit.Size = new System.Drawing.Size(391, 44);
			this.cmExit.Text = "Exit";
			this.cmExit.Click += new System.EventHandler(this.cmExit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// cbShowDate
			// 
			this.cbShowDate.AutoSize = true;
			this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowDate.Location = new System.Drawing.Point(23, 312);
			this.cbShowDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.cbShowDate.Name = "cbShowDate";
			this.cbShowDate.Size = new System.Drawing.Size(387, 61);
			this.cbShowDate.TabIndex = 1;
			this.cbShowDate.Text = "Показать дату";
			this.cbShowDate.UseVisualStyleBackColor = true;
			this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
			// 
			// btnHideControls
			// 
			this.btnHideControls.AllowDrop = true;
			this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHideControls.Location = new System.Drawing.Point(16, 457);
			this.btnHideControls.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.btnHideControls.Name = "btnHideControls";
			this.btnHideControls.Size = new System.Drawing.Size(401, 105);
			this.btnHideControls.TabIndex = 2;
			this.btnHideControls.Text = "Hide Controls";
			this.btnHideControls.UseVisualStyleBackColor = true;
			this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
			// 
			// cbShowWeekDay
			// 
			this.cbShowWeekDay.AutoSize = true;
			this.cbShowWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbShowWeekDay.Location = new System.Drawing.Point(23, 384);
			this.cbShowWeekDay.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.cbShowWeekDay.Name = "cbShowWeekDay";
			this.cbShowWeekDay.Size = new System.Drawing.Size(563, 59);
			this.cbShowWeekDay.TabIndex = 3;
			this.cbShowWeekDay.Text = "Показать день недели";
			this.cbShowWeekDay.UseVisualStyleBackColor = true;
			this.cbShowWeekDay.CheckedChanged += new System.EventHandler(this.cbShowWeekDay_CheckedChanged);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// axWindowsMediaPlayer
			// 
			this.axWindowsMediaPlayer.Enabled = true;
			this.axWindowsMediaPlayer.Location = new System.Drawing.Point(37, 102);
			this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
			this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
			this.axWindowsMediaPlayer.Size = new System.Drawing.Size(280, 41);
			this.axWindowsMediaPlayer.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 696);
			this.Controls.Add(this.axWindowsMediaPlayer);
			this.Controls.Add(this.cbShowWeekDay);
			this.Controls.Add(this.btnHideControls);
			this.Controls.Add(this.cbShowDate);
			this.Controls.Add(this.labelTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock PV_319";
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.contextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.CheckBox cbShowWeekDay;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmTopmost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmShowDate;
        private System.Windows.Forms.ToolStripMenuItem cmShowWeekday;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmColor;
        private System.Windows.Forms.ToolStripMenuItem cmBackColor;
        private System.Windows.Forms.ToolStripMenuItem cmForeColor;
        private System.Windows.Forms.ToolStripMenuItem cmShowControls;
        private System.Windows.Forms.ToolStripMenuItem cmChooseFont;
        private System.Windows.Forms.ToolStripMenuItem cmShowConsole;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem cmLoadOnWinStartup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem cmAlarms;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
	}
}

