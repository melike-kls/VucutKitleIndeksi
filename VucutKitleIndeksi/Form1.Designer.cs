
namespace VucutKitleIndeksi
{
    partial class Form1
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
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lblboy = new System.Windows.Forms.Label();
            this.lblkilo = new System.Windows.Forms.Label();
            this.txtboy = new System.Windows.Forms.TextBox();
            this.txtkilo = new System.Windows.Forms.TextBox();
            this.lbloran = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.txtoran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(83, 170);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(75, 23);
            this.btnhesapla.TabIndex = 0;
            this.btnhesapla.Text = "HESAPLA";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // lblboy
            // 
            this.lblboy.AutoSize = true;
            this.lblboy.Location = new System.Drawing.Point(37, 85);
            this.lblboy.Name = "lblboy";
            this.lblboy.Size = new System.Drawing.Size(29, 13);
            this.lblboy.TabIndex = 1;
            this.lblboy.Text = "BOY";
            // 
            // lblkilo
            // 
            this.lblkilo.AutoSize = true;
            this.lblkilo.Location = new System.Drawing.Point(37, 133);
            this.lblkilo.Name = "lblkilo";
            this.lblkilo.Size = new System.Drawing.Size(31, 13);
            this.lblkilo.TabIndex = 2;
            this.lblkilo.Text = "KILO";
            // 
            // txtboy
            // 
            this.txtboy.Location = new System.Drawing.Point(74, 82);
            this.txtboy.Name = "txtboy";
            this.txtboy.Size = new System.Drawing.Size(100, 20);
            this.txtboy.TabIndex = 3;
            // 
            // txtkilo
            // 
            this.txtkilo.Location = new System.Drawing.Point(74, 130);
            this.txtkilo.Name = "txtkilo";
            this.txtkilo.Size = new System.Drawing.Size(100, 20);
            this.txtkilo.TabIndex = 4;
            // 
            // lbloran
            // 
            this.lbloran.AutoSize = true;
            this.lbloran.Location = new System.Drawing.Point(255, 85);
            this.lbloran.Name = "lbloran";
            this.lbloran.Size = new System.Drawing.Size(30, 13);
            this.lbloran.TabIndex = 5;
            this.lbloran.Text = "Oran";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(255, 133);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(38, 13);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "Sonuç";
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(299, 130);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(100, 20);
            this.txtsonuc.TabIndex = 7;
            // 
            // txtoran
            // 
            this.txtoran.Location = new System.Drawing.Point(299, 82);
            this.txtoran.Name = "txtoran";
            this.txtoran.Size = new System.Drawing.Size(100, 20);
            this.txtoran.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 359);
            this.Controls.Add(this.txtoran);
            this.Controls.Add(this.txtsonuc);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.lbloran);
            this.Controls.Add(this.txtkilo);
            this.Controls.Add(this.txtboy);
            this.Controls.Add(this.lblkilo);
            this.Controls.Add(this.lblboy);
            this.Controls.Add(this.btnhesapla);
            this.Name = "Form1";
            this.Text = "Vücut Kitle İndeksi Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label lblboy;
        private System.Windows.Forms.Label lblkilo;
        private System.Windows.Forms.TextBox txtboy;
        private System.Windows.Forms.TextBox txtkilo;
        private System.Windows.Forms.Label lbloran;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.TextBox txtoran;
    }
}

