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

namespace stopwatch_timer {
    public partial class Stopwatch : Form {
        MainForm mainForm;

        int hour = 0;
        int minute = 0;
        int second = 0;

        int prevHour = 0;
        int prevMinute = 0;
        int prevSecond = 0;

        public Stopwatch(MainForm mainForm) {
            InitializeComponent();

            this.mainForm = mainForm;
        }


        private void Stopwatch_FormClosing(object sender, FormClosingEventArgs e) {
            mainForm.Show();
        }
        

        private void timerS_Tick(object sender, EventArgs e) {
            second = second + 1;
            if (second == 59) {
                minute = minute + 1;
                second = 0;
            }

            if (minute == 59) {
                hour = hour + 1;
                minute = 0;
            }

            hrTimerLabel.Text = hour.ToString();
            minTimerLabel.Text = minute.ToString();
            secTimerLabel.Text = second.ToString();
        }


        private void startStopwatchButton_Click(object sender, EventArgs e) {
            if (startStopwatchButton.Text == "Start") {
                hour = 0;
                minute = 0;
                second = 0;

                hrTimerLabel.Text = hour.ToString();
                minTimerLabel.Text = minute.ToString();
                secTimerLabel.Text = second.ToString();

                timerS.Start();

                startStopwatchButton.Text = "Stop";

                StopwatchList.Clear();
            }
            else if (startStopwatchButton.Text == "Stop") {
                timerS.Stop();
                startStopwatchButton.Text = "Start";
                PauseButton.Text = "Pause";

                prevHour = 0;
                prevMinute = 0;
                prevSecond = 0;
            }
        }

        private void CircleButton_Click(object sender, EventArgs e) {
            if (PauseButton.Text == "Continue") {
                return;
            }

            int circleHour = hour - prevHour;
            int circleMinute = minute - prevMinute;
            int circleSecond = second - prevSecond;

            StopwatchList.Items.Add(" + " + circleHour.ToString() + ":" + circleMinute.ToString() + ":" + circleSecond.ToString() +
                "(" + hour.ToString() + ":" + minute.ToString() + ":" + second.ToString() + ")");

            prevHour = hour;
            prevMinute = minute;
            prevSecond = second;
        }

        private void PauseButton_Click(object sender, EventArgs e) {
            if (PauseButton.Text == "Pause") {
                timerS.Stop();
                PauseButton.Text = "Continue";
            }
            else if (PauseButton.Text == "Continue") {
                timerS.Start();
                PauseButton.Text = "Pause";
            }
        }
    }
}
