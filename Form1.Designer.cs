namespace Odev_BP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OdaButon = new Button();
            MusteriKayButon = new Button();
            CikisButon = new Button();
            MusteriBilButon = new Button();
            CalisanBilButon = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            sifreTextBox = new TextBox();
            kullaniciAdiTextBox = new TextBox();
            GirisButon = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OdaButon
            // 
            OdaButon.Location = new Point(57, 34);
            OdaButon.Name = "OdaButon";
            OdaButon.Size = new Size(119, 50);
            OdaButon.TabIndex = 0;
            OdaButon.Text = "ODA EKLE";
            OdaButon.UseVisualStyleBackColor = true;
            OdaButon.Click += OdaButon_Click;
            // 
            // MusteriKayButon
            // 
            MusteriKayButon.Location = new Point(317, 34);
            MusteriKayButon.Name = "MusteriKayButon";
            MusteriKayButon.Size = new Size(119, 50);
            MusteriKayButon.TabIndex = 1;
            MusteriKayButon.Text = "MÜŞTERİ KAYIT";
            MusteriKayButon.UseVisualStyleBackColor = true;
            MusteriKayButon.Click += MusteriKayButon_Click;
            // 
            // CikisButon
            // 
            CikisButon.Location = new Point(599, 34);
            CikisButon.Name = "CikisButon";
            CikisButon.Size = new Size(119, 50);
            CikisButon.TabIndex = 2;
            CikisButon.Text = "MÜŞTERİ GİRİŞ ÇIKIŞ İŞLEMLERİ";
            CikisButon.UseVisualStyleBackColor = true;
            CikisButon.Click += CikisButon_Click;
            // 
            // MusteriBilButon
            // 
            MusteriBilButon.Location = new Point(871, 34);
            MusteriBilButon.Name = "MusteriBilButon";
            MusteriBilButon.Size = new Size(119, 50);
            MusteriBilButon.TabIndex = 3;
            MusteriBilButon.Text = "MÜŞTERİ BİLGİLERİ";
            MusteriBilButon.UseVisualStyleBackColor = true;
            MusteriBilButon.Click += MusteriBilButon_Click;
            // 
            // CalisanBilButon
            // 
            CalisanBilButon.Location = new Point(1157, 34);
            CalisanBilButon.Name = "CalisanBilButon";
            CalisanBilButon.Size = new Size(119, 50);
            CalisanBilButon.TabIndex = 4;
            CalisanBilButon.Text = "ÇALIŞAN BİLGİLERİ";
            CalisanBilButon.UseVisualStyleBackColor = true;
            CalisanBilButon.Click += CalisanBilButon_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sifreTextBox);
            panel1.Controls.Add(kullaniciAdiTextBox);
            panel1.Controls.Add(GirisButon);
            panel1.Location = new Point(57, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 593);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold);
            label2.Location = new Point(299, 373);
            label2.Name = "label2";
            label2.Size = new Size(73, 36);
            label2.TabIndex = 10;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold);
            label1.Location = new Point(292, 282);
            label1.Name = "label1";
            label1.Size = new Size(188, 36);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Adı";
            // 
            // sifreTextBox
            // 
            sifreTextBox.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sifreTextBox.Location = new Point(622, 366);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.PasswordChar = '*';
            sifreTextBox.Size = new Size(244, 43);
            sifreTextBox.TabIndex = 8;
            // 
            // kullaniciAdiTextBox
            // 
            kullaniciAdiTextBox.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold);
            kullaniciAdiTextBox.Location = new Point(622, 279);
            kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            kullaniciAdiTextBox.Size = new Size(244, 43);
            kullaniciAdiTextBox.TabIndex = 7;
            kullaniciAdiTextBox.TextChanged += kullaniciAdiTextBox_TextChanged;
            // 
            // GirisButon
            // 
            GirisButon.Location = new Point(559, 487);
            GirisButon.Name = "GirisButon";
            GirisButon.Size = new Size(119, 50);
            GirisButon.TabIndex = 6;
            GirisButon.Text = "Giriş";
            GirisButon.UseVisualStyleBackColor = true;
            GirisButon.Click += GirisButon_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1243, 732);
            button1.Name = "button1";
            button1.Size = new Size(93, 29);
            button1.TabIndex = 11;
            button1.Text = "Giriş Bilgileri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 761);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(CalisanBilButon);
            Controls.Add(MusteriBilButon);
            Controls.Add(CikisButon);
            Controls.Add(MusteriKayButon);
            Controls.Add(OdaButon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TATİL YÖNETİM SİSTEMİ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button OdaButon;
        private Button MusteriKayButon;
        private Button CikisButon;
        private Button MusteriBilButon;
        private Button CalisanBilButon;
        private Panel panel1;
        private Button GirisButon;
        private TextBox sifreTextBox;
        private TextBox kullaniciAdiTextBox;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
