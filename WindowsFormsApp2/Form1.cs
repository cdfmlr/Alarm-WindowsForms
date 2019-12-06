using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Graphics clockGraphics;

        private AlarmDatabase alarmDatabase;

        private int _selectedAlarmIndex = -1;

        private TickMarkDrawHelper tickMarkDrawHelper;

        // ContextMenu notifyContextMenu = new ContextMenu();

        public Form1()
        {
            InitializeComponent();

            clockGraphics = timePictureBox.CreateGraphics();

            clockGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            alarmDatabase = new AlarmDatabase("alarm.data.txt");

            refreshAlarmListBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.notifyIcon.Text = "小闹钟";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
            }
        }

        public void update()
        {
            DateTime now = DateTime.Now;

            drawClock(now);

            if (settingPerHourAlarmCheckBox.Checked && now.Minute == 0 && now.Second == 0)
            {
                perHourAlarm(now);
            }

            if (settingManualAlarmCheckBox.Checked)
            {
                for (int i = 0; i < alarmDatabase.Alarms.Count; i++)
                {
                    if (alarmDatabase.Alarms[i].Run && alarmDatabase.Alarms[i].isOnTime(now))
                    {
                        manualAlarm(alarmDatabase.Alarms[i]);
                        alarmDatabase.Alarms[i].Run = false;
                        alarmDatabase.Save();

                        refreshAlarmListBox();
                    }
                }

            }
        }

        private void manualAlarm(Alarm alarm)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            TopMost = true;
            MessageBox.Show($"{alarm.Title}", $"时间提醒:{alarm.Hour}:{alarm.Minute}",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void perHourAlarm(DateTime dateTime)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            TopMost = true;
            MessageBox.Show("整点报时:" + dateTime, "系统提示", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void drawClock(DateTime time)
        {
            int s = time.Second;
            int m = time.Minute;
            int h = time.Hour % 12;

            double sAngle = 180.0 - s * 6;
            double mAngle = 180.0 - (m + s / 60.0) * 6;
            double hAngle = 180.0 - (h + m / 60.0) * 30;

            double radius = 0.45 * Math.Min(timePictureBox.Width, timePictureBox.Height);

            // clockGraphics.Clear(Color.White);

            // drawTickMarks(radius);
            timePictureBox.Refresh();

            drawHand(sAngle, (int)(radius*0.9), 2, Color.Aqua);
            drawHand(mAngle, (int)(radius*0.75), 4, Color.Red);
            drawHand(hAngle, (int)(radius*0.64), 8, Color.Blue);

        }

        private void drawTickMarks(double radius,Graphics g)
        {
            Point centerPoint = new Point();
            centerPoint.X = timePictureBox.Width / 2;
            centerPoint.Y = timePictureBox.Height / 2;

            Pen ctPen = new Pen(Color.Black, 8);
            RectangleF centerRect = new RectangleF(centerPoint.X - 4, centerPoint.Y - 4, 8, 8);

            g.DrawEllipse(ctPen, centerRect);

            if (tickMarkDrawHelper == null || tickMarkDrawHelper.Radius != radius)
            {
                tickMarkDrawHelper = new TickMarkDrawHelper(centerPoint, radius);
            }

            for(int index = 0; index < 60; index++)
            {
                Pen tmPen;
                RectangleF tmRect;
                tickMarkDrawHelper.get(index, out tmPen, out tmRect);
                g.DrawEllipse(tmPen, tmRect);
            }
        }

        private void drawHand(double angle, int length, int width, Color color)
        {
            Point centerPoint = new Point();
            centerPoint.X = timePictureBox.Width / 2;
            centerPoint.Y = timePictureBox.Height / 2;

            double radian = angle / 180 * Math.PI;

            Point endPoint = new Point();
            endPoint.X = (int)(centerPoint.X + length * Math.Sin(radian));
            endPoint.Y = (int)(centerPoint.X + length * Math.Cos(radian));

            Pen handPen = new Pen(color, width);

            clockGraphics.DrawLine(handPen,
                centerPoint.X, centerPoint.Y,
                endPoint.X, endPoint.Y);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int h = Int16.Parse(newHourTextBox.Text);
                int m = Int16.Parse(newMinuteTextBox.Text);
                bool r = newRunCheckBox.Checked;
                string t = newTitleTextBox.Text;

                if (!isReasonableTime(h, m))
                {
                    MessageBox.Show("您输入的时间有误，请查正后再试！", "闹钟未保存");
                    return;
                }

                Alarm alarm = new Alarm
                {
                    Hour = h,
                    Minute = m,
                    Run = r,
                    Title = t
                };
                alarmDatabase.Alarms.Add(alarm);
                alarmDatabase.Save();

                refreshAlarmListBox();

            } catch
            {
                MessageBox.Show("请正确填写时间、标题!", "添加失败");
            }
        }

        private void timePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            update();
        }

        private void newResetButton_Click(object sender, EventArgs e)
        {
            newHourTextBox.Text = "";
            newMinuteTextBox.Text = "";
            newRunCheckBox.Checked = true;
            newTitleTextBox.Text = "";
        }

        private void alarmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ListBox).SelectedIndex;

            if (index < 0 || index >= alarmDatabase.Alarms.Count)
            {
                return;
            }

            _selectedAlarmIndex = index;

            editTitleTextBox.Text = alarmDatabase.Alarms[index].Title;
            editHourTextBox.Text = alarmDatabase.Alarms[index].Hour.ToString();
            editMinuteTextBox.Text = alarmDatabase.Alarms[index].Minute.ToString();
            editRunCheckBox.Checked = alarmDatabase.Alarms[index].Run;

            alarmItemEditable(false);
        }

        private void editEditButton_Click(object sender, EventArgs e)
        {
            alarmItemEditable(true);
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int h = Int16.Parse(editHourTextBox.Text);
                int m = Int16.Parse(editMinuteTextBox.Text);
                bool r = editRunCheckBox.Checked;
                string t = editTitleTextBox.Text;

                if (!isReasonableTime(h, m))
                {
                    MessageBox.Show("您输入的时间有误，请查正后再试！", "闹钟未保存");
                    return;
                }

                Alarm alarm = new Alarm
                {
                    Hour = Int16.Parse(editHourTextBox.Text),
                    Minute = Int16.Parse(editMinuteTextBox.Text),
                    Run = editRunCheckBox.Checked,
                    Title = editTitleTextBox.Text
                };
                alarmDatabase.Alarms[_selectedAlarmIndex] = alarm;
                alarmDatabase.Save();

                refreshAlarmListBox();

                alarmItemEditable(false);
            } catch
            {
                MessageBox.Show("请正确填写时间、标题!", "保存失败");
            }

            
        }

        private void editDeleteButton_Click(object sender, EventArgs e)
        {
            alarmDatabase.Alarms.RemoveAt(_selectedAlarmIndex);
            alarmDatabase.Save();

            refreshAlarmListBox();

            alarmItemEditable(false);
        }

        private void clearAllAlarmsButton_Click(object sender, EventArgs e)
        {
            alarmDatabase.Alarms.Clear();
            alarmDatabase.Save();

            refreshAlarmListBox();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (notifyIconCheckBox.Checked)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIcon.Visible = true;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIconCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timePictureBox_Paint(object sender, PaintEventArgs e)
        {
            double radius = 0.45 * Math.Min(timePictureBox.Width, timePictureBox.Height);
            drawTickMarks(radius, e.Graphics);
        }

        private void alarmItemEditable(bool e)
        {
            editTitleTextBox.ReadOnly = !e;
            editHourTextBox.ReadOnly = !e;
            editMinuteTextBox.ReadOnly = !e;
            editRunCheckBox.Enabled = e;
            editSaveButton.Enabled = e;
            editDeleteButton.Enabled = e;
        }

        private void refreshAlarmListBox ()
        {
            alarmListBox.Items.Clear();
            // alarmListBox.Items.AddRange(alarmDatabase.Alarms.ToArray());
            alarmListBox.Items.AddRange(alarmDatabase.getAlarmsForShow());
        }

        private bool isReasonableTime(int hour, int minute)
        {
            return ((hour >= 0) && (hour < 24) && (minute >= 0) && (minute < 60));
        }
    }
}
