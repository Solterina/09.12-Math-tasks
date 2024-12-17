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
            txtX = new Label();
            txtY = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            btnBack = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(80, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 3;
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
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(124, 41);
            btnBack.TabIndex = 5;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.baee;
            ClientSize = new Size(669, 422);
            Controls.Add(btnBack);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Name = "Schedule";
            Text = "Schedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtX;
        private Label txtY;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button btnBack;
    }
}