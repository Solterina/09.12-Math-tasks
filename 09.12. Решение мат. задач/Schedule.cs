using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _09._12._Решение_мат._задач;
public partial class Schedule : Form
{

    private string ScheduleTask;
    private double correctAnsver;

    public Schedule()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int x = int.Parse(textX.Text);
        int y = int.Parse(textY.Text);

        chart.Series.Clear();
        chart.Series.Add("Line");
        chart.Series["Line"].Points.AddXY(0, 0);
        chart.Series["Line"].Points.AddXY(x, y);
        chart.Series["Line"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
    }
}
