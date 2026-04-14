namespace LR4
{
    partial class AddBooking
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
            this.SuspendLayout();
            // 
            // AddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 313);
            this.Name = "AddBooking";
            this.Text = "AddBooking";
            this.ResumeLayout(false);

            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.numRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(120, 20);
            this.txtFullName.Size = new System.Drawing.Size(200, 22);
            this.txtFullName.Name = "txtFullName";

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(120, 60);
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.Name = "txtPhone";

            // dtpCheckIn
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(120, 100);
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 22);
            this.dtpCheckIn.Name = "dtpCheckIn";

            // dtpCheckOut
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(120, 140);
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 22);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Value = System.DateTime.Now.AddDays(1);

            // numRoomNumber
            this.numRoomNumber.Location = new System.Drawing.Point(120, 180);
            this.numRoomNumber.Minimum = 1;
            this.numRoomNumber.Maximum = 500;
            this.numRoomNumber.Size = new System.Drawing.Size(200, 22);
            this.numRoomNumber.Name = "numRoomNumber";

            // btnSave
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(120, 230);
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Location = new System.Drawing.Point(230, 230);
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Добавить элементы на форму (в конец Controls)
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numRoomNumber);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFullName);

        }

        #endregion
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.NumericUpDown numRoomNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}