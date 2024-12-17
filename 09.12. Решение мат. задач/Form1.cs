namespace _09._12._Решение_мат._задач
{
    public partial class Form_ex_sp : Form
    {
        public Form_ex_sp()
        {
            InitializeComponent();
        }

        private void Form_ex_sp_Load(object sender, EventArgs e)
        {
            listBoxTasks.Items.Add("Нахождение суммы двух чисел");
            listBoxTasks.Items.Add("Нахождение разности двух чисел");
            listBoxTasks.Items.Add("Умножение чисел");
            listBoxTasks.Items.Add("Дeление с остатком");
            listBoxTasks.Items.Add("Нахождение площади квадрата");
            listBoxTasks.Items.Add("Возведение числа в степень");
            listBoxTasks.Items.Add("Возведение числа в куб");
            listBoxTasks.Items.Add("Деление двух чисел");
            listBoxTasks.Items.Add("Нахождение суммы трех чисел");
            listBoxTasks.Items.Add("Умножение трех чисел");
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                string selectedTask = listBoxTasks.SelectedItem.ToString();
                Solution taskForm = new Solution(selectedTask);
                taskForm.Show();
            }
            else
            {
                MessageBox.Show("Выберите задачу из списка.");
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            var schudule = new Schedule();
            schudule.Show();
        }   
    }
}
