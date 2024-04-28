namespace Odev_BP
{
    partial class MusteriCikisUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up all resources being used.
        /// </summary>
        /// <param name="disposing">True if the managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMusteriGiris = new Button();
            btnMusteriCikis = new Button();
            txtMusteriTc = new TextBox();
            txtMusteriTcCikis = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnMusteriGiris
            // 
            btnMusteriGiris.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMusteriGiris.Location = new Point(699, 140);
            btnMusteriGiris.Margin = new Padding(4, 3, 4, 3);
            btnMusteriGiris.Name = "btnMusteriGiris";
            btnMusteriGiris.Size = new Size(175, 58);
            btnMusteriGiris.TabIndex = 0;
            btnMusteriGiris.Text = "Müşteri Giriş";
            btnMusteriGiris.UseVisualStyleBackColor = true;
            btnMusteriGiris.Click += btnMusteriGiris_Click;
            // 
            // btnMusteriCikis
            // 
            btnMusteriCikis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMusteriCikis.Location = new Point(699, 263);
            btnMusteriCikis.Margin = new Padding(4, 3, 4, 3);
            btnMusteriCikis.Name = "btnMusteriCikis";
            btnMusteriCikis.Size = new Size(175, 58);
            btnMusteriCikis.TabIndex = 1;
            btnMusteriCikis.Text = "Müşteri Çıkış";
            btnMusteriCikis.UseVisualStyleBackColor = true;
            btnMusteriCikis.Click += btnMusteriCikis_Click;
            // 
            // txtMusteriTc
            // 
            txtMusteriTc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtMusteriTc.Location = new Point(380, 157);
            txtMusteriTc.Margin = new Padding(4, 3, 4, 3);
            txtMusteriTc.Name = "txtMusteriTc";
            txtMusteriTc.Size = new Size(291, 26);
            txtMusteriTc.TabIndex = 2;
            // 
            // txtMusteriTcCikis
            // 
            txtMusteriTcCikis.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtMusteriTcCikis.Location = new Point(380, 279);
            txtMusteriTcCikis.Margin = new Padding(4, 3, 4, 3);
            txtMusteriTcCikis.Name = "txtMusteriTcCikis";
            txtMusteriTcCikis.Size = new Size(291, 26);
            txtMusteriTcCikis.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(380, 400);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 26);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(699, 384);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(175, 58);
            button1.TabIndex = 4;
            button1.Text = "Rezervasyon İptal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(220, 160);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 6;
            label1.Text = "T.C. Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(220, 282);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 7;
            label2.Text = "T.C. Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(220, 403);
            label3.Name = "label3";
            label3.Size = new Size(117, 19);
            label3.TabIndex = 7;
            label3.Text = "T.C. Kimlik No:";
            // 
            // MusteriCikisUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(txtMusteriTcCikis);
            Controls.Add(txtMusteriTc);
            Controls.Add(btnMusteriCikis);
            Controls.Add(btnMusteriGiris);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MusteriCikisUserControl";
            Size = new Size(1008, 593);
            Load += MusteriCikisUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnMusteriGiris;
        private System.Windows.Forms.Button btnMusteriCikis;
        private System.Windows.Forms.TextBox txtMusteriTc;
        private System.Windows.Forms.TextBox txtMusteriTcCikis;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
