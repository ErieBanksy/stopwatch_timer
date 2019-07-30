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
    public partial class Stopwatch : Form {
        MainForm mainForm;

        public Stopwatch(MainForm mainForm) {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void Stopwatch_FormClosing(object sender, FormClosingEventArgs e) {
            mainForm.Show();
        }
    }
}
