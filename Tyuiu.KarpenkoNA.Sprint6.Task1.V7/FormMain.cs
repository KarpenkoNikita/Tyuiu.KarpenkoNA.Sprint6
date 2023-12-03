using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KarpenkoNA.Sprint6.Task1.V7.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task1.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KNA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KNA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KNA.Text = "";
                textBoxResult_KNA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KNA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_KNA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_KNA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KNA.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Карпенко Никита Андреевич", "Сообщение");
        }
    }
}
