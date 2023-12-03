using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KarpenkoNA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task3.V17
{
    public partial class FormMain_KNA : Form
    {
        public FormMain_KNA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { 22, 32, -16, 24, 27 },
                                          { 3, -20, 24, -20, 25 },
                                          { 21, 17, -8, -19, 17 },
                                          { 8, 22, 28, 27, 19 },
                                          { 11, 20, 12, 27, 29 } };

        private void buttonResult_KNA_Click(object sender, EventArgs e)
        {
            
            textBoxResult_KNA.Text = Convert.ToString(ds.Calculate(mtrx));
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                   
                    textBoxResult_KNA.AppendText($"{mtrx[i, j]} \t");
                }
                textBoxResult_KNA.AppendText(Environment.NewLine);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_KNA.ColumnCount = columns;
            dataGridViewMatrix_KNA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KNA.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KNA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-2 Карпенко Никита Андреевич", "Сообщение");
        }
    }
}
