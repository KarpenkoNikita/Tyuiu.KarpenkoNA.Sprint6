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
using Tyuiu.KarpenkoNA.Sprint6.Task5.V5.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task5.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\duplo\source\repos\Tyuiu.KarpenkoNA.Sprint6\Tyuiu.KarpenkoNA.Sprint6.Task5.V5\bin\Debug\OutPutFileTask5V5.txt";

        

        private void buttonDone_KNA_Click(object sender, EventArgs e)
        {
            dataGridViewDone_KNA.ColumnCount = 2;
            dataGridViewDone_KNA.Columns[0].Width = 20;
            dataGridViewDone_KNA.Columns[1].Width = 50;

            this.chartDiag_KNA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_KNA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_KNA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewDone_KNA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_KNA.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_KNA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-2 Карпенко Никита Андреевич", "Сообщение");
        }
    }
}
