using System;
using System.Linq;
using System.Windows.Forms;
using Odev_BP.Models;

namespace Odev_BP
{
    public partial class MusteriKayitUserControl : UserControl
    {
        private readonly OtelDbContext _context;
        private musteri _musteri;
        private rezervasyon _rezervasyon;

        public MusteriKayitUserControl()
        {
            InitializeComponent();
            _context = new OtelDbContext();
        }

        private void MusteriKayitUserControl_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _musteri = new musteri
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Eposta = txtEposta.Text,
                    TelefonNumarasi = txtTelefon.Text,
                    RezDurum = "Rezervasyon",
                    TcKimlikNo = txtTcNo.Text
                };
                _context.Musteri.Add(_musteri);
                _context.SaveChanges();

                groupBoxRezervasyon.Visible = true;

                Logger.Log("Yeni müşteri kaydedildi: " + _musteri.Ad + " " + _musteri.Soyad);
            }
            catch (Exception ex)
            {
                Logger.Log("Hata oluştu: " + ex.InnerException);
                MessageBox.Show("Bir hata oluştu. Detaylar için log dosyasına bakınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezervasyonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int kisiSayisi = Convert.ToInt32(txtKisiSayisi.Text);

                var uygunOda = _context.OtelOda.FirstOrDefault(o => o.Kapasite >= kisiSayisi && o.OdaDurumu != "Rezerve");
                if (uygunOda == null)
                {
                    MessageBox.Show("Uygun oda bulunamadı.");
                    return;
                }

               
                label7.Text = $"Uygun Oda Bilgileri:\nOda Numarası: {uygunOda.OdaID}\nOda Tipi: {uygunOda.OdaTipi}\nKapasite: {uygunOda.Kapasite}\nFiyat: {uygunOda.OdaFiyati}";

                _rezervasyon = new rezervasyon
                {
                    MusteriID = _musteri.MusteriID,
                    RezervasyonTarihi = DateTime.Now,
                    OdaID = uygunOda.OdaID,
                    CheckinTarihi = dateCheckin.Value,
                    CheckoutTarihi = dateCheckout.Value
                };

                _context.Rezervasyon.Add(_rezervasyon);
                _context.SaveChanges();

                var kalanGunSayisi = (dateCheckout.Value - dateCheckin.Value).Days;
                var odemeMiktari = uygunOda.OdaFiyati * kalanGunSayisi;

                lblToplamOdeme.Text = $"Toplam Ödeme Miktarı: {odemeMiktari} TL";

                groupBoxOdeme.Visible = true;

                Logger.Log($"Yeni rezervasyon oluşturuldu: Rezervasyon ID: {_rezervasyon.RezervasyonID}, Müşteri ID: {_musteri.MusteriID}");

                
                _musteri.OdaID = uygunOda.OdaID;

               
                uygunOda.OdaDurumu = "Rezerve";
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Logger.Log($"Rezervasyon kaydetme hatası: {ex.InnerException}");
                MessageBox.Show("Bir hata oluştu. Detaylar için log dosyasına bakınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnOdemeKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var odeme = new odeme
                {
                    RezervasyonID = _rezervasyon.RezervasyonID,
                    OdemeTarihi = DateTime.Now,
                    
                };
                _context.Odeme.Add(odeme);
                _context.SaveChanges();

                MessageBox.Show("Ödeme işlemi başarıyla tamamlandı!");
                ClearFields();
            }
            catch (Exception ex)
            {
                Logger.Log($"Ödeme işlemi hatası: {ex.InnerException}");
                MessageBox.Show("Bir hata oluştu. Detaylar için log dosyasına bakınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            
            txtAd.Clear();
            txtSoyad.Clear();
            txtEposta.Clear();
            txtTelefon.Clear();
            txtTcNo.Clear();
            txtKisiSayisi.Clear();
            dateCheckin.Value = DateTime.Now;
            dateCheckout.Value = DateTime.Now;
            lblToplamOdeme.Text = "";

            
            groupBoxRezervasyon.Visible = false;
            groupBoxOdeme.Visible = false;
            label7.Text = "";
        }
    }
}