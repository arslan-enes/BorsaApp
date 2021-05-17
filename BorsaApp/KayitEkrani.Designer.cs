namespace BorsaApp
{
    partial class KayitEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.KullaniciAdiText = new System.Windows.Forms.TextBox();
            this.AdText = new System.Windows.Forms.TextBox();
            this.SoyadText = new System.Windows.Forms.TextBox();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.TCKNOText = new System.Windows.Forms.TextBox();
            this.TelefonText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.AdresText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yetki";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Alıcı",
            "Satıcı"});
            this.comboBox1.Location = new System.Drawing.Point(271, 312);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Şifre :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "TC Kimlik No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefon :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Adres : ";
            // 
            // KullaniciAdiText
            // 
            this.KullaniciAdiText.Location = new System.Drawing.Point(271, 40);
            this.KullaniciAdiText.Name = "KullaniciAdiText";
            this.KullaniciAdiText.Size = new System.Drawing.Size(100, 22);
            this.KullaniciAdiText.TabIndex = 11;
            // 
            // AdText
            // 
            this.AdText.Location = new System.Drawing.Point(271, 71);
            this.AdText.Name = "AdText";
            this.AdText.Size = new System.Drawing.Size(100, 22);
            this.AdText.TabIndex = 12;
            // 
            // SoyadText
            // 
            this.SoyadText.Location = new System.Drawing.Point(271, 106);
            this.SoyadText.Name = "SoyadText";
            this.SoyadText.Size = new System.Drawing.Size(100, 22);
            this.SoyadText.TabIndex = 13;
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(271, 146);
            this.SifreText.Name = "SifreText";
            this.SifreText.Size = new System.Drawing.Size(100, 22);
            this.SifreText.TabIndex = 14;
            // 
            // TCKNOText
            // 
            this.TCKNOText.Location = new System.Drawing.Point(271, 177);
            this.TCKNOText.Name = "TCKNOText";
            this.TCKNOText.Size = new System.Drawing.Size(100, 22);
            this.TCKNOText.TabIndex = 15;
            // 
            // TelefonText
            // 
            this.TelefonText.Location = new System.Drawing.Point(271, 211);
            this.TelefonText.Name = "TelefonText";
            this.TelefonText.Size = new System.Drawing.Size(100, 22);
            this.TelefonText.TabIndex = 16;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(271, 243);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(100, 22);
            this.EmailText.TabIndex = 17;
            // 
            // AdresText
            // 
            this.AdresText.Location = new System.Drawing.Point(271, 278);
            this.AdresText.Name = "AdresText";
            this.AdresText.Size = new System.Drawing.Size(100, 22);
            this.AdresText.TabIndex = 18;
            // 
            // KayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.AdresText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.TelefonText);
            this.Controls.Add(this.TCKNOText);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.SoyadText);
            this.Controls.Add(this.AdText);
            this.Controls.Add(this.KullaniciAdiText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "KayitEkrani";
            this.Text = "KayitEkrani";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox KullaniciAdiText;
        private System.Windows.Forms.TextBox SoyadText;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.TextBox TCKNOText;
        private System.Windows.Forms.TextBox TelefonText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox AdresText;
        public System.Windows.Forms.TextBox AdText;
    }
}

