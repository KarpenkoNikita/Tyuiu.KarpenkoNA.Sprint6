
namespace Tyuiu.KarpenkoNA.Sprint6.Task6.V8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfo_KNA = new System.Windows.Forms.Label();
            this.buttonOk_KNA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Tyuiu.KarpenkoNA.Sprint6.Task6.V8.Properties.Resources.photo1691351589;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelInfo_KNA
            // 
            this.labelInfo_KNA.AutoSize = true;
            this.labelInfo_KNA.Location = new System.Drawing.Point(182, 32);
            this.labelInfo_KNA.Name = "labelInfo_KNA";
            this.labelInfo_KNA.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_KNA.TabIndex = 1;
            this.labelInfo_KNA.Text = resources.GetString("labelInfo_KNA.Text");
            // 
            // buttonOk_KNA
            // 
            this.buttonOk_KNA.Location = new System.Drawing.Point(494, 149);
            this.buttonOk_KNA.Name = "buttonOk_KNA";
            this.buttonOk_KNA.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_KNA.TabIndex = 2;
            this.buttonOk_KNA.Text = "Ок";
            this.buttonOk_KNA.UseVisualStyleBackColor = true;
            this.buttonOk_KNA.Click += new System.EventHandler(this.buttonOk_KNA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 184);
            this.Controls.Add(this.buttonOk_KNA);
            this.Controls.Add(this.labelInfo_KNA);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfo_KNA;
        private System.Windows.Forms.Button buttonOk_KNA;
    }
}