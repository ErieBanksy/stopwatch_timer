namespace stopwatch_timer {
    partial class Timer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.hourNumeric = new System.Windows.Forms.NumericUpDown();
            this.minuteNumeric = new System.Windows.Forms.NumericUpDown();
            this.secondNumeric = new System.Windows.Forms.NumericUpDown();
            this.hrLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.hrTimerLabel = new System.Windows.Forms.Label();
            this.minTimerLabel = new System.Windows.Forms.Label();
            this.secTimerLabel = new System.Windows.Forms.Label();
            this.colonLabe1 = new System.Windows.Forms.Label();
            this.colonLabe2 = new System.Windows.Forms.Label();
            this.startTimerButton = new System.Windows.Forms.Button();
            this.timerT = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hourNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // hourNumeric
            // 
            this.hourNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourNumeric.Location = new System.Drawing.Point(78, 127);
            this.hourNumeric.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumeric.Name = "hourNumeric";
            this.hourNumeric.Size = new System.Drawing.Size(60, 26);
            this.hourNumeric.TabIndex = 0;
            // 
            // minuteNumeric
            // 
            this.minuteNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteNumeric.Location = new System.Drawing.Point(144, 127);
            this.minuteNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumeric.Name = "minuteNumeric";
            this.minuteNumeric.Size = new System.Drawing.Size(60, 26);
            this.minuteNumeric.TabIndex = 1;
            // 
            // secondNumeric
            // 
            this.secondNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumeric.Location = new System.Drawing.Point(210, 127);
            this.secondNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondNumeric.Name = "secondNumeric";
            this.secondNumeric.Size = new System.Drawing.Size(60, 26);
            this.secondNumeric.TabIndex = 2;
            // 
            // hrLabel
            // 
            this.hrLabel.AutoSize = true;
            this.hrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hrLabel.Location = new System.Drawing.Point(92, 107);
            this.hrLabel.Name = "hrLabel";
            this.hrLabel.Size = new System.Drawing.Size(27, 20);
            this.hrLabel.TabIndex = 4;
            this.hrLabel.Text = "hr.";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minLabel.Location = new System.Drawing.Point(154, 107);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(38, 20);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "min.";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secLabel.Location = new System.Drawing.Point(220, 107);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(38, 20);
            this.secLabel.TabIndex = 6;
            this.secLabel.Text = "sec.";
            // 
            // hrTimerLabel
            // 
            this.hrTimerLabel.AutoSize = true;
            this.hrTimerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hrTimerLabel.Location = new System.Drawing.Point(86, 38);
            this.hrTimerLabel.Name = "hrTimerLabel";
            this.hrTimerLabel.Size = new System.Drawing.Size(46, 57);
            this.hrTimerLabel.TabIndex = 7;
            this.hrTimerLabel.Text = "0";
            // 
            // minTimerLabel
            // 
            this.minTimerLabel.AutoSize = true;
            this.minTimerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minTimerLabel.Location = new System.Drawing.Point(146, 38);
            this.minTimerLabel.Name = "minTimerLabel";
            this.minTimerLabel.Size = new System.Drawing.Size(46, 57);
            this.minTimerLabel.TabIndex = 8;
            this.minTimerLabel.Text = "0";
            // 
            // secTimerLabel
            // 
            this.secTimerLabel.AutoSize = true;
            this.secTimerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secTimerLabel.Location = new System.Drawing.Point(212, 38);
            this.secTimerLabel.Name = "secTimerLabel";
            this.secTimerLabel.Size = new System.Drawing.Size(46, 57);
            this.secTimerLabel.TabIndex = 9;
            this.secTimerLabel.Text = "0";
            // 
            // colonLabe1
            // 
            this.colonLabe1.AutoSize = true;
            this.colonLabe1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colonLabe1.Location = new System.Drawing.Point(123, 38);
            this.colonLabe1.Name = "colonLabe1";
            this.colonLabe1.Size = new System.Drawing.Size(37, 57);
            this.colonLabe1.TabIndex = 10;
            this.colonLabe1.Text = ":";
            // 
            // colonLabe2
            // 
            this.colonLabe2.AutoSize = true;
            this.colonLabe2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colonLabe2.Location = new System.Drawing.Point(185, 38);
            this.colonLabe2.Name = "colonLabe2";
            this.colonLabe2.Size = new System.Drawing.Size(37, 57);
            this.colonLabe2.TabIndex = 12;
            this.colonLabe2.Text = ":";
            // 
            // startTimerButton
            // 
            this.startTimerButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimerButton.Location = new System.Drawing.Point(116, 191);
            this.startTimerButton.Name = "startTimerButton";
            this.startTimerButton.Size = new System.Drawing.Size(106, 39);
            this.startTimerButton.TabIndex = 13;
            this.startTimerButton.Text = "Start";
            this.startTimerButton.UseVisualStyleBackColor = true;
            this.startTimerButton.Click += new System.EventHandler(this.startTimerButton_Click);
            // 
            // timerT
            // 
            this.timerT.Interval = 1000;
            this.timerT.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(343, 317);
            this.Controls.Add(this.startTimerButton);
            this.Controls.Add(this.colonLabe2);
            this.Controls.Add(this.colonLabe1);
            this.Controls.Add(this.secTimerLabel);
            this.Controls.Add(this.minTimerLabel);
            this.Controls.Add(this.hrTimerLabel);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.hrLabel);
            this.Controls.Add(this.secondNumeric);
            this.Controls.Add(this.minuteNumeric);
            this.Controls.Add(this.hourNumeric);
            this.Name = "Timer";
            this.Text = "Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Timer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.hourNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hourNumeric;
        private System.Windows.Forms.NumericUpDown minuteNumeric;
        private System.Windows.Forms.NumericUpDown secondNumeric;
        private System.Windows.Forms.Label hrLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label hrTimerLabel;
        private System.Windows.Forms.Label minTimerLabel;
        private System.Windows.Forms.Label secTimerLabel;
        private System.Windows.Forms.Label colonLabe1;
        private System.Windows.Forms.Label colonLabe2;
        private System.Windows.Forms.Button startTimerButton;
        private System.Windows.Forms.Timer timerT;
    }
}