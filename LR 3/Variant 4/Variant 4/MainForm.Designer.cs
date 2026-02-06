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
            this.QuantityLable = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicinesListBox
            // 
            this.MedicinesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MedicinesListBox.FormattingEnabled = true;
            this.MedicinesListBox.ItemHeight = 16;
            this.MedicinesListBox.Location = new System.Drawing.Point(0, 0);
            this.MedicinesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedicinesListBox.Name = "MedicinesListBox";
            this.MedicinesListBox.Size = new System.Drawing.Size(169, 554);
            this.MedicinesListBox.TabIndex = 0;
            // 
            // MedPictureBox
            // 
            this.MedPictureBox.Location = new System.Drawing.Point(463, 0);
            this.MedPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedPictureBox.Name = "MedPictureBox";
            this.MedPictureBox.Size = new System.Drawing.Size(604, 400);
            this.MedPictureBox.TabIndex = 1;
            this.MedPictureBox.TabStop = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(177, 89);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(125, 25);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Стоимость:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(177, 236);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(165, 25);
            this.ManufacturerLabel.TabIndex = 3;
            this.ManufacturerLabel.Text = "Производитель:";
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(177, 140);
            this.ExpirationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(154, 25);
            this.ExpirationDateLabel.TabIndex = 4;
            this.ExpirationDateLabel.Text = "Срок годности:";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplierLabel.Location = new System.Drawing.Point(177, 188);
            this.SupplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(123, 25);
            this.SupplierLabel.TabIndex = 5;
            this.SupplierLabel.Text = "Поставщик:";
            // 
            // QuantityLable
            // 
            this.QuantityLable.AutoSize = true;
            this.QuantityLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityLable.Location = new System.Drawing.Point(493, 436);
            this.QuantityLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLable.Name = "QuantityLable";
            this.QuantityLable.Size = new System.Drawing.Size(123, 25);
            this.QuantityLable.TabIndex = 7;
            this.QuantityLable.Text = "Количество";
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(864, 457);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(4);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(163, 54);
            this.OrderButton.TabIndex = 8;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(182, 13);
            this.GroupComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(160, 24);
            this.GroupComboBox.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(623, 439);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(182, 313);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 187);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(309, 96);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 16);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.QuantityLable);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ExpirationDateLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.MedPictureBox);
            this.Controls.Add(this.MedicinesListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label QuantityLable;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

