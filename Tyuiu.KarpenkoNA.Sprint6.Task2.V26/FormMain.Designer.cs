
namespace Tyuiu.KarpenkoNA.Sprint6.Task2.V26
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_KNA = new System.Windows.Forms.TextBox();
            this.groupBoxDan_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStop0_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStart0_KNA = new System.Windows.Forms.TextBox();
            this.buttonDone_KNA = new System.Windows.Forms.Button();
            this.buttonHelp_KNA = new System.Windows.Forms.Button();
            this.groupBoxDone_KNA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_KNA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_KNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxUslovie_KNA.SuspendLayout();
            this.groupBoxDan_KNA.SuspendLayout();
            this.groupBoxDone_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KNA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_KNA
            // 
            this.groupBoxUslovie_KNA.Controls.Add(this.textBoxUslovie_KNA);
            this.groupBoxUslovie_KNA.Location = new System.Drawing.Point(13, 15);
            this.groupBoxUslovie_KNA.Name = "groupBoxUslovie_KNA";
            this.groupBoxUslovie_KNA.Size = new System.Drawing.Size(599, 312);
            this.groupBoxUslovie_KNA.TabIndex = 0;
            this.groupBoxUslovie_KNA.TabStop = false;
            this.groupBoxUslovie_KNA.Text = "Условие";
            // 
            // textBoxUslovie_KNA
            // 
            this.textBoxUslovie_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUslovie_KNA.Location = new System.Drawing.Point(11, 20);
            this.textBoxUslovie_KNA.Multiline = true;
            this.textBoxUslovie_KNA.Name = "textBoxUslovie_KNA";
            this.textBoxUslovie_KNA.ReadOnly = true;
            this.textBoxUslovie_KNA.Size = new System.Drawing.Size(449, 167);
            this.textBoxUslovie_KNA.TabIndex = 0;
            this.textBoxUslovie_KNA.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в DataGrindView" +
    " и построить график фунции.";
            // 
            // groupBoxDan_KNA
            // 
            this.groupBoxDan_KNA.Controls.Add(this.textBoxStopStep_KNA);
            this.groupBoxDan_KNA.Controls.Add(this.textBoxStartStep_KNA);
            this.groupBoxDan_KNA.Controls.Add(this.textBoxStop0_KNA);
            this.groupBoxDan_KNA.Controls.Add(this.textBoxStart0_KNA);
            this.groupBoxDan_KNA.Location = new System.Drawing.Point(12, 344);
            this.groupBoxDan_KNA.Name = "groupBoxDan_KNA";
            this.groupBoxDan_KNA.Size = new System.Drawing.Size(325, 87);
            this.groupBoxDan_KNA.TabIndex = 1;
            this.groupBoxDan_KNA.TabStop = false;
            this.groupBoxDan_KNA.Text = "Ввод данных";
            // 
            // textBoxStopStep_KNA
            // 
            this.textBoxStopStep_KNA.Location = new System.Drawing.Point(147, 54);
            this.textBoxStopStep_KNA.Name = "textBoxStopStep_KNA";
            this.textBoxStopStep_KNA.Size = new System.Drawing.Size(113, 20);
            this.textBoxStopStep_KNA.TabIndex = 3;
            // 
            // textBoxStartStep_KNA
            // 
            this.textBoxStartStep_KNA.Location = new System.Drawing.Point(6, 54);
            this.textBoxStartStep_KNA.Name = "textBoxStartStep_KNA";
            this.textBoxStartStep_KNA.Size = new System.Drawing.Size(113, 20);
            this.textBoxStartStep_KNA.TabIndex = 2;
            // 
            // textBoxStop0_KNA
            // 
            this.textBoxStop0_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStop0_KNA.Location = new System.Drawing.Point(147, 28);
            this.textBoxStop0_KNA.Name = "textBoxStop0_KNA";
            this.textBoxStop0_KNA.ReadOnly = true;
            this.textBoxStop0_KNA.Size = new System.Drawing.Size(113, 20);
            this.textBoxStop0_KNA.TabIndex = 1;
            this.textBoxStop0_KNA.Text = "Конец шага:";
            // 
            // textBoxStart0_KNA
            // 
            this.textBoxStart0_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStart0_KNA.Location = new System.Drawing.Point(6, 28);
            this.textBoxStart0_KNA.Name = "textBoxStart0_KNA";
            this.textBoxStart0_KNA.ReadOnly = true;
            this.textBoxStart0_KNA.Size = new System.Drawing.Size(113, 20);
            this.textBoxStart0_KNA.TabIndex = 0;
            this.textBoxStart0_KNA.Text = "Старт шага:";
            // 
            // buttonDone_KNA
            // 
            this.buttonDone_KNA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KNA.Location = new System.Drawing.Point(466, 355);
            this.buttonDone_KNA.Name = "buttonDone_KNA";
            this.buttonDone_KNA.Size = new System.Drawing.Size(146, 63);
            this.buttonDone_KNA.TabIndex = 2;
            this.buttonDone_KNA.Text = "Выполнить";
            this.buttonDone_KNA.UseVisualStyleBackColor = false;
            this.buttonDone_KNA.Click += new System.EventHandler(this.buttonResult_Click);
            this.buttonDone_KNA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone_KNA.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone_KNA.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // buttonHelp_KNA
            // 
            this.buttonHelp_KNA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_KNA.Location = new System.Drawing.Point(364, 355);
            this.buttonHelp_KNA.Name = "buttonHelp_KNA";
            this.buttonHelp_KNA.Size = new System.Drawing.Size(81, 62);
            this.buttonHelp_KNA.TabIndex = 3;
            this.buttonHelp_KNA.Text = "Справка";
            this.buttonHelp_KNA.UseVisualStyleBackColor = false;
            this.buttonHelp_KNA.Click += new System.EventHandler(this.buttonHelp_KNA_Click);
            // 
            // groupBoxDone_KNA
            // 
            this.groupBoxDone_KNA.Controls.Add(this.chartFunction_KNA);
            this.groupBoxDone_KNA.Controls.Add(this.dataGridViewFunction_KNA);
            this.groupBoxDone_KNA.Location = new System.Drawing.Point(654, 22);
            this.groupBoxDone_KNA.Name = "groupBoxDone_KNA";
            this.groupBoxDone_KNA.Size = new System.Drawing.Size(764, 408);
            this.groupBoxDone_KNA.TabIndex = 4;
            this.groupBoxDone_KNA.TabStop = false;
            this.groupBoxDone_KNA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_KNA
            // 
            this.dataGridViewFunction_KNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KNA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Fx});
            this.dataGridViewFunction_KNA.Location = new System.Drawing.Point(15, 19);
            this.dataGridViewFunction_KNA.Name = "dataGridViewFunction_KNA";
            this.dataGridViewFunction_KNA.RowHeadersVisible = false;
            this.dataGridViewFunction_KNA.Size = new System.Drawing.Size(125, 370);
            this.dataGridViewFunction_KNA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Fx
            // 
            this.Fx.HeaderText = "F(X)";
            this.Fx.Name = "Fx";
            this.Fx.ReadOnly = true;
            this.Fx.Width = 50;
            // 
            // chartFunction_KNA
            // 
            chartArea8.Name = "ChartArea1";
            this.chartFunction_KNA.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartFunction_KNA.Legends.Add(legend8);
            this.chartFunction_KNA.Location = new System.Drawing.Point(146, 19);
            this.chartFunction_KNA.Name = "chartFunction_KNA";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.IsVisibleInLegend = false;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartFunction_KNA.Series.Add(series8);
            this.chartFunction_KNA.Size = new System.Drawing.Size(607, 369);
            this.chartFunction_KNA.TabIndex = 1;
            this.chartFunction_KNA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 450);
            this.Controls.Add(this.groupBoxDone_KNA);
            this.Controls.Add(this.buttonHelp_KNA);
            this.Controls.Add(this.buttonDone_KNA);
            this.Controls.Add(this.groupBoxDan_KNA);
            this.Controls.Add(this.groupBoxUslovie_KNA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Карпенко Н. А.";
            this.groupBoxUslovie_KNA.ResumeLayout(false);
            this.groupBoxUslovie_KNA.PerformLayout();
            this.groupBoxDan_KNA.ResumeLayout(false);
            this.groupBoxDan_KNA.PerformLayout();
            this.groupBoxDone_KNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_KNA;
        private System.Windows.Forms.TextBox textBoxUslovie_KNA;
        private System.Windows.Forms.GroupBox groupBoxDan_KNA;
        private System.Windows.Forms.TextBox textBoxStopStep_KNA;
        private System.Windows.Forms.TextBox textBoxStartStep_KNA;
        private System.Windows.Forms.TextBox textBoxStop0_KNA;
        private System.Windows.Forms.TextBox textBoxStart0_KNA;
        private System.Windows.Forms.Button buttonDone_KNA;
        private System.Windows.Forms.Button buttonHelp_KNA;
        private System.Windows.Forms.GroupBox groupBoxDone_KNA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KNA;
    }
}

