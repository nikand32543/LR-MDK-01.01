namespace NewTaskWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.RichTextBoxPanel = new System.Windows.Forms.Panel();
            this.statisticRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CountdownTime = new System.Windows.Forms.DateTimePicker();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelCount = new System.Windows.Forms.Label();
            this.RichTextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(150, 167);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(353, 31);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Введите число от 1 до 100:";
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(324, 226);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(129, 40);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(509, 164);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 38);
            this.InputTextBox.TabIndex = 2;
            // 
            // RichTextBoxPanel
            // 
            this.RichTextBoxPanel.Controls.Add(this.statisticRichTextBox);
            this.RichTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RichTextBoxPanel.Location = new System.Drawing.Point(0, 286);
            this.RichTextBoxPanel.Name = "RichTextBoxPanel";
            this.RichTextBoxPanel.Size = new System.Drawing.Size(783, 100);
            this.RichTextBoxPanel.TabIndex = 3;
            // 
            // statisticRichTextBox
            // 
            this.statisticRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.statisticRichTextBox.Location = new System.Drawing.Point(0, 4);
            this.statisticRichTextBox.Name = "statisticRichTextBox";
            this.statisticRichTextBox.Size = new System.Drawing.Size(783, 96);
            this.statisticRichTextBox.TabIndex = 0;
            this.statisticRichTextBox.Text = "";
            // 
            // CountdownTime
            // 
            this.CountdownTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountdownTime.CustomFormat = "mm:ss";
            this.CountdownTime.Enabled = false;
            this.CountdownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountdownTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.CountdownTime.Location = new System.Drawing.Point(324, 61);
            this.CountdownTime.Name = "CountdownTime";
            this.CountdownTime.Size = new System.Drawing.Size(138, 38);
            this.CountdownTime.TabIndex = 4;
            this.CountdownTime.Value = new System.DateTime(2026, 1, 20, 0, 1, 0, 0);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCount.Location = new System.Drawing.Point(279, 111);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(224, 31);
            this.LabelCount.TabIndex = 5;
            this.LabelCount.Text = "обратный отсчёт";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 386);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.CountdownTime);
            this.Controls.Add(this.RichTextBoxPanel);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.InfoLabel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Угадай число";
            this.RichTextBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Panel RichTextBoxPanel;
        private System.Windows.Forms.DateTimePicker CountdownTime;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.RichTextBox statisticRichTextBox;
    }
}

