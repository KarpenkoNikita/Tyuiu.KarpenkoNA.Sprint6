
namespace Tyuiu.KarpenkoNA.Sprint6.Task0.V13
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
            this.groupBoxTask_KNA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_KNA = new System.Windows.Forms.PictureBox();
            this.groupBoxTasks_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxX_KNA = new System.Windows.Forms.TextBox();
            this.groupBoxTaskss_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KNA = new System.Windows.Forms.TextBox();
            this.labelResult_KNA = new System.Windows.Forms.Label();
            this.buttonResult_KNA = new System.Windows.Forms.Button();
            this.buttonInfo_KNA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KNA)).BeginInit();
            this.groupBoxTasks_KNA.SuspendLayout();
            this.groupBoxTaskss_KNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KNA
            // 
            this.groupBoxTask_KNA.Controls.Add(this.textBox1);
            this.groupBoxTask_KNA.Controls.Add(this.pictureBoxFormula_KNA);
            this.groupBoxTask_KNA.Location = new System.Drawing.Point(12, 24);
            this.groupBoxTask_KNA.Name = "groupBoxTask_KNA";
            this.groupBoxTask_KNA.Size = new System.Drawing.Size(776, 216);
            this.groupBoxTask_KNA.TabIndex = 0;
            this.groupBoxTask_KNA.TabStop = false;
            this.groupBoxTask_KNA.Text = "Условие";
            this.groupBoxTask_KNA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxFormula_KNA
            // 
            this.pictureBoxFormula_KNA.ErrorImage = null;
            this.pictureBoxFormula_KNA.Image = global::Tyuiu.KarpenkoNA.Sprint6.Task0.V13.Properties.Resources.Untitled;
            this.pictureBoxFormula_KNA.InitialImage = global::Tyuiu.KarpenkoNA.Sprint6.Task0.V13.Properties.Resources.Untitled;
            this.pictureBoxFormula_KNA.Location = new System.Drawing.Point(639, 19);
            this.pictureBoxFormula_KNA.Name = "pictureBoxFormula_KNA";
            this.pictureBoxFormula_KNA.Size = new System.Drawing.Size(120, 62);
            this.pictureBoxFormula_KNA.TabIndex = 1;
            this.pictureBoxFormula_KNA.TabStop = false;
            // 
            // groupBoxTasks_KNA
            // 
            this.groupBoxTasks_KNA.Controls.Add(this.textBox2);
            this.groupBoxTasks_KNA.Controls.Add(this.textBoxX_KNA);
            this.groupBoxTasks_KNA.Location = new System.Drawing.Point(12, 256);
            this.groupBoxTasks_KNA.Name = "groupBoxTasks_KNA";
            this.groupBoxTasks_KNA.Size = new System.Drawing.Size(492, 121);
            this.groupBoxTasks_KNA.TabIndex = 1;
            this.groupBoxTasks_KNA.TabStop = false;
            this.groupBoxTasks_KNA.Text = "Ввод данных";
            // 
            // textBoxX_KNA
            // 
            this.textBoxX_KNA.Location = new System.Drawing.Point(19, 62);
            this.textBoxX_KNA.Name = "textBoxX_KNA";
            this.textBoxX_KNA.Size = new System.Drawing.Size(124, 20);
            this.textBoxX_KNA.TabIndex = 0;
            this.textBoxX_KNA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // groupBoxTaskss_KNA
            // 
            this.groupBoxTaskss_KNA.Controls.Add(this.textBoxResult_KNA);
            this.groupBoxTaskss_KNA.Controls.Add(this.labelResult_KNA);
            this.groupBoxTaskss_KNA.Location = new System.Drawing.Point(516, 265);
            this.groupBoxTaskss_KNA.Name = "groupBoxTaskss_KNA";
            this.groupBoxTaskss_KNA.Size = new System.Drawing.Size(271, 111);
            this.groupBoxTaskss_KNA.TabIndex = 2;
            this.groupBoxTaskss_KNA.TabStop = false;
            this.groupBoxTaskss_KNA.Text = "Вывод данных";
            // 
            // textBoxResult_KNA
            // 
            this.textBoxResult_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_KNA.Location = new System.Drawing.Point(14, 66);
            this.textBoxResult_KNA.Name = "textBoxResult_KNA";
            this.textBoxResult_KNA.ReadOnly = true;
            this.textBoxResult_KNA.Size = new System.Drawing.Size(227, 20);
            this.textBoxResult_KNA.TabIndex = 1;
            // 
            // labelResult_KNA
            // 
            this.labelResult_KNA.AutoSize = true;
            this.labelResult_KNA.Location = new System.Drawing.Point(6, 37);
            this.labelResult_KNA.Name = "labelResult_KNA";
            this.labelResult_KNA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_KNA.TabIndex = 0;
            this.labelResult_KNA.Text = "Результат:";
            // 
            // buttonResult_KNA
            // 
            this.buttonResult_KNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_KNA.Location = new System.Drawing.Point(614, 392);
            this.buttonResult_KNA.Name = "buttonResult_KNA";
            this.buttonResult_KNA.Size = new System.Drawing.Size(173, 46);
            this.buttonResult_KNA.TabIndex = 3;
            this.buttonResult_KNA.Text = "Выполнить";
            this.buttonResult_KNA.UseVisualStyleBackColor = true;
            this.buttonResult_KNA.Click += new System.EventHandler(this.buttonResult_KNA_Click);
            // 
            // buttonInfo_KNA
            // 
            this.buttonInfo_KNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KNA.Location = new System.Drawing.Point(548, 392);
            this.buttonInfo_KNA.Name = "buttonInfo_KNA";
            this.buttonInfo_KNA.Size = new System.Drawing.Size(48, 46);
            this.buttonInfo_KNA.TabIndex = 4;
            this.buttonInfo_KNA.Text = "?";
            this.buttonInfo_KNA.UseVisualStyleBackColor = true;
            this.buttonInfo_KNA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(9, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(593, 179);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Вычислить значение по формуле";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(19, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Переменная Х:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_KNA);
            this.Controls.Add(this.buttonResult_KNA);
            this.Controls.Add(this.groupBoxTaskss_KNA);
            this.Controls.Add(this.groupBoxTasks_KNA);
            this.Controls.Add(this.groupBoxTask_KNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 13 | Карпенко Н. А.";
            this.groupBoxTask_KNA.ResumeLayout(false);
            this.groupBoxTask_KNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KNA)).EndInit();
            this.groupBoxTasks_KNA.ResumeLayout(false);
            this.groupBoxTasks_KNA.PerformLayout();
            this.groupBoxTaskss_KNA.ResumeLayout(false);
            this.groupBoxTaskss_KNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KNA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KNA;
        private System.Windows.Forms.GroupBox groupBoxTasks_KNA;
        private System.Windows.Forms.TextBox textBoxX_KNA;
        private System.Windows.Forms.GroupBox groupBoxTaskss_KNA;
        private System.Windows.Forms.Label labelResult_KNA;
        private System.Windows.Forms.Button buttonResult_KNA;
        private System.Windows.Forms.Button buttonInfo_KNA;
        private System.Windows.Forms.TextBox textBoxResult_KNA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

