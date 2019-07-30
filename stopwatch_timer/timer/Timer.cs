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
    public enum INTERIM_VAL { SECOND = 59, MINUTE = 59};

    public partial class Timer : Form {
        MainForm mainForm;

        int hour = 0;
        int minute = 0;
        int second = 0;

        public Timer(MainForm mainForm) {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void Timer_FormClosing(object sender, FormClosingEventArgs e) {
            mainForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            second = second - 1;
            if (second == -1) {
                minute = minute - 1;
                second = (int)INTERIM_VAL.SECOND;
            }
            
            if (minute == -1) {
                hour = hour - 1;
                minute = (int)INTERIM_VAL.MINUTE;
            }

            hrTimerLabel.Text = hour.ToString();
            minTimerLabel.Text = minute.ToString();
            secTimerLabel.Text = second.ToString();

            if (second <= 10 && minute == 0 && hour == 0) {
                hrTimerLabel.ForeColor = Color.Red;
                minTimerLabel.ForeColor = Color.Red;
                secTimerLabel.ForeColor = Color.Red;
            }

            if (second == 0 && minute == 0 && hour == 0) {
                timerT.Stop();
                hrTimerLabel.Text = "0";
                minTimerLabel.Text = "0";
                secTimerLabel.Text = "0";

                hrTimerLabel.ForeColor = Color.Black;
                minTimerLabel.ForeColor = Color.Black;
                secTimerLabel.ForeColor = Color.Black;

                startTimerButton.Text = "Start";
            }
        }

        private void startTimerButton_Click(object sender, EventArgs e) {
            if (startTimerButton.Text == "Start") {
                hour = Convert.ToInt32(hourNumeric.Value);
                minute = Convert.ToInt32(minuteNumeric.Value);
                second = Convert.ToInt32(secondNumeric.Value);

                if (second == 0 && minute == 0 && hour == 0) {
                    return;
                }

                hrTimerLabel.Text = hourNumeric.Value.ToString();
                minTimerLabel.Text = minuteNumeric.Value.ToString();
                secTimerLabel.Text = secondNumeric.Value.ToString();

                timerT.Start();

                startTimerButton.Text = "Stop";
            }
            else if (startTimerButton.Text == "Stop") {
                timerT.Stop();

                hrTimerLabel.ForeColor = Color.Black;
                minTimerLabel.ForeColor = Color.Black;
                secTimerLabel.ForeColor = Color.Black;

                startTimerButton.Text = "Start";
            }

        }
        
    }
}
