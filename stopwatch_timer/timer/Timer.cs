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
    public partial class Timer : Form {
        MainForm mainForm;

        public Timer(MainForm mainForm) {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void Timer_FormClosing(object sender, FormClosingEventArgs e) {
            mainForm.Show();
        }
    }
}
