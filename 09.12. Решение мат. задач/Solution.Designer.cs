namespace _09._12._Решение_мат._задач
{
    partial class Solution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solution));
            btnCheckAnswer = new Button();
            lblTaskDescription = new Label();
            txtAnswer = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnCheckAnswer
            // 
            btnCheckAnswer.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            btnCheckAnswer.Location = new Point(470, 169);
            btnCheckAnswer.Name = "btnCheckAnswer";
            btnCheckAnswer.Size = new Size(201, 59);
            btnCheckAnswer.TabIndex = 0;
            btnCheckAnswer.Text = "Проверить ответ";
            btnCheckAnswer.UseVisualStyleBackColor = true;
            btnCheckAnswer.Click += btnCheckAnswer_Click;
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.BackColor = Color.Transparent;
            lblTaskDescription.BorderStyle = BorderStyle.FixedSingle;
            lblTaskDescription.Font = new Font("Trebuchet MS", 20.75F, FontStyle.Bold);
            lblTaskDescription.ForeColor = SystemColors.Control;
            lblTaskDescription.Image = Properties.Resources._930;
            lblTaskDescription.Location = new Point(26, 94);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(2, 38);
            lblTaskDescription.TabIndex = 1;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold);
            txtAnswer.Location = new Point(26, 182);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(338, 37);
            txtAnswer.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Trebuchet MS", 20.75F, FontStyle.Bold);
            lblResult.ForeColor = SystemColors.Control;
            lblResult.Image = Properties.Resources._930;
            lblResult.Location = new Point(37, 281);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 36);
            lblResult.TabIndex = 3;
            // 
            // Solution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(683, 403);
            Controls.Add(lblResult);
            Controls.Add(txtAnswer);
            Controls.Add(lblTaskDescription);
            Controls.Add(btnCheckAnswer);
            Name = "Solution";
            Text = "Solution";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheckAnswer;
        private Label lblTaskDescription;
        private TextBox txtAnswer;
        private Label lblResult;
    }
}