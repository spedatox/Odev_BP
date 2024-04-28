using System.Text;

namespace Odev_BP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OdaButon.Enabled = false;
            MusteriKayButon.Enabled = false;
            CikisButon.Enabled = false;
            MusteriBilButon.Enabled = false;
            CalisanBilButon.Enabled = false;
        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiTextBox.Text;
            string sifre = sifreTextBox.Text;

            KontrolEtVeYetkileriAyarla(kullaniciAdi, sifre);

        }



        private void KontrolEtVeYetkileriAyarla(string kullaniciAdi, string sifre)
        {
            using (var dbContext = new OtelDbContext())
            {
                var calisan = dbContext.Calisan.SingleOrDefault(c => c.KullaniciAdi == kullaniciAdi && c.Sifre == sifre);

                if (calisan != null)
                {

                    Logger.Log($"Kullanýcý giriþ yaptý: {calisan.Ad} {calisan.Soyad}, Yetki: {calisan.Yetki}");

                    MessageBox.Show($"Hoþgeldin {calisan.Ad} {calisan.Soyad}. Yetki: {calisan.Yetki}", "Hoþgeldiniz", MessageBoxButtons.OK);


                    if (calisan.Yetki == "Müdür")
                    {
                        MusteriBilButon.Enabled = true;
                        CalisanBilButon.Enabled = true;
                        OdaButon.Enabled = true;
                        MusteriKayButon.Enabled = true;
                        CikisButon.Enabled = true;
                    }
                    else
                    {
                        MusteriBilButon.Enabled = false;
                        CalisanBilButon.Enabled = false;
                        OdaButon.Enabled = true;

                        if (calisan.Yetki != "Temizlik Görevlisi")
                        {
                            MusteriKayButon.Enabled = true;
                            CikisButon.Enabled = true;
                        }
                        else
                        {
                            MusteriKayButon.Enabled = false;
                            CikisButon.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Giriþ Baþarýsýz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void DisplayUserControl(UserControl userControl)
        {

            panel1.Controls.Clear();

            panel1.Controls.Add(userControl);

            userControl.Dock = DockStyle.Fill;
        }

        private void OdaButon_Click(object sender, EventArgs e)
        {
            OdaEkleUserControl odaEkleUserControl = new OdaEkleUserControl();
            DisplayUserControl(odaEkleUserControl);
        }

        private void MusteriKayButon_Click(object sender, EventArgs e)
        {
            MusteriKayitUserControl musteriKayitUserControl = new MusteriKayitUserControl();
            DisplayUserControl(musteriKayitUserControl);
        }

        private void CikisButon_Click(object sender, EventArgs e)
        {
            MusteriCikisUserControl musteriCikisUserControl = new MusteriCikisUserControl();
            DisplayUserControl(musteriCikisUserControl);
        }

        private void MusteriBilButon_Click(object sender, EventArgs e)
        {
            MusteriBilgiUserControl musteriBilgiUserControl = new MusteriBilgiUserControl();
            DisplayUserControl(musteriBilgiUserControl);
        }

        private void CalisanBilButon_Click(object sender, EventArgs e)
        {
            CalisanBilgiUserControl CalisanBilgiUserControl = new CalisanBilgiUserControl();
            DisplayUserControl(CalisanBilgiUserControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();


            messageBuilder.AppendLine("Kullanýcý Bilgileri:");

            messageBuilder.AppendLine("Müdür, 12345");
            messageBuilder.AppendLine("Resepsiyonist,12345");
            messageBuilder.AppendLine("Temizlikci, 12345");

            MessageBox.Show(messageBuilder.ToString(), "Kullanýcý Bilgileri", MessageBoxButtons.OK);
        }

        private void kullaniciAdiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
