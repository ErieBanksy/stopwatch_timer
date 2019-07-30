using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stopwatch_timer {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void StopwatchButton_Click(object sender, EventArgs e) {
            Stopwatch sw = new Stopwatch(this);
            sw.Show();
            Hide();
        }

        private void TimerButton_Click(object sender, EventArgs e) {
            Timer t = new Timer(this);
            t.Show();
            Hide();
        }
    }
}
