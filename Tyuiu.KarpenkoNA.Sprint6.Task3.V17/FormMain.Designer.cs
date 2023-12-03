
namespace Tyuiu.KarpenkoNA.Sprint6.Task3.V17
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
            this.groupBoxUslovie_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_KNA = new System.Windows.Forms.TextBox();
            this.groupBoxDone_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KNA = new System.Windows.Forms.TextBox();
            this.textBoxDone_KNA = new System.Windows.Forms.TextBox();
            this.buttonResult_KNA = new System.Windows.Forms.Button();
            this.buttonHelp_KNA = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_KNA = new System.Windows.Forms.DataGridView();
            this.groupBoxUslovie_KNA.SuspendLayout();
            this.groupBoxDone_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KNA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_KNA
            // 
            this.groupBoxUslovie_KNA.Controls.Add(this.dataGridViewMatrix_KNA);
            this.groupBoxUslovie_KNA.Controls.Add(this.textBoxUslovie_KNA);
            this.groupBoxUslovie_KNA.Location = new System.Drawing.Point(12, 18);
            this.groupBoxUslovie_KNA.Name = "groupBoxUslovie_KNA";
            this.groupBoxUslovie_KNA.Size = new System.Drawing.Size(679, 417);
            this.groupBoxUslovie_KNA.TabIndex = 0;
            this.groupBoxUslovie_KNA.TabStop = false;
            this.groupBoxUslovie_KNA.Text = "Условие";
            // 
            // textBoxUslovie_KNA
            // 
            this.textBoxUslovie_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUslovie_KNA.Location = new System.Drawing.Point(6, 19);
            this.textBoxUslovie_KNA.Multiline = true;
            this.textBoxUslovie_KNA.Name = "textBoxUslovie_KNA";
            this.textBoxUslovie_KNA.ReadOnly = true;
            this.textBoxUslovie_KNA.Size = new System.Drawing.Size(246, 190);
            this.textBoxUslovie_KNA.TabIndex = 0;
            this.textBoxUslovie_KNA.Text = "Дана матрица 5 на 5\r\n22  32 -16  24  27\r\n3 -20  24 -20  25\r\n21  17  -8 -19  17\r\n8" +
    "  22  28  27  19\r\n11  20  12  27  29\r\nотсортировать последний столбец по возраст" +
    "анию.";
            // 
            // groupBoxDone_KNA
            // 
            this.groupBoxDone_KNA.Controls.Add(this.textBoxResult_KNA);
            this.groupBoxDone_KNA.Controls.Add(this.textBoxDone_KNA);
            this.groupBoxDone_KNA.Location = new System.Drawing.Point(719, 26);
            this.groupBoxDone_KNA.Name = "groupBoxDone_KNA";
            this.groupBoxDone_KNA.Size = new System.Drawing.Size(298, 368);
            this.groupBoxDone_KNA.TabIndex = 1;
            this.groupBoxDone_KNA.TabStop = false;
            this.groupBoxDone_KNA.Text = "Вывод данных";
            // 
            // textBoxResult_KNA
            // 
            this.textBoxResult_KNA.Location = new System.Drawing.Point(9, 49);
            this.textBoxResult_KNA.Multiline = true;
            this.textBoxResult_KNA.Name = "textBoxResult_KNA";
            this.textBoxResult_KNA.ReadOnly = true;
            this.textBoxResult_KNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KNA.Size = new System.Drawing.Size(283, 302);
            this.textBoxResult_KNA.TabIndex = 1;
            // 
            // textBoxDone_KNA
            // 
            this.textBoxDone_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDone_KNA.Location = new System.Drawing.Point(6, 19);
            this.textBoxDone_KNA.Name = "textBoxDone_KNA";
            this.textBoxDone_KNA.ReadOnly = true;
            this.textBoxDone_KNA.Size = new System.Drawing.Size(109, 20);
            this.textBoxDone_KNA.TabIndex = 0;
            this.textBoxDone_KNA.Text = "Результат";
            // 
            // buttonResult_KNA
            // 
            this.buttonResult_KNA.Location = new System.Drawing.Point(902, 401);
            this.buttonResult_KNA.Name = "buttonResult_KNA";
            this.buttonResult_KNA.Size = new System.Drawing.Size(115, 35);
            this.buttonResult_KNA.TabIndex = 2;
            this.buttonResult_KNA.Text = "Выполнить";
            this.buttonResult_KNA.UseVisualStyleBackColor = true;
            this.buttonResult_KNA.Click += new System.EventHandler(this.buttonResult_KNA_Click);
            // 
            // buttonHelp_KNA
            // 
            this.buttonHelp_KNA.Location = new System.Drawing.Point(822, 400);
            this.buttonHelp_KNA.Name = "buttonHelp_KNA";
            this.buttonHelp_KNA.Size = new System.Drawing.Size(45, 34);
            this.buttonHelp_KNA.TabIndex = 3;
            this.buttonHelp_KNA.Text = "?";
            this.buttonHelp_KNA.UseVisualStyleBackColor = true;
            this.buttonHelp_KNA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // dataGridViewMatrix_KNA
            // 
            this.dataGridViewMatrix_KNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KNA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KNA.Location = new System.Drawing.Point(273, 20);
            this.dataGridViewMatrix_KNA.Name = "dataGridViewMatrix_KNA";
            this.dataGridViewMatrix_KNA.RowHeadersVisible = false;
            this.dataGridViewMatrix_KNA.Size = new System.Drawing.Size(390, 387);
            this.dataGridViewMatrix_KNA.TabIndex = 1;
            // 
            // FormMain_KNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.buttonHelp_KNA);
            this.Controls.Add(this.buttonResult_KNA);
            this.Controls.Add(this.groupBoxDone_KNA);
            this.Controls.Add(this.groupBoxUslovie_KNA);
            this.MaximizeBox = false;
            this.Name = "FormMain_KNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 17 | Карпенко Н. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_KNA.ResumeLayout(false);
            this.groupBoxUslovie_KNA.PerformLayout();
            this.groupBoxDone_KNA.ResumeLayout(false);
            this.groupBoxDone_KNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_KNA;
        private System.Windows.Forms.TextBox textBoxUslovie_KNA;
        private System.Windows.Forms.GroupBox groupBoxDone_KNA;
        private System.Windows.Forms.TextBox textBoxResult_KNA;
        private System.Windows.Forms.TextBox textBoxDone_KNA;
        private System.Windows.Forms.Button buttonResult_KNA;
        private System.Windows.Forms.Button buttonHelp_KNA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KNA;
    }
}

