namespace Pansiyon
{
    partial class FrmGelirGider
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonelMaas = new System.Windows.Forms.Label();
            this.lblKasaToplam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAlınanUrunlerınTutarı = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFaturalar1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Sonuc = new System.Windows.Forms.Label();
            this.lblAlinan3 = new System.Windows.Forms.Label();
            this.lblAlinan2 = new System.Windows.Forms.Label();
            this.lblFaturalar2 = new System.Windows.Forms.Label();
            this.lblFaturalar3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Toplam Tutar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Maaşları:";
            // 
            // lblPersonelMaas
            // 
            this.lblPersonelMaas.AutoSize = true;
            this.lblPersonelMaas.Location = new System.Drawing.Point(182, 119);
            this.lblPersonelMaas.Name = "lblPersonelMaas";
            this.lblPersonelMaas.Size = new System.Drawing.Size(19, 13);
            this.lblPersonelMaas.TabIndex = 2;
            this.lblPersonelMaas.Text = "00";
            // 
            // lblKasaToplam
            // 
            this.lblKasaToplam.AutoSize = true;
            this.lblKasaToplam.Location = new System.Drawing.Point(182, 74);
            this.lblKasaToplam.Name = "lblKasaToplam";
            this.lblKasaToplam.Size = new System.Drawing.Size(19, 13);
            this.lblKasaToplam.TabIndex = 3;
            this.lblKasaToplam.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alınan Ürünlerin Tutarı:";
            // 
            // lblAlınanUrunlerınTutarı
            // 
            this.lblAlınanUrunlerınTutarı.AutoSize = true;
            this.lblAlınanUrunlerınTutarı.Location = new System.Drawing.Point(182, 158);
            this.lblAlınanUrunlerınTutarı.Name = "lblAlınanUrunlerınTutarı";
            this.lblAlınanUrunlerınTutarı.Size = new System.Drawing.Size(19, 13);
            this.lblAlınanUrunlerınTutarı.TabIndex = 5;
            this.lblAlınanUrunlerınTutarı.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Faturalar:";
            // 
            // lblFaturalar1
            // 
            this.lblFaturalar1.AutoSize = true;
            this.lblFaturalar1.Location = new System.Drawing.Point(182, 200);
            this.lblFaturalar1.Name = "lblFaturalar1";
            this.lblFaturalar1.Size = new System.Drawing.Size(19, 13);
            this.lblFaturalar1.TabIndex = 7;
            this.lblFaturalar1.Text = "00";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Personel Sayısı:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(411, 271);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(144, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(45, 281);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "Sonuç";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "-------------------------------------------------------";
            // 
            // Sonuc
            // 
            this.Sonuc.AutoSize = true;
            this.Sonuc.Location = new System.Drawing.Point(140, 281);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(19, 13);
            this.Sonuc.TabIndex = 13;
            this.Sonuc.Text = "00";
            // 
            // lblAlinan3
            // 
            this.lblAlinan3.AutoSize = true;
            this.lblAlinan3.Location = new System.Drawing.Point(372, 158);
            this.lblAlinan3.Name = "lblAlinan3";
            this.lblAlinan3.Size = new System.Drawing.Size(19, 13);
            this.lblAlinan3.TabIndex = 14;
            this.lblAlinan3.Text = "00";
            // 
            // lblAlinan2
            // 
            this.lblAlinan2.AutoSize = true;
            this.lblAlinan2.Location = new System.Drawing.Point(288, 158);
            this.lblAlinan2.Name = "lblAlinan2";
            this.lblAlinan2.Size = new System.Drawing.Size(19, 13);
            this.lblAlinan2.TabIndex = 15;
            this.lblAlinan2.Text = "00";
            // 
            // lblFaturalar2
            // 
            this.lblFaturalar2.AutoSize = true;
            this.lblFaturalar2.Location = new System.Drawing.Point(288, 200);
            this.lblFaturalar2.Name = "lblFaturalar2";
            this.lblFaturalar2.Size = new System.Drawing.Size(19, 13);
            this.lblFaturalar2.TabIndex = 16;
            this.lblFaturalar2.Text = "00";
            // 
            // lblFaturalar3
            // 
            this.lblFaturalar3.AutoSize = true;
            this.lblFaturalar3.Location = new System.Drawing.Point(372, 200);
            this.lblFaturalar3.Name = "lblFaturalar3";
            this.lblFaturalar3.Size = new System.Drawing.Size(19, 13);
            this.lblFaturalar3.TabIndex = 17;
            this.lblFaturalar3.Text = "00";
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFaturalar3);
            this.Controls.Add(this.lblFaturalar2);
            this.Controls.Add(this.lblAlinan2);
            this.Controls.Add(this.lblAlinan3);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFaturalar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlınanUrunlerınTutarı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKasaToplam);
            this.Controls.Add(this.lblPersonelMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGelirGider";
            this.Text = "FrmGelirGider";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonelMaas;
        private System.Windows.Forms.Label lblKasaToplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAlınanUrunlerınTutarı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFaturalar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Sonuc;
        private System.Windows.Forms.Label lblAlinan3;
        private System.Windows.Forms.Label lblAlinan2;
        private System.Windows.Forms.Label lblFaturalar2;
        private System.Windows.Forms.Label lblFaturalar3;
    }
}