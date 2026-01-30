namespace Variant_4
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
            this.MedicinesListBox = new System.Windows.Forms.ListBox();
            this.MedPictureBox = new System.Windows.Forms.PictureBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.QuantityLable = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.ExpirationDateTextBox = new System.Windows.Forms.TextBox();
            this.SupplierTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicinesListBox
            // 
            this.MedicinesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MedicinesListBox.FormattingEnabled = true;
            this.MedicinesListBox.Location = new System.Drawing.Point(0, 0);
            this.MedicinesListBox.Name = "MedicinesListBox";
            this.MedicinesListBox.Size = new System.Drawing.Size(128, 450);
            this.MedicinesListBox.TabIndex = 0;
            // 
            // MedPictureBox
            // 
            this.MedPictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MedPictureBox.Location = new System.Drawing.Point(432, 0);
            this.MedPictureBox.Name = "MedPictureBox";
            this.MedPictureBox.Size = new System.Drawing.Size(368, 450);
            this.MedPictureBox.TabIndex = 1;
            this.MedPictureBox.TabStop = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(144, 101);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(97, 20);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Стоимость:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(144, 137);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(135, 20);
            this.ManufacturerLabel.TabIndex = 3;
            this.ManufacturerLabel.Text = "Производитель:";
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(144, 172);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(125, 20);
            this.ExpirationDateLabel.TabIndex = 4;
            this.ExpirationDateLabel.Text = "Срок годности:";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplierLabel.Location = new System.Drawing.Point(144, 212);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(99, 20);
            this.SupplierLabel.TabIndex = 5;
            this.SupplierLabel.Text = "Поставщик:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(189, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 26);
            this.textBox1.TabIndex = 6;
            // 
            // QuantityLable
            // 
            this.QuantityLable.AutoSize = true;
            this.QuantityLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLable.Location = new System.Drawing.Point(185, 264);
            this.QuantityLable.Name = "QuantityLable";
            this.QuantityLable.Size = new System.Drawing.Size(100, 20);
            this.QuantityLable.TabIndex = 7;
            this.QuantityLable.Text = "Количество";
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(201, 365);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(122, 44);
            this.OrderButton.TabIndex = 8;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(134, 12);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.GroupComboBox.TabIndex = 9;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(247, 101);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostTextBox.TabIndex = 10;
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Location = new System.Drawing.Point(285, 137);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ManufacturerTextBox.TabIndex = 11;
            // 
            // ExpirationDateTextBox
            // 
            this.ExpirationDateTextBox.Location = new System.Drawing.Point(275, 174);
            this.ExpirationDateTextBox.Name = "ExpirationDateTextBox";
            this.ExpirationDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExpirationDateTextBox.TabIndex = 12;
            // 
            // SupplierTextBox
            // 
            this.SupplierTextBox.Location = new System.Drawing.Point(249, 212);
            this.SupplierTextBox.Name = "SupplierTextBox";
            this.SupplierTextBox.Size = new System.Drawing.Size(100, 20);
            this.SupplierTextBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupplierTextBox);
            this.Controls.Add(this.ExpirationDateTextBox);
            this.Controls.Add(this.ManufacturerTextBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.QuantityLable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ExpirationDateLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.MedPictureBox);
            this.Controls.Add(this.MedicinesListBox);
            this.Name = "MainForm";
            this.Text = "Лекарственные средства";
            ((System.ComponentModel.ISupportInitialize)(this.MedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MedicinesListBox;
        private System.Windows.Forms.PictureBox MedPictureBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.Label SupplierLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label QuantityLable;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox ExpirationDateTextBox;
        private System.Windows.Forms.TextBox SupplierTextBox;
    }
}

