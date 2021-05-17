
namespace GreenPixelsCalculator
{
    partial class FormPixel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultPixels = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLoadImg = new System.Windows.Forms.Button();
            this.btPixelDetect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultPixels
            // 
            this.lblResultPixels.AutoSize = true;
            this.lblResultPixels.Location = new System.Drawing.Point(12, 474);
            this.lblResultPixels.Name = "lblResultPixels";
            this.lblResultPixels.Size = new System.Drawing.Size(0, 13);
            this.lblResultPixels.TabIndex = 0;
            this.lblResultPixels.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 360);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // btLoadImg
            // 
            this.btLoadImg.Location = new System.Drawing.Point(333, 387);
            this.btLoadImg.Name = "btLoadImg";
            this.btLoadImg.Size = new System.Drawing.Size(125, 37);
            this.btLoadImg.TabIndex = 2;
            this.btLoadImg.Text = "Imagem...";
            this.btLoadImg.UseVisualStyleBackColor = true;
            this.btLoadImg.UseWaitCursor = true;
            this.btLoadImg.Click += new System.EventHandler(this.btLoadImg_Click);
            // 
            // btPixelDetect
            // 
            this.btPixelDetect.Location = new System.Drawing.Point(334, 430);
            this.btPixelDetect.Name = "btPixelDetect";
            this.btPixelDetect.Size = new System.Drawing.Size(125, 35);
            this.btPixelDetect.TabIndex = 3;
            this.btPixelDetect.Text = "Detectar Pixels";
            this.btPixelDetect.UseVisualStyleBackColor = true;
            this.btPixelDetect.UseWaitCursor = true;
            this.btPixelDetect.Click += new System.EventHandler(this.btPixelDetect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 496);
            this.Controls.Add(this.btPixelDetect);
            this.Controls.Add(this.btLoadImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultPixels);
            this.Name = "Form1";
            this.Text = "Calculadora de Pixels Verdes";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultPixels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btLoadImg;
        private System.Windows.Forms.Button btPixelDetect;
    }
}

