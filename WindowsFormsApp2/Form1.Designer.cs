namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timePictureBox = new System.Windows.Forms.PictureBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.editEditButton = new System.Windows.Forms.Button();
            this.editDeleteButton = new System.Windows.Forms.Button();
            this.editSaveButton = new System.Windows.Forms.Button();
            this.editRunCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editTitleTextBox = new System.Windows.Forms.TextBox();
            this.editHourTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editMinuteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.newRunCheckBox = new System.Windows.Forms.CheckBox();
            this.newResetButton = new System.Windows.Forms.Button();
            this.newAddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newHourTextBox = new System.Windows.Forms.TextBox();
            this.newTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newMinuteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alarmListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notifyIconCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.clearAllAlarmsButton = new System.Windows.Forms.Button();
            this.settingPerHourAlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.settingManualAlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timePictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timePictureBox);
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前时间";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // timePictureBox
            // 
            this.timePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timePictureBox.Location = new System.Drawing.Point(12, 20);
            this.timePictureBox.Name = "timePictureBox";
            this.timePictureBox.Size = new System.Drawing.Size(220, 220);
            this.timePictureBox.TabIndex = 1;
            this.timePictureBox.TabStop = false;
            this.timePictureBox.Click += new System.EventHandler(this.timePictureBox_Click);
            this.timePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.timePictureBox_Paint);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 243);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.alarmListBox);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "定点报时";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.editEditButton);
            this.groupBox5.Controls.Add(this.editDeleteButton);
            this.groupBox5.Controls.Add(this.editSaveButton);
            this.groupBox5.Controls.Add(this.editRunCheckBox);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.editTitleTextBox);
            this.groupBox5.Controls.Add(this.editHourTextBox);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.editMinuteTextBox);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(238, 127);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 100);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "详情";
            // 
            // editEditButton
            // 
            this.editEditButton.Location = new System.Drawing.Point(196, 11);
            this.editEditButton.Name = "editEditButton";
            this.editEditButton.Size = new System.Drawing.Size(75, 23);
            this.editEditButton.TabIndex = 15;
            this.editEditButton.Text = "编辑";
            this.editEditButton.UseVisualStyleBackColor = true;
            this.editEditButton.Click += new System.EventHandler(this.editEditButton_Click);
            // 
            // editDeleteButton
            // 
            this.editDeleteButton.Enabled = false;
            this.editDeleteButton.Location = new System.Drawing.Point(196, 71);
            this.editDeleteButton.Name = "editDeleteButton";
            this.editDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.editDeleteButton.TabIndex = 14;
            this.editDeleteButton.Text = "删除";
            this.editDeleteButton.UseVisualStyleBackColor = true;
            this.editDeleteButton.Click += new System.EventHandler(this.editDeleteButton_Click);
            // 
            // editSaveButton
            // 
            this.editSaveButton.Enabled = false;
            this.editSaveButton.Location = new System.Drawing.Point(196, 41);
            this.editSaveButton.Name = "editSaveButton";
            this.editSaveButton.Size = new System.Drawing.Size(75, 23);
            this.editSaveButton.TabIndex = 13;
            this.editSaveButton.Text = "保存";
            this.editSaveButton.UseVisualStyleBackColor = true;
            this.editSaveButton.Click += new System.EventHandler(this.editSaveButton_Click);
            // 
            // editRunCheckBox
            // 
            this.editRunCheckBox.AutoSize = true;
            this.editRunCheckBox.Enabled = false;
            this.editRunCheckBox.Location = new System.Drawing.Point(12, 73);
            this.editRunCheckBox.Name = "editRunCheckBox";
            this.editRunCheckBox.Size = new System.Drawing.Size(72, 16);
            this.editRunCheckBox.TabIndex = 12;
            this.editRunCheckBox.Text = "启用提醒";
            this.editRunCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "标题:";
            // 
            // editTitleTextBox
            // 
            this.editTitleTextBox.Location = new System.Drawing.Point(49, 18);
            this.editTitleTextBox.MaxLength = 20;
            this.editTitleTextBox.Name = "editTitleTextBox";
            this.editTitleTextBox.ReadOnly = true;
            this.editTitleTextBox.Size = new System.Drawing.Size(87, 21);
            this.editTitleTextBox.TabIndex = 10;
            // 
            // editHourTextBox
            // 
            this.editHourTextBox.Location = new System.Drawing.Point(49, 46);
            this.editHourTextBox.MaxLength = 2;
            this.editHourTextBox.Name = "editHourTextBox";
            this.editHourTextBox.ReadOnly = true;
            this.editHourTextBox.Size = new System.Drawing.Size(34, 21);
            this.editHourTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "时间:";
            // 
            // editMinuteTextBox
            // 
            this.editMinuteTextBox.Location = new System.Drawing.Point(102, 46);
            this.editMinuteTextBox.MaxLength = 2;
            this.editMinuteTextBox.Name = "editMinuteTextBox";
            this.editMinuteTextBox.ReadOnly = true;
            this.editMinuteTextBox.Size = new System.Drawing.Size(34, 21);
            this.editMinuteTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.newRunCheckBox);
            this.groupBox4.Controls.Add(this.newResetButton);
            this.groupBox4.Controls.Add(this.newAddButton);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.newHourTextBox);
            this.groupBox4.Controls.Add(this.newTitleTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.newMinuteTextBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(237, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加";
            // 
            // newRunCheckBox
            // 
            this.newRunCheckBox.AutoSize = true;
            this.newRunCheckBox.Checked = true;
            this.newRunCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newRunCheckBox.Location = new System.Drawing.Point(197, 20);
            this.newRunCheckBox.Name = "newRunCheckBox";
            this.newRunCheckBox.Size = new System.Drawing.Size(72, 16);
            this.newRunCheckBox.TabIndex = 15;
            this.newRunCheckBox.Text = "启用提醒";
            this.newRunCheckBox.UseVisualStyleBackColor = true;
            // 
            // newResetButton
            // 
            this.newResetButton.Location = new System.Drawing.Point(197, 71);
            this.newResetButton.Name = "newResetButton";
            this.newResetButton.Size = new System.Drawing.Size(75, 23);
            this.newResetButton.TabIndex = 8;
            this.newResetButton.Text = "重置";
            this.newResetButton.UseVisualStyleBackColor = true;
            this.newResetButton.Click += new System.EventHandler(this.newResetButton_Click);
            // 
            // newAddButton
            // 
            this.newAddButton.Location = new System.Drawing.Point(197, 42);
            this.newAddButton.Name = "newAddButton";
            this.newAddButton.Size = new System.Drawing.Size(75, 23);
            this.newAddButton.TabIndex = 7;
            this.newAddButton.Text = "添加";
            this.newAddButton.UseVisualStyleBackColor = true;
            this.newAddButton.Click += new System.EventHandler(this.newAddButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "标题:";
            // 
            // newHourTextBox
            // 
            this.newHourTextBox.Location = new System.Drawing.Point(50, 64);
            this.newHourTextBox.MaxLength = 2;
            this.newHourTextBox.Name = "newHourTextBox";
            this.newHourTextBox.Size = new System.Drawing.Size(34, 21);
            this.newHourTextBox.TabIndex = 2;
            // 
            // newTitleTextBox
            // 
            this.newTitleTextBox.Location = new System.Drawing.Point(52, 32);
            this.newTitleTextBox.MaxLength = 20;
            this.newTitleTextBox.Name = "newTitleTextBox";
            this.newTitleTextBox.Size = new System.Drawing.Size(87, 21);
            this.newTitleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "时间:";
            // 
            // newMinuteTextBox
            // 
            this.newMinuteTextBox.Location = new System.Drawing.Point(103, 64);
            this.newMinuteTextBox.MaxLength = 2;
            this.newMinuteTextBox.Name = "newMinuteTextBox";
            this.newMinuteTextBox.Size = new System.Drawing.Size(34, 21);
            this.newMinuteTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // alarmListBox
            // 
            this.alarmListBox.FormattingEnabled = true;
            this.alarmListBox.ItemHeight = 12;
            this.alarmListBox.Location = new System.Drawing.Point(6, 20);
            this.alarmListBox.Name = "alarmListBox";
            this.alarmListBox.Size = new System.Drawing.Size(225, 208);
            this.alarmListBox.TabIndex = 0;
            this.alarmListBox.SelectedIndexChanged += new System.EventHandler(this.alarmListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.notifyIconCheckBox);
            this.groupBox3.Controls.Add(this.exitButton);
            this.groupBox3.Controls.Add(this.aboutButton);
            this.groupBox3.Controls.Add(this.clearAllAlarmsButton);
            this.groupBox3.Controls.Add(this.settingPerHourAlarmCheckBox);
            this.groupBox3.Controls.Add(this.settingManualAlarmCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(505, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 192);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置";
            // 
            // notifyIconCheckBox
            // 
            this.notifyIconCheckBox.AutoSize = true;
            this.notifyIconCheckBox.Location = new System.Drawing.Point(24, 139);
            this.notifyIconCheckBox.Name = "notifyIconCheckBox";
            this.notifyIconCheckBox.Size = new System.Drawing.Size(120, 16);
            this.notifyIconCheckBox.TabIndex = 5;
            this.notifyIconCheckBox.Text = "最小化到系统托盘";
            this.notifyIconCheckBox.UseVisualStyleBackColor = true;
            this.notifyIconCheckBox.CheckedChanged += new System.EventHandler(this.notifyIconCheckBox_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(193, 133);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(193, 93);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "关于";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // clearAllAlarmsButton
            // 
            this.clearAllAlarmsButton.Location = new System.Drawing.Point(193, 53);
            this.clearAllAlarmsButton.Name = "clearAllAlarmsButton";
            this.clearAllAlarmsButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllAlarmsButton.TabIndex = 2;
            this.clearAllAlarmsButton.Text = "清空所有";
            this.clearAllAlarmsButton.UseVisualStyleBackColor = true;
            this.clearAllAlarmsButton.Click += new System.EventHandler(this.clearAllAlarmsButton_Click);
            // 
            // settingPerHourAlarmCheckBox
            // 
            this.settingPerHourAlarmCheckBox.AutoSize = true;
            this.settingPerHourAlarmCheckBox.Checked = true;
            this.settingPerHourAlarmCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingPerHourAlarmCheckBox.Location = new System.Drawing.Point(24, 93);
            this.settingPerHourAlarmCheckBox.Name = "settingPerHourAlarmCheckBox";
            this.settingPerHourAlarmCheckBox.Size = new System.Drawing.Size(72, 16);
            this.settingPerHourAlarmCheckBox.TabIndex = 1;
            this.settingPerHourAlarmCheckBox.Text = "整点报时";
            this.settingPerHourAlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // settingManualAlarmCheckBox
            // 
            this.settingManualAlarmCheckBox.AutoSize = true;
            this.settingManualAlarmCheckBox.Checked = true;
            this.settingManualAlarmCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.settingManualAlarmCheckBox.Location = new System.Drawing.Point(24, 53);
            this.settingManualAlarmCheckBox.Name = "settingManualAlarmCheckBox";
            this.settingManualAlarmCheckBox.Size = new System.Drawing.Size(72, 16);
            this.settingManualAlarmCheckBox.TabIndex = 0;
            this.settingManualAlarmCheckBox.Text = "定点报时";
            this.settingManualAlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timePictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox timePictureBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newTitleTextBox;
        private System.Windows.Forms.TextBox newHourTextBox;
        private System.Windows.Forms.TextBox newMinuteTextBox;
        private System.Windows.Forms.ListBox alarmListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button newAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button editDeleteButton;
        private System.Windows.Forms.Button editSaveButton;
        private System.Windows.Forms.CheckBox editRunCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editTitleTextBox;
        private System.Windows.Forms.TextBox editHourTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox editMinuteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newResetButton;
        private System.Windows.Forms.Button clearAllAlarmsButton;
        private System.Windows.Forms.CheckBox settingPerHourAlarmCheckBox;
        private System.Windows.Forms.CheckBox settingManualAlarmCheckBox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox newRunCheckBox;
        private System.Windows.Forms.Button editEditButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox notifyIconCheckBox;
    }
}

