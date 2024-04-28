namespace Odev_BP
{
    partial class OdaEkleUserControl
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
            lblOdaTipi = new Label();
            lblOdaFiyati = new Label();
            lblOdaDurumu = new Label();
            txtOdaTipi = new TextBox();
            txtOdaFiyati = new TextBox();
            txtOdaDurumu = new TextBox();
            btnOdaEkle = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblOdaTipi
            // 
            lblOdaTipi.AutoSize = true;
            lblOdaTipi.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold);
            lblOdaTipi.Location = new Point(56, 215);
            lblOdaTipi.Margin = new Padding(4, 0, 4, 0);
            lblOdaTipi.Name = "lblOdaTipi";
            lblOdaTipi.Size = new Size(176, 44);
            lblOdaTipi.TabIndex = 0;
            lblOdaTipi.Text = "Oda Tipi:";
            // 
            // lblOdaFiyati
            // 
            lblOdaFiyati.AutoSize = true;
            lblOdaFiyati.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold);
            lblOdaFiyati.Location = new Point(56, 293);
            lblOdaFiyati.Margin = new Padding(4, 0, 4, 0);
            lblOdaFiyati.Name = "lblOdaFiyati";
            lblOdaFiyati.Size = new Size(210, 44);
            lblOdaFiyati.TabIndex = 1;
            lblOdaFiyati.Text = "Oda Fiyatı:";
            // 
            // lblOdaDurumu
            // 
            lblOdaDurumu.AutoSize = true;
            lblOdaDurumu.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold);
            lblOdaDurumu.Location = new Point(56, 373);
            lblOdaDurumu.Margin = new Padding(4, 0, 4, 0);
            lblOdaDurumu.Name = "lblOdaDurumu";
            lblOdaDurumu.Size = new Size(257, 44);
            lblOdaDurumu.TabIndex = 2;
            lblOdaDurumu.Text = "Oda Durumu:";
            // 
            // txtOdaTipi
            // 
            txtOdaTipi.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold);
            txtOdaTipi.Location = new Point(642, 215);
            txtOdaTipi.Margin = new Padding(4, 3, 4, 3);
            txtOdaTipi.Name = "txtOdaTipi";
            txtOdaTipi.Size = new Size(314, 53);
            txtOdaTipi.TabIndex = 3;
            // 
            // txtOdaFiyati
            // 
            txtOdaFiyati.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold);
            txtOdaFiyati.Location = new Point(642, 293);
            txtOdaFiyati.Margin = new Padding(4, 3, 4, 3);
            txtOdaFiyati.Name = "txtOdaFiyati";
            txtOdaFiyati.Size = new Size(314, 53);
            txtOdaFiyati.TabIndex = 4;
            // 
            // txtOdaDurumu
            // 
            txtOdaDurumu.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold);
            txtOdaDurumu.Location = new Point(642, 373);
            txtOdaDurumu.Margin = new Padding(4, 3, 4, 3);
            txtOdaDurumu.Name = "txtOdaDurumu";
            txtOdaDurumu.Size = new Size(314, 53);
            txtOdaDurumu.TabIndex = 5;
            // 
            // btnOdaEkle
            // 
            btnOdaEkle.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdaEkle.Location = new Point(805, 504);
            btnOdaEkle.Margin = new Padding(4, 3, 4, 3);
            btnOdaEkle.Name = "btnOdaEkle";
            btnOdaEkle.Size = new Size(133, 64);
            btnOdaEkle.TabIndex = 6;
            btnOdaEkle.Text = "Oda Ekle";
            btnOdaEkle.UseVisualStyleBackColor = true;
            btnOdaEkle.Click += btnOdaEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(29, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 56);
            label1.TabIndex = 7;
            label1.Text = "Oda Ekle ";
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(29, 504);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(151, 64);
            button1.TabIndex = 8;
            button1.Text = "Oda Sorgula";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OdaEkleUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnOdaEkle);
            Controls.Add(txtOdaDurumu);
            Controls.Add(txtOdaFiyati);
            Controls.Add(txtOdaTipi);
            Controls.Add(lblOdaDurumu);
            Controls.Add(lblOdaFiyati);
            Controls.Add(lblOdaTipi);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OdaEkleUserControl";
            Size = new Size(1008, 593);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblOdaTipi;
        private System.Windows.Forms.Label lblOdaFiyati;
        private System.Windows.Forms.Label lblOdaDurumu;
        private System.Windows.Forms.TextBox txtOdaTipi;
        private System.Windows.Forms.TextBox txtOdaFiyati;
        private System.Windows.Forms.TextBox txtOdaDurumu;
        private System.Windows.Forms.Button btnOdaEkle;
        private Label label1;
        private Button button1;
    }
}