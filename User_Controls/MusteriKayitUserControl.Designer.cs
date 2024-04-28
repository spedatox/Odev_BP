namespace Odev_BP
{
    partial class MusteriKayitUserControl
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEposta = new TextBox();
            txtTelefon = new TextBox();
            txtTcNo = new TextBox();
            btnKaydet = new Button();
            groupBoxRezervasyon = new GroupBox();
            btnRezervasyonKaydet = new Button();
            dateCheckin = new DateTimePicker();
            dateCheckout = new DateTimePicker();
            lblToplamOdeme = new Label();
            groupBoxOdeme = new GroupBox();
            btnOdemeKaydet = new Button();
            txtKisiSayisi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBoxRezervasyon.SuspendLayout();
            groupBoxOdeme.SuspendLayout();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtAd.Location = new Point(229, 107);
            txtAd.Margin = new Padding(4, 3, 4, 3);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(351, 31);
            txtAd.TabIndex = 0;
    
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtSoyad.Location = new Point(229, 159);
            txtSoyad.Margin = new Padding(4, 3, 4, 3);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(351, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtEposta
            // 
            txtEposta.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtEposta.Location = new Point(229, 213);
            txtEposta.Margin = new Padding(4, 3, 4, 3);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(351, 31);
            txtEposta.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtTelefon.Location = new Point(229, 267);
            txtTelefon.Margin = new Padding(4, 3, 4, 3);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(351, 31);
            txtTelefon.TabIndex = 3;
            // 
            // txtTcNo
            // 
            txtTcNo.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtTcNo.Location = new Point(229, 327);
            txtTcNo.Margin = new Padding(4, 3, 4, 3);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(351, 31);
            txtTcNo.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(476, 461);
            btnKaydet.Margin = new Padding(4, 3, 4, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(88, 27);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // groupBoxRezervasyon
            // 
            groupBoxRezervasyon.Controls.Add(btnRezervasyonKaydet);
            groupBoxRezervasyon.Controls.Add(dateCheckin);
            groupBoxRezervasyon.Controls.Add(dateCheckout);
            groupBoxRezervasyon.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            groupBoxRezervasyon.Location = new Point(641, 51);
            groupBoxRezervasyon.Margin = new Padding(4, 3, 4, 3);
            groupBoxRezervasyon.Name = "groupBoxRezervasyon";
            groupBoxRezervasyon.Padding = new Padding(4, 3, 4, 3);
            groupBoxRezervasyon.Size = new Size(318, 242);
            groupBoxRezervasyon.TabIndex = 6;
            groupBoxRezervasyon.TabStop = false;
            groupBoxRezervasyon.Text = "Tarih Seç";
            groupBoxRezervasyon.Visible = false;
            // 
            // btnRezervasyonKaydet
            // 
            btnRezervasyonKaydet.Location = new Point(123, 184);
            btnRezervasyonKaydet.Margin = new Padding(4, 3, 4, 3);
            btnRezervasyonKaydet.Name = "btnRezervasyonKaydet";
            btnRezervasyonKaydet.Size = new Size(159, 27);
            btnRezervasyonKaydet.TabIndex = 7;
            btnRezervasyonKaydet.Text = "Rezervasyon Kaydet";
            btnRezervasyonKaydet.UseVisualStyleBackColor = true;
            btnRezervasyonKaydet.Click += btnRezervasyonKaydet_Click;
            // 
            // dateCheckin
            // 
            dateCheckin.Location = new Point(19, 77);
            dateCheckin.Margin = new Padding(4, 3, 4, 3);
            dateCheckin.Name = "dateCheckin";
            dateCheckin.Size = new Size(263, 31);
            dateCheckin.TabIndex = 8;
            // 
            // dateCheckout
            // 
            dateCheckout.Location = new Point(19, 128);
            dateCheckout.Margin = new Padding(4, 3, 4, 3);
            dateCheckout.Name = "dateCheckout";
            dateCheckout.Size = new Size(263, 31);
            dateCheckout.TabIndex = 9;
            // 
            // lblToplamOdeme
            // 
            lblToplamOdeme.AutoSize = true;
            lblToplamOdeme.Location = new Point(19, 63);
            lblToplamOdeme.Margin = new Padding(4, 0, 4, 0);
            lblToplamOdeme.Name = "lblToplamOdeme";
            lblToplamOdeme.Size = new Size(176, 23);
            lblToplamOdeme.TabIndex = 10;
            lblToplamOdeme.Text = "Toplam Ödeme: 0";
            // 
            // groupBoxOdeme
            // 
            groupBoxOdeme.Controls.Add(btnOdemeKaydet);
            groupBoxOdeme.Controls.Add(lblToplamOdeme);
            groupBoxOdeme.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            groupBoxOdeme.Location = new Point(641, 373);
            groupBoxOdeme.Margin = new Padding(4, 3, 4, 3);
            groupBoxOdeme.Name = "groupBoxOdeme";
            groupBoxOdeme.Padding = new Padding(4, 3, 4, 3);
            groupBoxOdeme.Size = new Size(318, 167);
            groupBoxOdeme.TabIndex = 11;
            groupBoxOdeme.TabStop = false;
            groupBoxOdeme.Text = "Ödemeyi Kaydet";
            groupBoxOdeme.Visible = false;
            // 
            // btnOdemeKaydet
            // 
            btnOdemeKaydet.Location = new Point(96, 112);
            btnOdemeKaydet.Margin = new Padding(4, 3, 4, 3);
            btnOdemeKaydet.Name = "btnOdemeKaydet";
            btnOdemeKaydet.Size = new Size(159, 27);
            btnOdemeKaydet.TabIndex = 12;
            btnOdemeKaydet.Text = "Ödeme Kaydet";
            btnOdemeKaydet.UseVisualStyleBackColor = true;
            btnOdemeKaydet.Click += btnOdemeKaydet_Click;
            // 
            // txtKisiSayisi
            // 
            txtKisiSayisi.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtKisiSayisi.Location = new Point(229, 388);
            txtKisiSayisi.Margin = new Padding(4, 3, 4, 3);
            txtKisiSayisi.Name = "txtKisiSayisi";
            txtKisiSayisi.Size = new Size(351, 31);
            txtKisiSayisi.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(149, 110);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label2.Location = new Point(117, 162);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 13;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label3.Location = new Point(116, 216);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 14;
            label3.Text = "E Posta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label4.Location = new Point(111, 270);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 15;
            label4.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label5.Location = new Point(56, 330);
            label5.Name = "label5";
            label5.Size = new Size(140, 23);
            label5.TabIndex = 16;
            label5.Text = "T.C. Kimlik No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label6.Location = new Point(94, 391);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 17;
            label6.Text = "Kişi Sayısı:";
        
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label7.Location = new Point(149, 448);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 23);
            label7.TabIndex = 13;

            // 
            // MusteriKayitUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtKisiSayisi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(txtEposta);
            Controls.Add(groupBoxOdeme);
            Controls.Add(txtTelefon);
            Controls.Add(txtTcNo);
            Controls.Add(groupBoxRezervasyon);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MusteriKayitUserControl";
            Size = new Size(1008, 620);
            Load += MusteriKayitUserControl_Load;
            groupBoxRezervasyon.ResumeLayout(false);
            groupBoxOdeme.ResumeLayout(false);
            groupBoxOdeme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBoxRezervasyon;
        private System.Windows.Forms.Button btnRezervasyonKaydet;
        private System.Windows.Forms.DateTimePicker dateCheckin;
        private System.Windows.Forms.DateTimePicker dateCheckout;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.GroupBox groupBoxOdeme;
        private System.Windows.Forms.Button btnOdemeKaydet;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
