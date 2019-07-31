namespace stopwatch_timer {
    partial class Stopwatch {
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
            this.colonLabe2 = new System.Windows.Forms.Label();
            this.colonLabe1 = new System.Windows.Forms.Label();
            this.secTimerLabel = new System.Windows.Forms.Label();
            this.minTimerLabel = new System.Windows.Forms.Label();
            this.hrTimerLabel = new System.Windows.Forms.Label();
            this.startStopwatchButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopwatchList = new System.Windows.Forms.ListView();
            this.timerS = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // colonLabe2
            // 
            this.colonLabe2.AutoSize = true;
            this.colonLabe2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colonLabe2.Location = new System.Drawing.Point(187, 19);
            this.colonLabe2.Name = "colonLabe2";
            this.colonLabe2.Size = new System.Drawing.Size(51, 79);
            this.colonLabe2.TabIndex = 17;
            this.colonLabe2.Text = ":";
            // 
            // colonLabe1
            // 
            this.colonLabe1.AutoSize = true;
            this.colonLabe1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colonLabe1.Location = new System.Drawing.Point(101, 19);
            this.colonLabe1.Name = "colonLabe1";
            this.colonLabe1.Size = new System.Drawing.Size(51, 79);
            this.colonLabe1.TabIndex = 16;
            this.colonLabe1.Text = ":";
            // 
            // secTimerLabel
            // 
            this.secTimerLabel.AutoSize = true;
            this.secTimerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secTimerLabel.Location = new System.Drawing.Point(223, 19);
            this.secTimerLabel.Name = "secTimerLabel";
            this.secTimerLabel.Size = new System.Drawing.Size(62, 79);
            this.secTimerLabel.TabIndex = 15;
            this.secTimerLabel.Text = "0";
            // 
            // minTimerLabel
            // 
            this.minTimerLabel.AutoSize = true;
            this.minTimerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minTimerLabel.Location = new System.Drawing.Point(136, 19);
            this.minTimerLabel.Name = "minTimerLabel";
            this.minTimerLabel.Size = new System.Drawing.Size(62, 79);
            this.minTimerLabel.TabIndex = 14;
            this.minTimerLabel.Text = "0";
            // 
            // hrTimerLabel
            // 
            this.hrTimerLabel.AutoSize = true;
            this.hrTimerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hrTimerLabel.Location = new System.Drawing.Point(51, 19);
            this.hrTimerLabel.Name = "hrTimerLabel";
            this.hrTimerLabel.Size = new System.Drawing.Size(62, 79);
            this.hrTimerLabel.TabIndex = 13;
            this.hrTimerLabel.Text = "0";
            // 
            // startStopwatchButton
            // 
            this.startStopwatchButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startStopwatchButton.Location = new System.Drawing.Point(12, 130);
            this.startStopwatchButton.Name = "startStopwatchButton";
            this.startStopwatchButton.Size = new System.Drawing.Size(90, 40);
            this.startStopwatchButton.TabIndex = 18;
            this.startStopwatchButton.Text = "Start";
            this.startStopwatchButton.UseVisualStyleBackColor = true;
            this.startStopwatchButton.Click += new System.EventHandler(this.startStopwatchButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircleButton.Location = new System.Drawing.Point(126, 130);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(90, 40);
            this.CircleButton.TabIndex = 19;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.Location = new System.Drawing.Point(237, 130);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(90, 40);
            this.PauseButton.TabIndex = 20;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopwatchList
            // 
            this.StopwatchList.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopwatchList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.StopwatchList.Location = new System.Drawing.Point(65, 193);
            this.StopwatchList.Name = "StopwatchList";
            this.StopwatchList.Size = new System.Drawing.Size(220, 172);
            this.StopwatchList.TabIndex = 21;
            this.StopwatchList.UseCompatibleStateImageBehavior = false;
            this.StopwatchList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // timerS
            // 
            this.timerS.Interval = 1000;
            this.timerS.Tick += new System.EventHandler(this.timerS_Tick);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(339, 377);
            this.Controls.Add(this.StopwatchList);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.startStopwatchButton);
            this.Controls.Add(this.colonLabe2);
            this.Controls.Add(this.colonLabe1);
            this.Controls.Add(this.secTimerLabel);
            this.Controls.Add(this.minTimerLabel);
            this.Controls.Add(this.hrTimerLabel);
            this.Name = "Stopwatch";
            this.Text = "Stopwatch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stopwatch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label colonLabe2;
        private System.Windows.Forms.Label colonLabe1;
        private System.Windows.Forms.Label secTimerLabel;
        private System.Windows.Forms.Label minTimerLabel;
        private System.Windows.Forms.Label hrTimerLabel;
        private System.Windows.Forms.Button startStopwatchButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.ListView StopwatchList;
        private System.Windows.Forms.Timer timerS;
    }
}