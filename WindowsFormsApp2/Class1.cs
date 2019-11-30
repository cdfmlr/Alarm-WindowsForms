using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Alarm
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public bool Run { get; set; }

        string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value.Replace(":", "：");    // 换成全角字符，防止与字段分隔符冲突。
            }
        }

        public override string ToString()
        {
            return $"{Hour}:{Minute}:{Run}:{Title}";
        }

        public Alarm() { }

        public Alarm(string s)
        {
            string[] ss = s.Split(':');

            this.Hour = Int16.Parse(ss[0]);
            this.Minute = Int16.Parse(ss[1]);
            this.Run = bool.Parse(ss[2]);
            this.Title = ss[3];
        }

        public bool isOnTime(DateTime dateTime)
        {
            return dateTime.Hour == this.Hour && dateTime.Minute == this.Minute && dateTime.Second == 0;
        }
    }

    public class AlarmDatabase
    {
        public string FilePath { get; set; }

        public List<Alarm> Alarms { get; set; }

        public AlarmDatabase(string filePath)
        {
            this.Alarms = new List<Alarm>();
            this.FilePath = filePath;
            this.Load();
        }

        public void Load()
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                Alarms.Clear();
                for (string line = sr.ReadLine(); line != null; line = sr.ReadLine())
                {
                    Alarms.Add(new Alarm(line));
                }
                sr.Close();
                fs.Close();

            } catch
            {
                return;
            }
        }

        public void Save()
        {
            try
            {
                File.Delete(FilePath);
                if (Alarms.Count == 0)
                {
                    return;
                }
                FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                foreach(var line in Alarms)
                {
                    sw.WriteLine(line.ToString());
                }
                sw.Flush();
                sw.Close();
                fs.Close();
            } catch
            {
                return;
            }
        }

    }

    public class TickMarkDrawHelper
    {
        public double Radius { get; set; }

        private List<Pen> TmPens { get; set; }
        private List<RectangleF> TmRects { get; set; }

        public TickMarkDrawHelper(Point center, double radius)
        {
            Radius = radius;

            TmPens = new List<Pen>();
            TmRects = new List<RectangleF>();

            for (int index = 0; index < 60; index++)
            {
                double size = (index % 5 == 0 ? 3 : 1);
                double radians = index * 2 * Math.PI / 60;
                double x = center.X + radius * Math.Sin(radians) - size / 2;
                double y = center.Y - radius * Math.Cos(radians) - size / 2;

                Pen tmPen = new Pen(Color.Gainsboro, (float)size);
                RectangleF tmRect = new RectangleF((float)x, (float)y, (float)size, (float)size);

                TmPens.Add(tmPen);
                TmRects.Add(tmRect);
            }
        }

        public void get(int index, out Pen pen, out RectangleF rect)
        {
            int i = index % 60;
            pen = TmPens[i];
            rect = TmRects[i];
        }
    }
}
