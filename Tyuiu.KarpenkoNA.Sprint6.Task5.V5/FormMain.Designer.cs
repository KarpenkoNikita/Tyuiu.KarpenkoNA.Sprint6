
namespace Tyuiu.KarpenkoNA.Sprint6.Task5.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelUP_KNA = new System.Windows.Forms.Panel();
            this.buttonHelp_KNA = new System.Windows.Forms.Button();
            this.buttonOpen_KNA = new System.Windows.Forms.Button();
            this.buttonDone_KNA = new System.Windows.Forms.Button();
            this.groupBoxUslovie_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_KNA = new System.Windows.Forms.TextBox();
            this.panelLeft_KNA = new System.Windows.Forms.Panel();
            this.groupBoxDone_KNA = new System.Windows.Forms.GroupBox();
            this.dataGridViewDone_KNA = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelFill_KNA = new System.Windows.Forms.Panel();
            this.chartDiag_KNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelUP_KNA.SuspendLayout();
            this.groupBoxUslovie_KNA.SuspendLayout();
            this.panelLeft_KNA.SuspendLayout();
            this.groupBoxDone_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone_KNA)).BeginInit();
            this.panelFill_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_KNA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUP_KNA
            // 
            this.panelUP_KNA.Controls.Add(this.buttonHelp_KNA);
            this.panelUP_KNA.Controls.Add(this.buttonOpen_KNA);
            this.panelUP_KNA.Controls.Add(this.buttonDone_KNA);
            this.panelUP_KNA.Controls.Add(this.groupBoxUslovie_KNA);
            this.panelUP_KNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUP_KNA.Location = new System.Drawing.Point(0, 0);
            this.panelUP_KNA.Name = "panelUP_KNA";
            this.panelUP_KNA.Padding = new System.Windows.Forms.Padding(5);
            this.panelUP_KNA.Size = new System.Drawing.Size(831, 117);
            this.panelUP_KNA.TabIndex = 0;
            // 
            // buttonHelp_KNA
            // 
            this.buttonHelp_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KNA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_KNA.Location = new System.Drawing.Point(701, 21);
            this.buttonHelp_KNA.Name = "buttonHelp_KNA";
            this.buttonHelp_KNA.Size = new System.Drawing.Size(95, 63);
            this.buttonHelp_KNA.TabIndex = 3;
            this.buttonHelp_KNA.Text = "Справка";
            this.buttonHelp_KNA.UseVisualStyleBackColor = false;
            this.buttonHelp_KNA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonOpen_KNA
            // 
            this.buttonOpen_KNA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_KNA.Location = new System.Drawing.Point(587, 21);
            this.buttonOpen_KNA.Name = "buttonOpen_KNA";
            this.buttonOpen_KNA.Size = new System.Drawing.Size(95, 63);
            this.buttonOpen_KNA.TabIndex = 2;
            this.buttonOpen_KNA.Text = "Открыть файл";
            this.buttonOpen_KNA.UseVisualStyleBackColor = false;
            this.buttonOpen_KNA.Click += new System.EventHandler(this.buttonOpen_KNA_Click);
            // 
            // buttonDone_KNA
            // 
            this.buttonDone_KNA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_KNA.Location = new System.Drawing.Point(476, 21);
            this.buttonDone_KNA.Name = "buttonDone_KNA";
            this.buttonDone_KNA.Size = new System.Drawing.Size(95, 63);
            this.buttonDone_KNA.TabIndex = 1;
            this.buttonDone_KNA.Text = "Выполнить";
            this.buttonDone_KNA.UseVisualStyleBackColor = false;
            this.buttonDone_KNA.Click += new System.EventHandler(this.buttonDone_KNA_Click);
            // 
            // groupBoxUslovie_KNA
            // 
            this.groupBoxUslovie_KNA.Controls.Add(this.textBoxUslovie_KNA);
            this.groupBoxUslovie_KNA.Location = new System.Drawing.Point(10, 11);
            this.groupBoxUslovie_KNA.Name = "groupBoxUslovie_KNA";
            this.groupBoxUslovie_KNA.Size = new System.Drawing.Size(460, 87);
            this.groupBoxUslovie_KNA.TabIndex = 0;
            this.groupBoxUslovie_KNA.TabStop = false;
            this.groupBoxUslovie_KNA.Text = "Условие:";
            // 
            // textBoxUslovie_KNA
            // 
            this.textBoxUslovie_KNA.Location = new System.Drawing.Point(14, 24);
            this.textBoxUslovie_KNA.Multiline = true;
            this.textBoxUslovie_KNA.Name = "textBoxUslovie_KNA";
            this.textBoxUslovie_KNA.ReadOnly = true;
            this.textBoxUslovie_KNA.Size = new System.Drawing.Size(431, 49);
            this.textBoxUslovie_KNA.TabIndex = 0;
            this.textBoxUslovie_KNA.Text = "Прочитать данные из файла InPutFileTask5V5.txt. Вывести в dataGridView\r\nзначения " +
    "кратные 2 и построить диаграмму по этим значениям.";
            // 
            // panelLeft_KNA
            // 
            this.panelLeft_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.panelLeft_KNA.Controls.Add(this.groupBoxDone_KNA);
            this.panelLeft_KNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KNA.Location = new System.Drawing.Point(0, 117);
            this.panelLeft_KNA.Name = "panelLeft_KNA";
            this.panelLeft_KNA.Size = new System.Drawing.Size(171, 444);
            this.panelLeft_KNA.TabIndex = 2;
            // 
            // groupBoxDone_KNA
            // 
            this.groupBoxDone_KNA.Controls.Add(this.dataGridViewDone_KNA);
            this.groupBoxDone_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDone_KNA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDone_KNA.Name = "groupBoxDone_KNA";
            this.groupBoxDone_KNA.Size = new System.Drawing.Size(171, 444);
            this.groupBoxDone_KNA.TabIndex = 0;
            this.groupBoxDone_KNA.TabStop = false;
            this.groupBoxDone_KNA.Text = "Вывод данных:";
            // 
            // dataGridViewDone_KNA
            // 
            this.dataGridViewDone_KNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDone_KNA.ColumnHeadersVisible = false;
            this.dataGridViewDone_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDone_KNA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDone_KNA.Name = "dataGridViewDone_KNA";
            this.dataGridViewDone_KNA.RowHeadersVisible = false;
            this.dataGridViewDone_KNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDone_KNA.Size = new System.Drawing.Size(165, 425);
            this.dataGridViewDone_KNA.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(171, 117);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 444);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelFill_KNA
            // 
            this.panelFill_KNA.Controls.Add(this.chartDiag_KNA);
            this.panelFill_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_KNA.Location = new System.Drawing.Point(174, 117);
            this.panelFill_KNA.Name = "panelFill_KNA";
            this.panelFill_KNA.Size = new System.Drawing.Size(657, 444);
            this.panelFill_KNA.TabIndex = 4;
            // 
            // chartDiag_KNA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDiag_KNA.ChartAreas.Add(chartArea2);
            this.chartDiag_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDiag_KNA.Legends.Add(legend2);
            this.chartDiag_KNA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_KNA.Name = "chartDiag_KNA";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDiag_KNA.Series.Add(series2);
            this.chartDiag_KNA.Size = new System.Drawing.Size(657, 444);
            this.chartDiag_KNA.TabIndex = 0;
            this.chartDiag_KNA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 561);
            this.Controls.Add(this.panelFill_KNA);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_KNA);
            this.Controls.Add(this.panelUP_KNA);
            this.MinimumSize = new System.Drawing.Size(847, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 5 | Карпенко Н. А.";
            this.panelUP_KNA.ResumeLayout(false);
            this.groupBoxUslovie_KNA.ResumeLayout(false);
            this.groupBoxUslovie_KNA.PerformLayout();
            this.panelLeft_KNA.ResumeLayout(false);
            this.groupBoxDone_KNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDone_KNA)).EndInit();
            this.panelFill_KNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_KNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUP_KNA;
        private System.Windows.Forms.Panel panelLeft_KNA;
        private System.Windows.Forms.GroupBox groupBoxUslovie_KNA;
        private System.Windows.Forms.TextBox textBoxUslovie_KNA;
        private System.Windows.Forms.GroupBox groupBoxDone_KNA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelFill_KNA;
        private System.Windows.Forms.Button buttonHelp_KNA;
        private System.Windows.Forms.Button buttonOpen_KNA;
        private System.Windows.Forms.Button buttonDone_KNA;
        private System.Windows.Forms.DataGridView dataGridViewDone_KNA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KNA;
    }
}

