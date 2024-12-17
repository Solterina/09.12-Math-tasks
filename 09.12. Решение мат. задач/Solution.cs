using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09._12._Решение_мат._задач;

public partial class Solution : Form
{   
    private string selectedTask;
    private double correctAnsver;

    public Solution(string task)
    {
        InitializeComponent();
        selectedTask = task;
        ShowTask();
    }
    private void ShowTask()
    {
        switch (selectedTask)
        {
            case "Нахождение суммы двух чисел":
                lblTaskDescription.Text = "Найдите сумму 45 и 78.";
                correctAnsver = 45 + 78;
                break;
            case "Нахождение разности двух чисел":
                lblTaskDescription.Text = "Найдите разность 123 и 57.";
                correctAnsver = 123 - 7;
                break; 
            case "Умножение чисел":
                lblTaskDescription.Text = "Найдите произведение 9 и 8.";
                correctAnsver = 9 * 8;
                break;
            case "Дeление с остатком":
                lblTaskDescription.Text = "Найдите остаток от деления 37 на 5.";
                correctAnsver = 37 % 5;
                break;
            case "Нахождение площади квадрата":
                lblTaskDescription.Text = "Найдите площадь квадрата со стороной 12.";
                correctAnsver = 12 * 12;
                break;
            case "Возведение числа в степень":
                lblTaskDescription.Text = "Возведите 7 в квадрат.";
                correctAnsver = 7 * 7;
                break;
            case "Возведение числа в куб":
                lblTaskDescription.Text = "Возведите 4 в куб.";
                correctAnsver = 4 * 4 * 4;
                break;
            case "Деление двух чисел":
                lblTaskDescription.Text = "Найдите разность 20 и 5.";
                correctAnsver = 20 / 5;
                break;
            case "Нахождение суммы трех чисел":
                lblTaskDescription.Text = "Найдите сумму 20, 2 и 4.";
                correctAnsver = 20 + 2 + 4;
                break;
            case "Умножение трех чисел":
                lblTaskDescription.Text = "Найдите остаток от деления 7, 4 и 5.";
                correctAnsver = 7 * 4 * 5;
                break;
        }
    }

    private void btnCheckAnswer_Click(object sender, EventArgs e)
    {
        double userAnswer;

        if (double.TryParse(txtAnswer.Text, out userAnswer))
        {
            if (Math.Abs(userAnswer - correctAnsver) < 0.0001)
            {
                lblResult.Text = "Ответ верный!";
                lblResult.ForeColor = Color.White;
            }
            else
            {
                lblResult.Text = "Ответ не верный!";
                lblResult.ForeColor = Color.White;
            }
        }
        else
        {
            lblResult.Text = "Пожалуйста, введите числовой ответ.";
            lblResult.ForeColor = Color.White;
        }
    }

}


