using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KarpenkoNA.Sprint6.Task7.V30.Lib;
using System.IO;

namespace Tyuiu.KarpenkoNA.Sprint6.Task7.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridIn_KNA.ColumnCount = 50;
            dataGridOut_KNA.ColumnCount = 50;

            dataGridIn_KNA.RowCount = 50;
            dataGridOut_KNA.RowCount = 50;
        }

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_KNA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KNA.ShowDialog();
            openFilePath = openFileDialogTask_KNA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridIn_KNA.ColumnCount = columns;
            dataGridIn_KNA.RowCount = rows;
            dataGridOut_KNA.RowCount = rows;
            dataGridOut_KNA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridIn_KNA.Columns[i].Width = 25;
                dataGridOut_KNA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridIn_KNA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KNA.Enabled = true;
        }

        private void buttonDone_KNA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridOut_KNA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KNA.Enabled = true;
        }

        private void buttonSave_KNA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KNA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KNA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KNA.ShowDialog();

            string path = saveFileDialogMatrix_KNA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridOut_KNA.RowCount;
            int columns = dataGridOut_KNA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridOut_KNA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridOut_KNA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_KNA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_KNA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KNA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDoIt_KNA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KNA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_KNA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KNA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KNA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KNA.ToolTipTitle = "Справка";
        }
    }
}
