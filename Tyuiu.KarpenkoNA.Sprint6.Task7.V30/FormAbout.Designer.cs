
namespace Tyuiu.KarpenkoNA.Sprint6.Task7.V30
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.groupBoxInfo_KNA = new System.Windows.Forms.GroupBox();
            this.textBoxInfo_KNA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOk_KNA = new System.Windows.Forms.Button();
            this.groupBoxInfo_KNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo_KNA
            // 
            this.groupBoxInfo_KNA.Controls.Add(this.textBoxInfo_KNA);
            this.groupBoxInfo_KNA.Location = new System.Drawing.Point(349, 48);
            this.groupBoxInfo_KNA.Name = "groupBoxInfo_KNA";
            this.groupBoxInfo_KNA.Size = new System.Drawing.Size(391, 312);
            this.groupBoxInfo_KNA.TabIndex = 0;
            this.groupBoxInfo_KNA.TabStop = false;
            // 
            // textBoxInfo_KNA
            // 
            this.textBoxInfo_KNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxInfo_KNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_KNA.Location = new System.Drawing.Point(6, 67);
            this.textBoxInfo_KNA.Multiline = true;
            this.textBoxInfo_KNA.Name = "textBoxInfo_KNA";
            this.textBoxInfo_KNA.ReadOnly = true;
            this.textBoxInfo_KNA.Size = new System.Drawing.Size(345, 181);
            this.textBoxInfo_KNA.TabIndex = 0;
            this.textBoxInfo_KNA.Text = resources.GetString("textBoxInfo_KNA.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::Tyuiu.KarpenkoNA.Sprint6.Task7.V30.Properties.Resources.photo1691351589;
            this.pictureBox1.Location = new System.Drawing.Point(40, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOk_KNA
            // 
            this.buttonOk_KNA.Location = new System.Drawing.Point(660, 406);
            this.buttonOk_KNA.Name = "buttonOk_KNA";
            this.buttonOk_KNA.Size = new System.Drawing.Size(128, 32);
            this.buttonOk_KNA.TabIndex = 2;
            this.buttonOk_KNA.Text = "Ок";
            this.buttonOk_KNA.UseVisualStyleBackColor = true;
            this.buttonOk_KNA.Click += new System.EventHandler(this.buttonOk_KNA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk_KNA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxInfo_KNA);
            this.Name = "FormAbout";
            this.Text = "Справка";
            this.groupBoxInfo_KNA.ResumeLayout(false);
            this.groupBoxInfo_KNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_KNA;
        private System.Windows.Forms.TextBox textBoxInfo_KNA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOk_KNA;
    }
}