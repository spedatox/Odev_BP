using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odev_BP.Models;
using System;
using System.Windows.Forms;

namespace Odev_BP
{
    public partial class OdaEkleUserControl : UserControl
    {
        private OtelDbContext context;

        public OdaEkleUserControl()
        {
            InitializeComponent();

            context = new OtelDbContext();
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {

            string odaTipi = txtOdaTipi.Text;
            decimal odaFiyati = decimal.Parse(txtOdaFiyati.Text);
            string odaDurumu = txtOdaDurumu.Text;

            OdaEkle(odaTipi, odaFiyati, odaDurumu);

            Temizle();
        }

        private void OdaEkle(string odaTipi, decimal odaFiyati, string odaDurumu)
        {
            try
            {
                var yeniOda = new otelOda
                {
                    OdaTipi = odaTipi,
                    OdaFiyati = odaFiyati,
                    OdaDurumu = odaDurumu
                };

                context.OtelOda.Add(yeniOda);
                context.SaveChanges();

                MessageBox.Show("Oda başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtOdaTipi.Clear();
            txtOdaFiyati.Clear();
            txtOdaDurumu.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomStatusForm roomStatusForm = new RoomStatusForm();
            roomStatusForm.Show();
        }
    }
}
