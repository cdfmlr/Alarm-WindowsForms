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

        // TODO: timePictureBox的背景

        private Graphics clockGraphics;

        private AlarmDatabase alarmDatabase;

        private int _selectedAlarmIndex = -1;

        private TickMarkDrawHelper tickMarkDrawHelper;

        ContextMenu notifyContextMenu = new ContextMenu();

        public Form1()
        {
            InitializeComponent();

            clockGraphics = timePictureBox.CreateGraphics();

            alarmDatabase = new AlarmDatabase("alarm.data.txt");

            alarmListBox.Items.AddRange(alarmDatabase.Alarms.ToArray());    // TODO: pprint
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

                        alarmListBox.Items.Clear();
                        alarmListBox.Items.AddRange(alarmDatabase.Alarms.ToArray());
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

            drawHand(sAngle, (int)(radius), 2, Color.Aqua);
            drawHand(mAngle, (int)(radius*0.8), 4, Color.Red);
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
            /*
            if (!string.IsNullOrWhiteSpace(newHourTextBox.Text) &&
                !string.IsNullOrWhiteSpace(newMinuteTextBox.Text) &&
                !string.IsNullOrWhiteSpace(newTitleTextBox.Text))
            {
                
                // DO SOMETHING
            }
            */

            try
            {
                // TODO: 时间值的合理性检查

                Alarm alarm = new Alarm
                {
                    Hour = Int16.Parse(newHourTextBox.Text),
                    Minute = Int16.Parse(newMinuteTextBox.Text),
                    Run = newRunCheckBox.Checked,
                    Title = newTitleTextBox.Text
                };
                alarmDatabase.Alarms.Add(alarm);
                alarmDatabase.Save();
                
                alarmListBox.Items.Clear();
                alarmListBox.Items.AddRange(alarmDatabase.Alarms.ToArray());
                
            } catch
            {
                MessageBox.Show("请正确填写时间、标题。", "添加失败");
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

            editTitleTextBox.ReadOnly = true;
            editHourTextBox.ReadOnly = true;
            editMinuteTextBox.ReadOnly = true;
            editRunCheckBox.Enabled = false;
            editSaveButton.Enabled = false;
            editDeleteButton.Enabled = false;
        }

        private void editEditButton_Click(object sender, EventArgs e)
        {
            editTitleTextBox.ReadOnly = false;
            editHourTextBox.ReadOnly = false;
            editMinuteTextBox.ReadOnly = false;
            editRunCheckBox.Enabled = true;
            editSaveButton.Enabled = true;
            editDeleteButton.Enabled = true;
        }

        private void editSaveButton_Click(object sender, EventArgs e)
        {
            // TODO: 时间值的合理性检查

            Alarm alarm = new Alarm
            {
                Hour = Int16.Parse(editHourTextBox.Text),
                Minute = Int16.Parse(editMinuteTextBox.Text),
                Run = editRunCheckBox.Checked,
                Title = editTitleTextBox.Text
            };
            alarmDatabase.Alarms[_selectedAlarmIndex] = alarm;
            alarmDatabase.Save();

            alarmListBox.Items.Clear();
            alarmListBox.Items.AddRange(alarmDatabase.Alarms.ToArray());

            editTitleTextBox.ReadOnly = true;
            editHourTextBox.ReadOnly = true;
            editMinuteTextBox.ReadOnly = true;
            editRunCheckBox.Enabled = false;
            editSaveButton.Enabled = false;
            editDeleteButton.Enabled = false;
        }

        private void editDeleteButton_Click(object sender, EventArgs e)
        {
            alarmDatabase.Alarms.RemoveAt(_selectedAlarmIndex);
            alarmDatabase.Save();

            alarmListBox.Items.Clear();
            alarmListBox.Items.AddRange(alarmDatabase.Alarms.ToArray());

            editTitleTextBox.ReadOnly = true;
            editHourTextBox.ReadOnly = true;
            editMinuteTextBox.ReadOnly = true;
            editRunCheckBox.Enabled = false;
            editSaveButton.Enabled = false;
            editDeleteButton.Enabled = false;
        }

        private void clearAllAlarmsButton_Click(object sender, EventArgs e)
        {
            alarmDatabase.Alarms.Clear();
            alarmDatabase.Save();

            alarmListBox.Items.Clear();
            alarmListBox.Items.AddRange(alarmDatabase.Alarms.ToArray());
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
    }
}
