
namespace Tyuiu.KarpenkoNA.Sprint6.Task7.V30
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelUp_KNA = new System.Windows.Forms.Panel();
            this.buttonInfo_KNA = new System.Windows.Forms.Button();
            this.buttonDone_KNA = new System.Windows.Forms.Button();
            this.buttonSave_KNA = new System.Windows.Forms.Button();
            this.buttonOpenFile_KNA = new System.Windows.Forms.Button();
            this.panelUp2_KNA = new System.Windows.Forms.Panel();
            this.groupBoxTask_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KNA = new System.Windows.Forms.TextBox();
            this.panelLeft_KNA = new System.Windows.Forms.Panel();
            this.groupBoxIn_KNA = new System.Windows.Forms.GroupBox();
            this.dataGridIn_KNA = new System.Windows.Forms.DataGridView();
            this.panelFill_KNA = new System.Windows.Forms.Panel();
            this.groupBoxOut_KNA = new System.Windows.Forms.GroupBox();
            this.dataGridOut_KNA = new System.Windows.Forms.DataGridView();
            this.splitterVD2_KNA = new System.Windows.Forms.Splitter();
            this.splitterVD_KNA = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_KNA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_KNA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_KNA = new System.Windows.Forms.ToolTip(this.components);
            this.panelUp_KNA.SuspendLayout();
            this.panelUp2_KNA.SuspendLayout();
            this.groupBoxTask_KNA.SuspendLayout();
            this.panelLeft_KNA.SuspendLayout();
            this.groupBoxIn_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIn_KNA)).BeginInit();
            this.panelFill_KNA.SuspendLayout();
            this.groupBoxOut_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOut_KNA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_KNA
            // 
            this.panelUp_KNA.Controls.Add(this.buttonInfo_KNA);
            this.panelUp_KNA.Controls.Add(this.buttonDone_KNA);
            this.panelUp_KNA.Controls.Add(this.buttonSave_KNA);
            this.panelUp_KNA.Controls.Add(this.buttonOpenFile_KNA);
            this.panelUp_KNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_KNA.Location = new System.Drawing.Point(0, 0);
            this.panelUp_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.panelUp_KNA.Name = "panelUp_KNA";
            this.panelUp_KNA.Size = new System.Drawing.Size(841, 79);
            this.panelUp_KNA.TabIndex = 0;
            // 
            // buttonInfo_KNA
            // 
            this.buttonInfo_KNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonInfo_KNA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_KNA.Image")));
            this.buttonInfo_KNA.Location = new System.Drawing.Point(744, 5);
            this.buttonInfo_KNA.Name = "buttonInfo_KNA";
            this.buttonInfo_KNA.Size = new System.Drawing.Size(85, 71);
            this.buttonInfo_KNA.TabIndex = 3;
            this.toolTipButton_KNA.SetToolTip(this.buttonInfo_KNA, "buttonHelp_KNA_MouseEnter");
            this.buttonInfo_KNA.UseVisualStyleBackColor = false;
            this.buttonInfo_KNA.Click += new System.EventHandler(this.buttonInfo_KNA_Click);
            // 
            // buttonDone_KNA
            // 
            this.buttonDone_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonDone_KNA.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_KNA.Image")));
            this.buttonDone_KNA.Location = new System.Drawing.Point(94, 3);
            this.buttonDone_KNA.Name = "buttonDone_KNA";
            this.buttonDone_KNA.Size = new System.Drawing.Size(85, 71);
            this.buttonDone_KNA.TabIndex = 1;
            this.toolTipButton_KNA.SetToolTip(this.buttonDone_KNA, "Выполнить");
            this.buttonDone_KNA.UseVisualStyleBackColor = false;
            this.buttonDone_KNA.Click += new System.EventHandler(this.buttonDone_KNA_Click);
            // 
            // buttonSave_KNA
            // 
            this.buttonSave_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSave_KNA.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_KNA.Image")));
            this.buttonSave_KNA.Location = new System.Drawing.Point(185, 3);
            this.buttonSave_KNA.Name = "buttonSave_KNA";
            this.buttonSave_KNA.Size = new System.Drawing.Size(85, 71);
            this.buttonSave_KNA.TabIndex = 2;
            this.toolTipButton_KNA.SetToolTip(this.buttonSave_KNA, "Сохранить файл");
            this.buttonSave_KNA.UseVisualStyleBackColor = false;
            this.buttonSave_KNA.Click += new System.EventHandler(this.buttonSave_KNA_Click);
            // 
            // buttonOpenFile_KNA
            // 
            this.buttonOpenFile_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonOpenFile_KNA.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KNA.Image")));
            this.buttonOpenFile_KNA.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_KNA.Name = "buttonOpenFile_KNA";
            this.buttonOpenFile_KNA.Size = new System.Drawing.Size(85, 71);
            this.buttonOpenFile_KNA.TabIndex = 0;
            this.toolTipButton_KNA.SetToolTip(this.buttonOpenFile_KNA, "Открыть файл\r\n");
            this.buttonOpenFile_KNA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KNA.Click += new System.EventHandler(this.buttonOpenFile_KNA_Click);
            // 
            // panelUp2_KNA
            // 
            this.panelUp2_KNA.Controls.Add(this.groupBoxTask_KNA);
            this.panelUp2_KNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp2_KNA.Location = new System.Drawing.Point(0, 79);
            this.panelUp2_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.panelUp2_KNA.Name = "panelUp2_KNA";
            this.panelUp2_KNA.Size = new System.Drawing.Size(841, 79);
            this.panelUp2_KNA.TabIndex = 1;
            // 
            // groupBoxTask_KNA
            // 
            this.groupBoxTask_KNA.Controls.Add(this.textBoxTask_KNA);
            this.groupBoxTask_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_KNA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_KNA.Name = "groupBoxTask_KNA";
            this.groupBoxTask_KNA.Size = new System.Drawing.Size(841, 79);
            this.groupBoxTask_KNA.TabIndex = 2;
            this.groupBoxTask_KNA.TabStop = false;
            this.groupBoxTask_KNA.Text = "Условие";
            // 
            // textBoxTask_KNA
            // 
            this.textBoxTask_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_KNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KNA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_KNA.Multiline = true;
            this.textBoxTask_KNA.Name = "textBoxTask_KNA";
            this.textBoxTask_KNA.Size = new System.Drawing.Size(579, 49);
            this.textBoxTask_KNA.TabIndex = 0;
            this.textBoxTask_KNA.Text = resources.GetString("textBoxTask_KNA.Text");
            // 
            // panelLeft_KNA
            // 
            this.panelLeft_KNA.Controls.Add(this.groupBoxIn_KNA);
            this.panelLeft_KNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KNA.Location = new System.Drawing.Point(0, 158);
            this.panelLeft_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft_KNA.Name = "panelLeft_KNA";
            this.panelLeft_KNA.Size = new System.Drawing.Size(403, 449);
            this.panelLeft_KNA.TabIndex = 0;
            // 
            // groupBoxIn_KNA
            // 
            this.groupBoxIn_KNA.Controls.Add(this.dataGridIn_KNA);
            this.groupBoxIn_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_KNA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_KNA.Name = "groupBoxIn_KNA";
            this.groupBoxIn_KNA.Size = new System.Drawing.Size(403, 449);
            this.groupBoxIn_KNA.TabIndex = 0;
            this.groupBoxIn_KNA.TabStop = false;
            this.groupBoxIn_KNA.Text = "Ввод";
            // 
            // dataGridIn_KNA
            // 
            this.dataGridIn_KNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIn_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIn_KNA.Location = new System.Drawing.Point(3, 16);
            this.dataGridIn_KNA.Name = "dataGridIn_KNA";
            this.dataGridIn_KNA.Size = new System.Drawing.Size(397, 430);
            this.dataGridIn_KNA.TabIndex = 1;
            // 
            // panelFill_KNA
            // 
            this.panelFill_KNA.Controls.Add(this.groupBoxOut_KNA);
            this.panelFill_KNA.Controls.Add(this.splitterVD2_KNA);
            this.panelFill_KNA.Controls.Add(this.splitterVD_KNA);
            this.panelFill_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_KNA.Location = new System.Drawing.Point(403, 158);
            this.panelFill_KNA.Margin = new System.Windows.Forms.Padding(2);
            this.panelFill_KNA.Name = "panelFill_KNA";
            this.panelFill_KNA.Size = new System.Drawing.Size(438, 449);
            this.panelFill_KNA.TabIndex = 0;
            // 
            // groupBoxOut_KNA
            // 
            this.groupBoxOut_KNA.Controls.Add(this.dataGridOut_KNA);
            this.groupBoxOut_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_KNA.Location = new System.Drawing.Point(6, 0);
            this.groupBoxOut_KNA.Name = "groupBoxOut_KNA";
            this.groupBoxOut_KNA.Size = new System.Drawing.Size(432, 449);
            this.groupBoxOut_KNA.TabIndex = 2;
            this.groupBoxOut_KNA.TabStop = false;
            this.groupBoxOut_KNA.Text = "Вывод";
            // 
            // dataGridOut_KNA
            // 
            this.dataGridOut_KNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOut_KNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOut_KNA.Location = new System.Drawing.Point(3, 16);
            this.dataGridOut_KNA.Name = "dataGridOut_KNA";
            this.dataGridOut_KNA.Size = new System.Drawing.Size(426, 430);
            this.dataGridOut_KNA.TabIndex = 2;
            // 
            // splitterVD2_KNA
            // 
            this.splitterVD2_KNA.Location = new System.Drawing.Point(3, 0);
            this.splitterVD2_KNA.Name = "splitterVD2_KNA";
            this.splitterVD2_KNA.Size = new System.Drawing.Size(3, 449);
            this.splitterVD2_KNA.TabIndex = 1;
            this.splitterVD2_KNA.TabStop = false;
            // 
            // splitterVD_KNA
            // 
            this.splitterVD_KNA.Location = new System.Drawing.Point(0, 0);
            this.splitterVD_KNA.Name = "splitterVD_KNA";
            this.splitterVD_KNA.Size = new System.Drawing.Size(3, 449);
            this.splitterVD_KNA.TabIndex = 0;
            this.splitterVD_KNA.TabStop = false;
            // 
            // openFileDialogTask_KNA
            // 
            this.openFileDialogTask_KNA.FileName = "openFileDialog1";
            // 
            // toolTipButton_KNA
            // 
            this.toolTipButton_KNA.IsBalloon = true;
            this.toolTipButton_KNA.OwnerDraw = true;
            this.toolTipButton_KNA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 607);
            this.Controls.Add(this.panelFill_KNA);
            this.Controls.Add(this.panelLeft_KNA);
            this.Controls.Add(this.panelUp2_KNA);
            this.Controls.Add(this.panelUp_KNA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(857, 646);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 30 | Карпенко Н.А.";
            this.panelUp_KNA.ResumeLayout(false);
            this.panelUp2_KNA.ResumeLayout(false);
            this.groupBoxTask_KNA.ResumeLayout(false);
            this.groupBoxTask_KNA.PerformLayout();
            this.panelLeft_KNA.ResumeLayout(false);
            this.groupBoxIn_KNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIn_KNA)).EndInit();
            this.panelFill_KNA.ResumeLayout(false);
            this.groupBoxOut_KNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOut_KNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp_KNA;
        private System.Windows.Forms.Panel panelUp2_KNA;
        private System.Windows.Forms.Panel panelLeft_KNA;
        private System.Windows.Forms.Panel panelFill_KNA;
        private System.Windows.Forms.Splitter splitterVD2_KNA;
        private System.Windows.Forms.Splitter splitterVD_KNA;
        private System.Windows.Forms.Button buttonSave_KNA;
        private System.Windows.Forms.Button buttonDone_KNA;
        private System.Windows.Forms.Button buttonOpenFile_KNA;
        private System.Windows.Forms.GroupBox groupBoxIn_KNA;
        private System.Windows.Forms.GroupBox groupBoxOut_KNA;
        private System.Windows.Forms.Button buttonInfo_KNA;
        private System.Windows.Forms.GroupBox groupBoxTask_KNA;
        private System.Windows.Forms.TextBox textBoxTask_KNA;
        private System.Windows.Forms.DataGridView dataGridIn_KNA;
        private System.Windows.Forms.DataGridView dataGridOut_KNA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KNA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KNA;
        private System.Windows.Forms.ToolTip toolTipButton_KNA;
    }
    
    
}

