namespace TestFileStorage
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogLabel = new System.Windows.Forms.Label();
            this.PasLabel = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.PasswTextBox = new System.Windows.Forms.TextBox();
            this.RegistrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLabel.Location = new System.Drawing.Point(77, 70);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(183, 24);
            this.LogLabel.TabIndex = 0;
            this.LogLabel.Text = "Придумайте логин:";
            // 
            // PasLabel
            // 
            this.PasLabel.AutoSize = true;
            this.PasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasLabel.Location = new System.Drawing.Point(64, 123);
            this.PasLabel.Name = "PasLabel";
            this.PasLabel.Size = new System.Drawing.Size(195, 24);
            this.PasLabel.TabIndex = 1;
            this.PasLabel.Text = "Придумайте пароль:";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(261, 75);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(145, 20);
            this.LogTextBox.TabIndex = 2;
            // 
            // PasswTextBox
            // 
            this.PasswTextBox.Location = new System.Drawing.Point(261, 127);
            this.PasswTextBox.Name = "PasswTextBox";
            this.PasswTextBox.Size = new System.Drawing.Size(145, 20);
            this.PasswTextBox.TabIndex = 3;
            // 
            // RegistrButton
            // 
            this.RegistrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrButton.Location = new System.Drawing.Point(261, 234);
            this.RegistrButton.Name = "RegistrButton";
            this.RegistrButton.Size = new System.Drawing.Size(220, 50);
            this.RegistrButton.TabIndex = 4;
            this.RegistrButton.Text = "Зарегестрироваться";
            this.RegistrButton.UseVisualStyleBackColor = true;
            this.RegistrButton.Click += new System.EventHandler(this.RegistrButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 349);
            this.Controls.Add(this.RegistrButton);
            this.Controls.Add(this.PasswTextBox);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.PasLabel);
            this.Controls.Add(this.LogLabel);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label PasLabel;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.TextBox PasswTextBox;
        private System.Windows.Forms.Button RegistrButton;
    }
}