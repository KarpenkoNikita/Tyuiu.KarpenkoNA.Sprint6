
namespace Tyuiu.KarpenkoNA.Sprint6.Task1.V7
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
            this.groupBoxUslovie_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_KNA = new System.Windows.Forms.TextBox();
            this.groupBoxZnacheniya_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxStop_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStart_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_KNA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KNA = new System.Windows.Forms.TextBox();
            this.buttonHelp_KNA = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxResult_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KNA = new System.Windows.Forms.TextBox();
            this.textBoxDone_KNA = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie_KNA.SuspendLayout();
            this.groupBoxZnacheniya_KNA.SuspendLayout();
            this.groupBoxResult_KNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_KNA
            // 
            this.groupBoxUslovie_KNA.Controls.Add(this.textBoxUslovie_KNA);
            this.groupBoxUslovie_KNA.Location = new System.Drawing.Point(13, 17);
            this.groupBoxUslovie_KNA.Name = "groupBoxUslovie_KNA";
            this.groupBoxUslovie_KNA.Size = new System.Drawing.Size(530, 277);
            this.groupBoxUslovie_KNA.TabIndex = 0;
            this.groupBoxUslovie_KNA.TabStop = false;
            this.groupBoxUslovie_KNA.Text = "Условие";
            // 
            // textBoxUslovie_KNA
            // 
            this.textBoxUslovie_KNA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxUslovie_KNA.Location = new System.Drawing.Point(6, 22);
            this.textBoxUslovie_KNA.Multiline = true;
            this.textBoxUslovie_KNA.Name = "textBoxUslovie_KNA";
            this.textBoxUslovie_KNA.ReadOnly = true;
            this.textBoxUslovie_KNA.Size = new System.Drawing.Size(492, 91);
            this.textBoxUslovie_KNA.TabIndex = 0;
            this.textBoxUslovie_KNA.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в виде таблицы." +
    "";
            // 
            // groupBoxZnacheniya_KNA
            // 
            this.groupBoxZnacheniya_KNA.Controls.Add(this.textBoxStop_KNA);
            this.groupBoxZnacheniya_KNA.Controls.Add(this.textBoxStart_KNA);
            this.groupBoxZnacheniya_KNA.Controls.Add(this.textBoxStopStep_KNA);
            this.groupBoxZnacheniya_KNA.Controls.Add(this.textBoxStartStep_KNA);
            this.groupBoxZnacheniya_KNA.Location = new System.Drawing.Point(12, 339);
            this.groupBoxZnacheniya_KNA.Name = "groupBoxZnacheniya_KNA";
            this.groupBoxZnacheniya_KNA.Size = new System.Drawing.Size(297, 93);
            this.groupBoxZnacheniya_KNA.TabIndex = 1;
            this.groupBoxZnacheniya_KNA.TabStop = false;
            this.groupBoxZnacheniya_KNA.Text = "Ввод данных";
            // 
            // textBoxStop_KNA
            // 
            this.textBoxStop_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStop_KNA.Location = new System.Drawing.Point(155, 27);
            this.textBoxStop_KNA.Name = "textBoxStop_KNA";
            this.textBoxStop_KNA.ReadOnly = true;
            this.textBoxStop_KNA.Size = new System.Drawing.Size(133, 20);
            this.textBoxStop_KNA.TabIndex = 3;
            this.textBoxStop_KNA.Text = "Конец шага:";
            // 
            // textBoxStart_KNA
            // 
            this.textBoxStart_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxStart_KNA.Location = new System.Drawing.Point(13, 27);
            this.textBoxStart_KNA.Name = "textBoxStart_KNA";
            this.textBoxStart_KNA.ReadOnly = true;
            this.textBoxStart_KNA.Size = new System.Drawing.Size(121, 20);
            this.textBoxStart_KNA.TabIndex = 2;
            this.textBoxStart_KNA.Text = "Старт шага:";
            // 
            // textBoxStopStep_KNA
            // 
            this.textBoxStopStep_KNA.Location = new System.Drawing.Point(155, 53);
            this.textBoxStopStep_KNA.Name = "textBoxStopStep_KNA";
            this.textBoxStopStep_KNA.Size = new System.Drawing.Size(133, 20);
            this.textBoxStopStep_KNA.TabIndex = 1;
            // 
            // textBoxStartStep_KNA
            // 
            this.textBoxStartStep_KNA.Location = new System.Drawing.Point(13, 53);
            this.textBoxStartStep_KNA.Name = "textBoxStartStep_KNA";
            this.textBoxStartStep_KNA.Size = new System.Drawing.Size(121, 20);
            this.textBoxStartStep_KNA.TabIndex = 0;
            // 
            // buttonHelp_KNA
            // 
            this.buttonHelp_KNA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_KNA.Location = new System.Drawing.Point(315, 355);
            this.buttonHelp_KNA.Name = "buttonHelp_KNA";
            this.buttonHelp_KNA.Size = new System.Drawing.Size(88, 68);
            this.buttonHelp_KNA.TabIndex = 2;
            this.buttonHelp_KNA.Text = "Справка";
            this.buttonHelp_KNA.UseVisualStyleBackColor = false;
            this.buttonHelp_KNA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone.Location = new System.Drawing.Point(409, 355);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(134, 68);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxResult_KNA
            // 
            this.groupBoxResult_KNA.Controls.Add(this.textBoxResult_KNA);
            this.groupBoxResult_KNA.Controls.Add(this.textBoxDone_KNA);
            this.groupBoxResult_KNA.Location = new System.Drawing.Point(555, 24);
            this.groupBoxResult_KNA.Name = "groupBoxResult_KNA";
            this.groupBoxResult_KNA.Size = new System.Drawing.Size(237, 407);
            this.groupBoxResult_KNA.TabIndex = 4;
            this.groupBoxResult_KNA.TabStop = false;
            this.groupBoxResult_KNA.Text = "Вывод данных";
            // 
            // textBoxResult_KNA
            // 
            this.textBoxResult_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_KNA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KNA.Location = new System.Drawing.Point(4, 45);
            this.textBoxResult_KNA.Multiline = true;
            this.textBoxResult_KNA.Name = "textBoxResult_KNA";
            this.textBoxResult_KNA.ReadOnly = true;
            this.textBoxResult_KNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KNA.Size = new System.Drawing.Size(227, 346);
            this.textBoxResult_KNA.TabIndex = 1;
            // 
            // textBoxDone_KNA
            // 
            this.textBoxDone_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDone_KNA.Location = new System.Drawing.Point(6, 19);
            this.textBoxDone_KNA.Name = "textBoxDone_KNA";
            this.textBoxDone_KNA.ReadOnly = true;
            this.textBoxDone_KNA.Size = new System.Drawing.Size(100, 20);
            this.textBoxDone_KNA.TabIndex = 0;
            this.textBoxDone_KNA.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult_KNA);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonHelp_KNA);
            this.Controls.Add(this.groupBoxZnacheniya_KNA);
            this.Controls.Add(this.groupBoxUslovie_KNA);
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 7 | Карпенко Н. А.";
            this.groupBoxUslovie_KNA.ResumeLayout(false);
            this.groupBoxUslovie_KNA.PerformLayout();
            this.groupBoxZnacheniya_KNA.ResumeLayout(false);
            this.groupBoxZnacheniya_KNA.PerformLayout();
            this.groupBoxResult_KNA.ResumeLayout(false);
            this.groupBoxResult_KNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_KNA;
        private System.Windows.Forms.TextBox textBoxUslovie_KNA;
        private System.Windows.Forms.GroupBox groupBoxZnacheniya_KNA;
        private System.Windows.Forms.TextBox textBoxStop_KNA;
        private System.Windows.Forms.TextBox textBoxStart_KNA;
        private System.Windows.Forms.TextBox textBoxStopStep_KNA;
        private System.Windows.Forms.TextBox textBoxStartStep_KNA;
        private System.Windows.Forms.Button buttonHelp_KNA;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxResult_KNA;
        private System.Windows.Forms.TextBox textBoxResult_KNA;
        private System.Windows.Forms.TextBox textBoxDone_KNA;
    }
}

