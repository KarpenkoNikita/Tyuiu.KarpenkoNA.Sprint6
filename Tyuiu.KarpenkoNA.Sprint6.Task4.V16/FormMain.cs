using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using Tyuiu.KarpenkoNA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task4.V16
{
    public partial class FormMain_KNA : Form
    {
        public FormMain_KNA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_KNA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KNA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KNA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KNA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KNA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxDone_KNA.Text = "";

                chartFunction_KNA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_KNA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxDone_KNA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-2 Карпенко Никита Андреевич", "Сообщение");
        }

        private void buttonSave_KNA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxDone_KNA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
