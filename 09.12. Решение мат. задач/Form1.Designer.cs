namespace _09._12._Решение_мат._задач
{
    partial class Form_ex_sp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ex_sp));
            btnSolve = new Button();
            listBoxTasks = new ListBox();
            btnSchedule = new Button();
            SuspendLayout();
            // 
            // btnSolve
            // 
            btnSolve.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSolve.Location = new Point(399, 121);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(225, 50);
            btnSolve.TabIndex = 0;
            btnSolve.Text = "Решить задачу";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.Font = new Font("Trebuchet MS", 10.75F, FontStyle.Bold);
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.Location = new Point(45, 33);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(298, 328);
            listBoxTasks.TabIndex = 1;
            // 
            // btnSchedule
            // 
            btnSchedule.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSchedule.Location = new Point(399, 205);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(225, 50);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Построить график";
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // Form_ex_sp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(670, 404);
            Controls.Add(btnSchedule);
            Controls.Add(listBoxTasks);
            Controls.Add(btnSolve);
            Name = "Form_ex_sp";
            Text = "Математические задачи";
            Load += Form_ex_sp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSolve;
        private ListBox listBoxTasks;
        private Button btnSchedule;
    }
}
