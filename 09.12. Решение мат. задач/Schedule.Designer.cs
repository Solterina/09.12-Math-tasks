namespace _09._12._Решение_мат._задач
{
    partial class Schedule
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            txtX = new Label();
            txtY = new Label();
            textX = new TextBox();
            textY = new TextBox();
            button1 = new Button();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.BackColor = Color.Transparent;
            txtX.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            txtX.ForeColor = SystemColors.ControlLightLight;
            txtX.Location = new Point(38, 121);
            txtX.Name = "txtX";
            txtX.Size = new Size(36, 23);
            txtX.TabIndex = 0;
            txtX.Text = "X";
            // 
            // txtY
            // 
            txtY.BackColor = Color.Transparent;
            txtY.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            txtY.ForeColor = SystemColors.ControlLightLight;
            txtY.Location = new Point(38, 187);
            txtY.Name = "txtY";
            txtY.Size = new Size(36, 23);
            txtY.TabIndex = 1;
            txtY.Text = "Y";
            // 
            // textX
            // 
            textX.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Bold);
            textX.Location = new Point(80, 121);
            textX.Name = "textX";
            textX.Size = new Size(125, 27);
            textX.TabIndex = 2;
            // 
            // textY
            // 
            textY.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Bold);
            textY.Location = new Point(80, 187);
            textY.Name = "textY";
            textY.Size = new Size(125, 27);
            textY.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 12.75F, FontStyle.Bold);
            button1.Location = new Point(45, 262);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 4;
            button1.Text = "Построить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(280, 38);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(300, 300);
            chart.TabIndex = 6;
            chart.Text = "chart1";
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.baee;
            ClientSize = new Size(669, 422);
            Controls.Add(chart);
            Controls.Add(button1);
            Controls.Add(textY);
            Controls.Add(textX);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Name = "Schedule";
            Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtX;
        private Label txtY;
        private TextBox textX;
        private TextBox textY;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}