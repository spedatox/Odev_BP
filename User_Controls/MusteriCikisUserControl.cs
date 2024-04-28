using System;
using System.Linq;
using System.Windows.Forms;

namespace Odev_BP
{
    public partial class MusteriCikisUserControl : UserControl
    {
        private readonly OtelDbContext _context;

        public MusteriCikisUserControl()
        {
            InitializeComponent();
            _context = new OtelDbContext();
        }

        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
            string tcKimlikNo = txtMusteriTc.Text.Trim();

            if (!IsValidTCKimlikNo(tcKimlikNo))
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası giriniz.");
                return;
            }

            var musteri = _context.Musteri.FirstOrDefault(m => m.TcKimlikNo == tcKimlikNo);

            if (musteri != null)
            {
                musteri.RezDurum = "Giriş"; 

                _context.SaveChanges();

                MessageBox.Show("Müşteri girişi başarıyla gerçekleştirildi!");
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı!");
            }
        }

        private void btnMusteriCikis_Click(object sender, EventArgs e)
        {
            string musteriTc = txtMusteriTcCikis.Text.Trim();

            if (!IsValidTCKimlikNo(musteriTc))
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası giriniz.");
                return;
            }

            var musteri = _context.Musteri.FirstOrDefault(m => m.TcKimlikNo == musteriTc);

            if (musteri != null)
            {
                musteri.RezDurum = "Çıkış";
                _context.SaveChanges();

                var oda = _context.OtelOda.FirstOrDefault(o => o.OdaID == musteri.OdaID);

                if (oda != null)
                {
                    oda.OdaDurumu = "Müsait";
                    _context.SaveChanges();
                }

                MessageBox.Show("Müşteri çıkış işlemi başarıyla gerçekleştirildi!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı!");
            }
        }



        private void ClearFields()
        {
            txtMusteriTc.Clear(); 
            txtMusteriTcCikis.Clear(); 
        }

        private bool IsValidTCKimlikNo(string tcKimlikNo)
        {
            if (tcKimlikNo.Length != 11)
                return false;

            return tcKimlikNo.All(char.IsDigit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musteriTcsi = textBox1.Text.Trim();

            if (!IsValidTCKimlikNo(musteriTcsi))
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası giriniz.");
                return;
            }

            var musteri = _context.Musteri.FirstOrDefault(m => m.TcKimlikNo == musteriTcsi);

            if (musteri != null)
            {
                musteri.RezDurum = "İptal";
                _context.SaveChanges();

               
                var oda = _context.OtelOda.FirstOrDefault(o => o.OdaID == musteri.OdaID);
                if (oda != null)
                {
                    oda.OdaDurumu = "Müsait";
                    _context.SaveChanges();
                }

                MessageBox.Show("Müşteri rezervasyon iptal başarıyla gerçekleştirildi!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string musteriTcsi = textBox1.Text.Trim();

            if (!IsValidTCKimlikNo(musteriTcsi))
            {
                MessageBox.Show("Geçerli bir TC kimlik numarası giriniz.");
                return;
            }

            var musteri = _context.Musteri.FirstOrDefault(m => m.TcKimlikNo == musteriTcsi);

            if (musteri != null)
            {
                musteri.RezDurum = "İptal";
                _context.SaveChanges();

                
                var oda = _context.OtelOda.FirstOrDefault(o => o.OdaID == musteri.OdaID);
                if (oda != null)
                {
                    oda.OdaDurumu = "Müsait";
                    _context.SaveChanges();
                }

                MessageBox.Show("Müşteri rezervasyon iptal başarıyla gerçekleştirildi!");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Müşteri bulunamadı!");
            }
        }

        private void MusteriCikisUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
