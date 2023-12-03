using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KarpenkoNA.Sprint6.Task2.V26.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KNA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KNA.Text);
                

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KNA.Titles.Add("График функции");

                this.chartFunction_KNA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KNA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len; i++)
                {
                    this.dataGridViewFunction_KNA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_KNA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KNA.BackColor = Color.Red;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KNA.BackColor = Color.Blue;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KNA.BackColor = Color.Green;
        }

        private void buttonHelp_KNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-2 Карпенко Никита Андреевич", "Сообщение");
        }
    }
}
