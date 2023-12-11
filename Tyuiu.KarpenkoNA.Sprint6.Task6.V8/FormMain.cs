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
using Tyuiu.KarpenkoNA.Sprint6.Task6.V8.Lib;

namespace Tyuiu.KarpenkoNA.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_KNA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KNA.ShowDialog();
            openFilePath = openFileDialogTask_KNA.FileName;
            textBoxVvod_KNA.Text = File.ReadAllText(openFilePath);
            groupBoxVvod_KNA.Text = groupBoxVvod_KNA.Text + " " + openFileDialogTask_KNA.FileName;
            buttonDone_KNA.Enabled = true;
        }

        private void buttonDone_KNA_Click(object sender, EventArgs e)
        {
            string str = "z";
            textBoxDone_KNA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_KNA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
