
namespace Tyuiu.KarpenkoNA.Sprint6.Task4.V16
{
    partial class FormMain_KNA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxUslovie_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_KNA = new System.Windows.Forms.TextBox();
            this.groupBoxDone_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxDone_KNA = new System.Windows.Forms.TextBox();
            this.chartFunction_KNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxDannye_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxStart_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStop_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_KNA = new System.Windows.Forms.TextBox();
            this.buttonDone_KNA = new System.Windows.Forms.Button();
            this.buttonSave_KNA = new System.Windows.Forms.Button();
            this.buttonHelp_KNA = new System.Windows.Forms.Button();
            this.panelUP_KNA = new System.Windows.Forms.Panel();
            this.groupBoxUsl_KNA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_KNA.SuspendLayout();
            this.groupBoxDone_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KNA)).BeginInit();
            this.groupBoxDannye_KNA.SuspendLayout();
            this.panelUP_KNA.SuspendLayout();
            this.groupBoxUsl_KNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_KNA
            // 
            this.groupBoxUslovie_KNA.Controls.Add(this.textBoxUslovie_KNA);
            this.groupBoxUslovie_KNA.Location = new System.Drawing.Point(11, 18);
            this.groupBoxUslovie_KNA.Name = "groupBoxUslovie_KNA";
            this.groupBoxUslovie_KNA.Size = new System.Drawing.Size(530, 105);
            this.groupBoxUslovie_KNA.TabIndex = 0;
            this.groupBoxUslovie_KNA.TabStop = false;
            this.groupBoxUslovie_KNA.Text = "Условие:";
            // 
            // textBoxUslovie_KNA
            // 
            this.textBoxUslovie_KNA.Location = new System.Drawing.Point(10, 30);
            this.textBoxUslovie_KNA.Multiline = true;
            this.textBoxUslovie_KNA.Name = "textBoxUslovie_KNA";
            this.textBoxUslovie_KNA.ReadOnly = true;
            this.textBoxUslovie_KNA.Size = new System.Drawing.Size(485, 63);
            this.textBoxUslovie_KNA.TabIndex = 0;
            this.textBoxUslovie_KNA.Text = "Протабулировать функцию на заданном диапозоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл\r\nOutPutFileTask.txt по нажати" +
    "ю кнопки.";
            // 
            // groupBoxDone_KNA
            // 
            this.groupBoxDone_KNA.Controls.Add(this.textBoxDone_KNA);
            this.groupBoxDone_KNA.Location = new System.Drawing.Point(17, 133);
            this.groupBoxDone_KNA.Name = "groupBoxDone_KNA";
            this.groupBoxDone_KNA.Size = new System.Drawing.Size(280, 479);
            this.groupBoxDone_KNA.TabIndex = 1;
            this.groupBoxDone_KNA.TabStop = false;
            this.groupBoxDone_KNA.Text = "Вывод:";
            // 
            // textBoxDone_KNA
            // 
            this.textBoxDone_KNA.Location = new System.Drawing.Point(8, 21);
            this.textBoxDone_KNA.Multiline = true;
            this.textBoxDone_KNA.Name = "textBoxDone_KNA";
            this.textBoxDone_KNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDone_KNA.Size = new System.Drawing.Size(261, 445);
            this.textBoxDone_KNA.TabIndex = 0;
            // 
            // chartFunction_KNA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KNA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_KNA.Legends.Add(legend1);
            this.chartFunction_KNA.Location = new System.Drawing.Point(303, 133);
            this.chartFunction_KNA.Name = "chartFunction_KNA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KNA.Series.Add(series1);
            this.chartFunction_KNA.Size = new System.Drawing.Size(811, 466);
            this.chartFunction_KNA.TabIndex = 2;
            this.chartFunction_KNA.Text = "chart";
            title1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            this.chartFunction_KNA.Titles.Add(title1);
            // 
            // groupBoxDannye_KNA
            // 
            this.groupBoxDannye_KNA.Controls.Add(this.textBoxStopStep_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.textBoxStop_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.textBoxStartStep_KNA);
            this.groupBoxDannye_KNA.Controls.Add(this.textBoxStart_KNA);
            this.groupBoxDannye_KNA.Location = new System.Drawing.Point(552, 12);
            this.groupBoxDannye_KNA.Name = "groupBoxDannye_KNA";
            this.groupBoxDannye_KNA.Size = new System.Drawing.Size(264, 104);
            this.groupBoxDannye_KNA.TabIndex = 3;
            this.groupBoxDannye_KNA.TabStop = false;
            this.groupBoxDannye_KNA.Text = "Ввод данных";
            // 
            // textBoxStart_KNA
            // 
            this.textBoxStart_KNA.Location = new System.Drawing.Point(6, 32);
            this.textBoxStart_KNA.Name = "textBoxStart_KNA";
            this.textBoxStart_KNA.ReadOnly = true;
            this.textBoxStart_KNA.Size = new System.Drawing.Size(90, 20);
            this.textBoxStart_KNA.TabIndex = 0;
            this.textBoxStart_KNA.Text = "Старт шага:";
            // 
            // textBoxStartStep_KNA
            // 
            this.textBoxStartStep_KNA.Location = new System.Drawing.Point(6, 58);
            this.textBoxStartStep_KNA.Name = "textBoxStartStep_KNA";
            this.textBoxStartStep_KNA.Size = new System.Drawing.Size(90, 20);
            this.textBoxStartStep_KNA.TabIndex = 1;
            // 
            // textBoxStop_KNA
            // 
            this.textBoxStop_KNA.Location = new System.Drawing.Point(136, 32);
            this.textBoxStop_KNA.Name = "textBoxStop_KNA";
            this.textBoxStop_KNA.ReadOnly = true;
            this.textBoxStop_KNA.Size = new System.Drawing.Size(90, 20);
            this.textBoxStop_KNA.TabIndex = 2;
            this.textBoxStop_KNA.Text = "Конец шага:";
            // 
            // textBoxStopStep_KNA
            // 
            this.textBoxStopStep_KNA.Location = new System.Drawing.Point(136, 58);
            this.textBoxStopStep_KNA.Name = "textBoxStopStep_KNA";
            this.textBoxStopStep_KNA.Size = new System.Drawing.Size(90, 20);
            this.textBoxStopStep_KNA.TabIndex = 3;
            // 
            // buttonDone_KNA
            // 
            this.buttonDone_KNA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KNA.Location = new System.Drawing.Point(835, 36);
            this.buttonDone_KNA.Name = "buttonDone_KNA";
            this.buttonDone_KNA.Size = new System.Drawing.Size(85, 68);
            this.buttonDone_KNA.TabIndex = 4;
            this.buttonDone_KNA.Text = "Выполнить";
            this.buttonDone_KNA.UseVisualStyleBackColor = false;
            this.buttonDone_KNA.Click += new System.EventHandler(this.buttonDone_KNA_Click);
            // 
            // buttonSave_KNA
            // 
            this.buttonSave_KNA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave_KNA.Location = new System.Drawing.Point(926, 36);
            this.buttonSave_KNA.Name = "buttonSave_KNA";
            this.buttonSave_KNA.Size = new System.Drawing.Size(85, 68);
            this.buttonSave_KNA.TabIndex = 5;
            this.buttonSave_KNA.Text = "Сохранить";
            this.buttonSave_KNA.UseVisualStyleBackColor = false;
            this.buttonSave_KNA.Click += new System.EventHandler(this.buttonSave_KNA_Click);
            // 
            // buttonHelp_KNA
            // 
            this.buttonHelp_KNA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_KNA.Location = new System.Drawing.Point(1017, 36);
            this.buttonHelp_KNA.Name = "buttonHelp_KNA";
            this.buttonHelp_KNA.Size = new System.Drawing.Size(85, 68);
            this.buttonHelp_KNA.TabIndex = 6;
            this.buttonHelp_KNA.Text = "Справка";
            this.buttonHelp_KNA.UseVisualStyleBackColor = false;
            this.buttonHelp_KNA.Click += new System.EventHandler(this.buttonHelp_KNA_Click);
            // 
            // panelUP_KNA
            // 
            this.panelUP_KNA.Controls.Add(this.groupBoxUsl_KNA);
            this.panelUP_KNA.Controls.Add(this.buttonHelp_KNA);
            this.panelUP_KNA.Controls.Add(this.buttonSave_KNA);
            this.panelUP_KNA.Controls.Add(this.buttonDone_KNA);
            this.panelUP_KNA.Controls.Add(this.groupBoxDannye_KNA);
            this.panelUP_KNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUP_KNA.Location = new System.Drawing.Point(0, 0);
            this.panelUP_KNA.Name = "panelUP_KNA";
            this.panelUP_KNA.Size = new System.Drawing.Size(1118, 116);
            this.panelUP_KNA.TabIndex = 7;
            // 
            // groupBoxUsl_KNA
            // 
            this.groupBoxUsl_KNA.Controls.Add(this.textBox1);
            this.groupBoxUsl_KNA.Location = new System.Drawing.Point(9, 12);
            this.groupBoxUsl_KNA.Name = "groupBoxUsl_KNA";
            this.groupBoxUsl_KNA.Size = new System.Drawing.Size(531, 91);
            this.groupBoxUsl_KNA.TabIndex = 7;
            this.groupBoxUsl_KNA.TabStop = false;
            this.groupBoxUsl_KNA.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(509, 70);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию на заданном диапозоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл\r\nOutPutFileTask.txt по нажати" +
    "ю кнопки.";
            // 
            // FormMain_KNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 631);
            this.Controls.Add(this.panelUP_KNA);
            this.Controls.Add(this.chartFunction_KNA);
            this.Controls.Add(this.groupBoxDone_KNA);
            this.Controls.Add(this.groupBoxUslovie_KNA);
            this.MinimumSize = new System.Drawing.Size(1134, 670);
            this.Name = "FormMain_KNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 16 | Карпенко Н. А.";
            this.groupBoxUslovie_KNA.ResumeLayout(false);
            this.groupBoxUslovie_KNA.PerformLayout();
            this.groupBoxDone_KNA.ResumeLayout(false);
            this.groupBoxDone_KNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KNA)).EndInit();
            this.groupBoxDannye_KNA.ResumeLayout(false);
            this.groupBoxDannye_KNA.PerformLayout();
            this.panelUP_KNA.ResumeLayout(false);
            this.groupBoxUsl_KNA.ResumeLayout(false);
            this.groupBoxUsl_KNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_KNA;
        private System.Windows.Forms.TextBox textBoxUslovie_KNA;
        private System.Windows.Forms.GroupBox groupBoxDone_KNA;
        private System.Windows.Forms.TextBox textBoxDone_KNA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KNA;
        private System.Windows.Forms.GroupBox groupBoxDannye_KNA;
        private System.Windows.Forms.TextBox textBoxStopStep_KNA;
        private System.Windows.Forms.TextBox textBoxStop_KNA;
        private System.Windows.Forms.TextBox textBoxStartStep_KNA;
        private System.Windows.Forms.TextBox textBoxStart_KNA;
        private System.Windows.Forms.Button buttonDone_KNA;
        private System.Windows.Forms.Button buttonSave_KNA;
        private System.Windows.Forms.Button buttonHelp_KNA;
        private System.Windows.Forms.Panel panelUP_KNA;
        private System.Windows.Forms.GroupBox groupBoxUsl_KNA;
        private System.Windows.Forms.TextBox textBox1;
    }
}

