namespace Odev_BP
{
    partial class CalisanBilgiUserControl
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
            label1 = new Label();
            txtArama = new TextBox();
            btnAra = new Button();
            dgvCalisanlar = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            label1.Location = new Point(17, 255);
            label1.Name = "label1";
            label1.Size = new Size(243, 23);
            label1.TabIndex = 0;
            label1.Text = "Çalışan Adı veya Soyadı:";
            label1.Click += label1_Click;
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            txtArama.Location = new Point(280, 252);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(150, 31);
            txtArama.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnAra.Location = new Point(168, 333);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(111, 45);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(451, 86);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.Size = new Size(540, 419);
            dgvCalisanlar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(378, 56);
            label2.TabIndex = 4;
            label2.Text = "Çalışan Bilgileri";
            // 
            // CalisanBilgiUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(dgvCalisanlar);
            Controls.Add(btnAra);
            Controls.Add(txtArama);
            Controls.Add(label1);
            Name = "CalisanBilgiUserControl";
            Size = new Size(1008, 593);
            Load += CalisanBilgiUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private Label label2;
    }
}
