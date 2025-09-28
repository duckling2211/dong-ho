using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.CompilerServices;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data.SqlTypes;

namespace Clock
{
    public partial class Form1 : Form
    {
        private struct TimePoint
        {
            public int hr, min, sec, milsec;
            public int xHr, yHr, xMin, yMin, xSec, ySec;
        }



        private Graphics g;
        private int xCen, yCen, rSec = 140, rMin = 110, rHr = 70;
        private bool timer = false, stopWatch = false, isResettingStopWatch;

        private Pen pSec = new Pen(Brushes.Blue, 1),
            p = new Pen(Color.Black, 30), pMin = new Pen(Brushes.Black, 2), pHr = new Pen(Brushes.Black, 4);

        TimePoint old = new TimePoint(), current = new TimePoint();
        int newStopWatch = 0, idealStopWatch = 0;
        int TMmeasure = 0;
        private void SWPlay_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "00:00:00") { MessageBox.Show("Please enter a value", "Warning"); textBox1.Enabled = true; }
            else
            {
                int sec = int.Parse(textBox1.Text.Substring(6, 2));
                int min = int.Parse(textBox1.Text.Substring(3, 2)) * 60;
                int hour = int.Parse(textBox1.Text.Substring(0, 2)) * 3600;
                newStopWatch = hour + min + sec;
                if (idealStopWatch == 0) idealStopWatch = newStopWatch;
                stopWatch = true;
                StopWatchCircle.Value = 60000;
                textBox1.Enabled = false;
            }
        }

        private void SWPause_Click(object sender, EventArgs e)
        {
            stopWatch = false;
            textBox1.Enabled = true;
        }

        private void SWReset_Click(object sender, EventArgs e)
        {
            stopWatch = false;
            idealStopWatch = 0;
            textBox1.Text = "00:00:00";
            StopWatchCircle.Value = 60000;
            textBox1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "00:00:00";
                idealStopWatch = 0;
            }
            //(int)(60000 * 1 - ((float)newStopWatch / (float)idealStopWatch));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //if (char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar) || !isResettingStopWatch) e.Handled = true;
            if (isResettingStopWatch && char.IsDigit(e.KeyChar))
            {
                string tb0 = textBox1.Text;
                tb0 = tb0.Remove(2, 1); 
                tb0 = tb0.Remove(4, 1);
                tb0 = tb0.Remove(0, 1);
                // textBox1.Text.Remove(textBox1.SelectionStart - 1, 1);
                textBox1.SelectionStart = textBox1.Text.Length;
                tb0 = tb0 + e.KeyChar;
                textBox1.Text = tb0.Substring(0, 2) + ":" + tb0.Substring(2, 2) + ":" + tb0.Substring(4, 2);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            stopWatch = false; isResettingStopWatch = true;
            idealStopWatch = 0;

        }
        private void MTimer(object sender, EventArgs e)
        {
            if (timer) //TIMER
            {

                current.milsec = DateTime.Now.Millisecond;
                current.sec = DateTime.Now.Second * 1000 + current.milsec;
                current.min = DateTime.Now.Minute * 60000 + current.sec;
                current.hr = (DateTime.UtcNow.Hour + timezonePick.Value) * 3600000 + current.min;
                TMmeasure += current.hr - old.hr;
                old = current;
                string a = "0" + (TMmeasure / 3600000).ToString();
                string b = "0" + ((TMmeasure % 3600000) / 60000).ToString();
                string c = "0" + ((TMmeasure % 60000) / 1000).ToString();
                textBox2.Text = a.Substring(a.Length - 2, 2) + ":" + b.Substring(b.Length - 2, 2) + ":" + c.Substring(c.Length - 2, 2);
                string d = "00" + (TMmeasure % 1000).ToString();
                textBox3.Text = d.Substring(d.Length - 3, 3);
            }
        }

        private void TMPlay(object sender, EventArgs e)
        {
            timer = true;
        }

        private void HelpPage(object sender, EventArgs e)
        {
            MessageBox.Show(
        "STOPWATCH: Góc phải-trên." + Environment.NewLine +
        "Nhập thời gian trực tiếp vào ô số. Ấn PLAY để bắt đầu, PAUSE để ngưng, và RESET để xóa trạng thái." + Environment.NewLine +
        "TIMER: Góc phải-dưới." + Environment.NewLine +
        "Ấn PLAY để bắt đầu, PAUSE để ngưng, và RESET để xóa trạng thái.",
        "Shortcut",
        MessageBoxButtons.OK,
        //MessageBoxIcon.Warning // for Warning  
        //MessageBoxIcon.Error // for Error 
        MessageBoxIcon.Information  // for Information
                                    //MessageBoxIcon.Question // for Question
        );
        }

        private void TMPause(object sender, EventArgs e)
        {
            timer = false;
        }

        private void TMReset(object sender, EventArgs e)
        {
            timer = false;
            TMmeasure = 0;
            textBox2.Text = "00:00:00"; textBox3.Text = "000";
        }


        /*private void CreatePeriod()
        {
            TimePoint T1, T2;
            int dd;
            string n;
            newPeriods[iOfP].t1 = T1;
            newPeriods[iOfP].t1 = T2;
            newPeriods[iOfP].daysDif = dd;
            newPeriods[iOfP++].name = n;
        }*/

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
        }

        private void timezonePick_ValueChanged(object sender, EventArgs e)
        {
            Timezone.Text = "UTC ";
            if (timezonePick.Value >= 0) Timezone.Text += "+";
            Timezone.Text += timezonePick.Value.ToString();
            switch (timezonePick.Value)
            {
                case 12:
                    locationTZ.Text = "Fiji"; break;
                case 11:
                    locationTZ.Text = "Vanuatu"; break;
                case 10:
                    locationTZ.Text = "Papua New Guinea"; break;
                case 9:
                    locationTZ.Text = "Nhật Bản"; break;
                case 8:
                    locationTZ.Text = "Trung Quốc"; break;
                case 7:
                    locationTZ.Text = "Việt Nam"; break;
                case 6:
                    locationTZ.Text = "Bangladesh"; break;
                case 5:
                    locationTZ.Text = "Pakistan"; break;
                case 4:
                    locationTZ.Text = "UAE"; break;
                case 3:
                    locationTZ.Text = "Qatar"; break;
                case 2:
                    locationTZ.Text = "Phần Lan"; break;
                case 1:
                    locationTZ.Text = "Đức"; break;
                case 0:
                    locationTZ.Text = "Vương Quốc Anh"; break;
                case -12:
                    locationTZ.Text = "Đảo Baker"; break;
                case -11:
                    locationTZ.Text = "American Samoa"; break;
                case -10:
                    locationTZ.Text = "Hawaii (Mỹ)"; break;
                case -9:
                    locationTZ.Text = "Alaska (Mỹ)"; break;
                case -8:
                    locationTZ.Text = "California (Mỹ)"; break;
                case -7:
                    locationTZ.Text = "Arizona (Mỹ)"; break;
                case -6:
                    locationTZ.Text = "Mexico, Texas (Mỹ)"; break;
                case -5:
                    locationTZ.Text = "Colombia" + Environment.NewLine + " Massachusetts (Mỹ)"; break;
                case -4:
                    locationTZ.Text = "Chile, Venezuela"; break;
                case -3:
                    locationTZ.Text = "Argentina, Brazil"; break;
                case -2:
                    locationTZ.Text = "Fernando de Noronha" + Environment.NewLine + "(Brazil)"; break;
                case -1:
                    locationTZ.Text = "Cape Verde"; break;
            }
            current.milsec = DateTime.Now.Millisecond;
            current.sec = DateTime.Now.Second * 1000 + current.milsec;
            current.min = DateTime.Now.Minute * 60000 + current.sec;
            current.hr = (DateTime.UtcNow.Hour + timezonePick.Value) * 3600000 + current.min;

            timer = false;
            TMmeasure = 0;
            textBox2.Text = "00:00:00"; textBox3.Text = "000";
            //from TimerMain_Tick
            checkTheme();
            if (current.sec != old.sec)
            {
                int radius = 170;

                g.Clear(this.BackColor);
                g.DrawEllipse(p, xCen - radius, yCen - radius, 2 * radius, 2 * radius);
                DrawHands(current.hr, current.min, current.sec);
                old = current;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UniversalTick.Stop();
        }
        private void TimerMain_Tick(object sender, EventArgs e)
        {
            current.milsec = DateTime.Now.Millisecond;
            current.sec = DateTime.Now.Second * 1000 + current.milsec;
            current.min = DateTime.Now.Minute * 60000 + current.sec;
            current.hr = (DateTime.UtcNow.Hour + timezonePick.Value) * 3600000 + current.min;

            checkTheme();
            if (current.hr != old.hr)
            {
                int radius = 170;

                g.Clear(this.BackColor);
                g.DrawEllipse(p, xCen - radius, yCen - radius, 2 * radius, 2 * radius);
                DrawHands(current.hr, current.min, current.sec);
            }
            if (timer)
            {
                //tmr = current.hr;
                TMmeasure += current.hr - old.hr;
                string a = "0" + (TMmeasure / 3600000).ToString();
                string b = "0" + ((TMmeasure % 3600000) / 60000).ToString();
                string c = "0" + ((TMmeasure % 60000) / 1000).ToString();
                textBox2.Text = a.Substring(a.Length - 2, 2) + ":" + b.Substring(b.Length - 2, 2) + ":" + c.Substring(c.Length - 2, 2);
                string d = "00" + (TMmeasure % 1000).ToString();
                textBox3.Text = d.Substring(d.Length - 3, 3);
            }
            old = current;
            if (!stopWatch) return;
            if (newStopWatch >= 0 && idealStopWatch != 0)
            {
                string a = "0" + (newStopWatch / 3600).ToString();
                string b = "0" + ((newStopWatch % 3600) / 60).ToString();
                string c = "0" + (newStopWatch % 60).ToString();
                textBox1.Text = a.Substring(a.Length-2,2) + ":" +  b.Substring(b.Length-2,2) + ":" +  c.Substring(c.Length-2,2);
                StopWatchCircle.Value = (int)(60000 * ((float)newStopWatch / (float)idealStopWatch));
                newStopWatch--;
            }
            else
            {
                StopWatchCircle.Value = 60000;
                textBox1.Text = "00:00:00";
                textBox1.Enabled = true;
            }
        }

        void checkTheme()
        {
            int localHour = DateTime.UtcNow.Hour + timezonePick.Value;
            if (localHour < 0) localHour = 24 + localHour;

            //time based theme
            if ((localHour) <= 5)
            {
                this.BackColor = Color.MidnightBlue;
                pSec = new Pen(Brushes.Orange, 3); p = new Pen(Color.White, 5); pMin = new Pen(Brushes.White, 4); pHr = new Pen(Brushes.White, 6);
                Timezone.ForeColor = Color.White; locationTZ.ForeColor = Color.White;
            }
            if ((localHour) > 5 && (localHour) <= 9)
            {
                this.BackColor = Color.LightYellow;
                pSec = new Pen(Brushes.Blue, 3); p = new Pen(Color.Black, 5); pMin = new Pen(Brushes.Black, 4); pHr = new Pen(Brushes.Black, 6);
                Timezone.ForeColor = Color.Black; locationTZ.ForeColor = Color.Black;
            }
            if ((localHour) > 9 && (localHour) <= 14)
            {
                this.BackColor = Color.White;
                pSec = new Pen(Brushes.Gray, 3); p = new Pen(Color.Black, 5); pMin = new Pen(Brushes.Black, 4); pHr = new Pen(Brushes.Black, 6);
                Timezone.ForeColor = Color.Black; locationTZ.ForeColor = Color.Black;
            }
            if ((localHour) > 14 && (localHour) <= 18)
            {
                this.BackColor = Color.Bisque;
                pSec = new Pen(Brushes.Purple, 3); p = new Pen(Color.Black, 5); pMin = new Pen(Brushes.Black, 4); pHr = new Pen(Brushes.Black, 6);
                Timezone.ForeColor = Color.Black; locationTZ.ForeColor = Color.Black;
            }
            if ((localHour) > 18 && (localHour) <= 20)
            {
                this.BackColor = Color.RoyalBlue;
                pSec = new Pen(Brushes.White, 3); p = new Pen(Color.Black, 5); pMin = new Pen(Brushes.Black, 4); pHr = new Pen(Brushes.Black, 6);
                Timezone.ForeColor = Color.White; locationTZ.ForeColor = Color.White;
            }
            if ((localHour) > 20)
            {
                this.BackColor = Color.Black;
                pSec = new Pen(Brushes.LightGreen, 3); p = new Pen(Color.White, 5); pMin = new Pen(Brushes.White, 4); pHr = new Pen(Brushes.White, 6);
                Timezone.ForeColor = Color.White; locationTZ.ForeColor = Color.White;
            }
        }

        private double TimeToAngle(int sec, int cycle)
        {
            double aTime = 2.0 * Math.PI / cycle;
            double angle = Math.PI / 2.0 - aTime * sec;
            if (angle < 0) angle += Math.PI * 2.0;
            return angle;
        }

        private void DrawHands(int hr, int min, int sec)
        {
            double alpha1 = TimeToAngle(sec, 60000), alpha2 = TimeToAngle(min, 3600000), alpha3 = TimeToAngle(hr, 43200000);
            int dSecX = (int)(Math.Cos(alpha1) * rSec), dSecY = (int)(Math.Sin(alpha1) * rSec);
            int dMinX = (int)(Math.Cos(alpha2) * rMin), dMinY = (int)(Math.Sin(alpha2) * rMin);
            int dHrX = (int)(Math.Cos(alpha3) * rHr), dHrY = (int)(Math.Sin(alpha3) * rHr);
            current.xHr = xCen + dHrX; current.yHr = yCen - dHrY; current.xMin = xCen + dMinX; current.yMin = yCen - dMinY; current.xSec = xCen + dSecX; current.ySec = yCen - dSecY;

            g.DrawLine(pHr, xCen, yCen, current.xHr, current.yHr);
            g.DrawLine(pMin, xCen, yCen, current.xMin, current.yMin);
            g.DrawLine(pSec, xCen, yCen, current.xSec, current.ySec);
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            //Hi
        }

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            xCen = this.Width / 2; yCen = this.Height / 2;
        }
    }
}





