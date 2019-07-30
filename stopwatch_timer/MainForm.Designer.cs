namespace stopwatch_timer {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.StopwatchButton = new System.Windows.Forms.Button();
            this.TimerButton = new System.Windows.Forms.Button();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StopwatchButton
            // 
            this.StopwatchButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopwatchButton.Location = new System.Drawing.Point(58, 70);
            this.StopwatchButton.Name = "StopwatchButton";
            this.StopwatchButton.Size = new System.Drawing.Size(148, 48);
            this.StopwatchButton.TabIndex = 0;
            this.StopwatchButton.Text = "Stopwatch";
            this.StopwatchButton.UseVisualStyleBackColor = true;
            this.StopwatchButton.Click += new System.EventHandler(this.StopwatchButton_Click);
            // 
            // TimerButton
            // 
            this.TimerButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerButton.Location = new System.Drawing.Point(58, 137);
            this.TimerButton.Name = "TimerButton";
            this.TimerButton.Size = new System.Drawing.Size(148, 48);
            this.TimerButton.TabIndex = 1;
            this.TimerButton.Text = "Timer";
            this.TimerButton.UseVisualStyleBackColor = true;
            this.TimerButton.Click += new System.EventHandler(this.TimerButton_Click);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLabel.Location = new System.Drawing.Point(52, 21);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(154, 33);
            this.chooseLabel.TabIndex = 2;
            this.chooseLabel.Text = "Please, choose:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(262, 232);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.TimerButton);
            this.Controls.Add(this.StopwatchButton);
            this.Name = "MainForm";
            this.Text = "Clock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StopwatchButton;
        private System.Windows.Forms.Button TimerButton;
        private System.Windows.Forms.Label chooseLabel;
    }
}

