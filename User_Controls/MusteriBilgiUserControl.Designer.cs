namespace Odev_BP
{
    partial class MusteriBilgiUserControl
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
            dgvMusteriler = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(3, 251);
            label1.Name = "label1";
            label1.Size = new Size(263, 25);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Adı veya Soyadı:";
            // 
            // txtArama
            // 
            txtArama.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtArama.Location = new Point(272, 249);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(170, 27);
            txtArama.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.Location = new Point(179, 316);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(87, 46);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(448, 127);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.Size = new Size(532, 437);
            dgvMusteriler.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(368, 56);
            label2.TabIndex = 5;
            label2.Text = "Müşteri Bilgileri";
            // 
            // MusteriBilgiUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(dgvMusteriler);
            Controls.Add(btnAra);
            Controls.Add(txtArama);
            Controls.Add(label1);
            Name = "MusteriBilgiUserControl";
            Size = new Size(1008, 593);
            Load += MusteriBilgiUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private Label label2;
    }
}
