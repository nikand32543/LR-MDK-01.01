namespace LiveChart
{
    partial class CinemaForm
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
            this.ListBoxPanel = new System.Windows.Forms.Panel();
            this.CinemaListBox = new System.Windows.Forms.ListBox();
            this.PieChartPanel = new System.Windows.Forms.Panel();
            this.CartesianChartPanel = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.ListBoxPanel.SuspendLayout();
            this.PieChartPanel.SuspendLayout();
            this.CartesianChartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxPanel
            // 
            this.ListBoxPanel.Controls.Add(this.CinemaListBox);
            this.ListBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPanel.Name = "ListBoxPanel";
            this.ListBoxPanel.Size = new System.Drawing.Size(132, 450);
            this.ListBoxPanel.TabIndex = 0;
            // 
            // CinemaListBox
            // 
            this.CinemaListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CinemaListBox.FormattingEnabled = true;
            this.CinemaListBox.Location = new System.Drawing.Point(0, 0);
            this.CinemaListBox.Name = "CinemaListBox";
            this.CinemaListBox.Size = new System.Drawing.Size(132, 450);
            this.CinemaListBox.TabIndex = 0;
            // 
            // PieChartPanel
            // 
            this.PieChartPanel.Controls.Add(this.pieChart1);
            this.PieChartPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PieChartPanel.Location = new System.Drawing.Point(619, 0);
            this.PieChartPanel.Name = "PieChartPanel";
            this.PieChartPanel.Size = new System.Drawing.Size(181, 450);
            this.PieChartPanel.TabIndex = 2;
            // 
            // CartesianChartPanel
            // 
            this.CartesianChartPanel.Controls.Add(this.cartesianChart1);
            this.CartesianChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianChartPanel.Location = new System.Drawing.Point(132, 0);
            this.CartesianChartPanel.Name = "CartesianChartPanel";
            this.CartesianChartPanel.Size = new System.Drawing.Size(487, 450);
            this.CartesianChartPanel.TabIndex = 3;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(487, 450);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(181, 450);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // CinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CartesianChartPanel);
            this.Controls.Add(this.PieChartPanel);
            this.Controls.Add(this.ListBoxPanel);
            this.Name = "CinemaForm";
            this.Text = "Продажи билетов";
            this.ListBoxPanel.ResumeLayout(false);
            this.PieChartPanel.ResumeLayout(false);
            this.CartesianChartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListBoxPanel;
        private System.Windows.Forms.ListBox CinemaListBox;
        private System.Windows.Forms.Panel PieChartPanel;
        private System.Windows.Forms.Panel CartesianChartPanel;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}

