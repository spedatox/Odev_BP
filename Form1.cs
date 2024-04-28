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

                    Logger.Log($"Kullan�c� giri� yapt�: {calisan.Ad} {calisan.Soyad}, Yetki: {calisan.Yetki}");

                    MessageBox.Show($"Ho�geldin {calisan.Ad} {calisan.Soyad}. Yetki: {calisan.Yetki}", "Ho�geldiniz", MessageBoxButtons.OK);


                    if (calisan.Yetki == "M�d�r")
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

                        if (calisan.Yetki != "Temizlik G�revlisi")
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
                    MessageBox.Show("Giri� Ba�ar�s�z", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            messageBuilder.AppendLine("Kullan�c� Bilgileri:");

            messageBuilder.AppendLine("M�d�r, 12345");
            messageBuilder.AppendLine("Resepsiyonist,12345");
            messageBuilder.AppendLine("Temizlikci, 12345");

            MessageBox.Show(messageBuilder.ToString(), "Kullan�c� Bilgileri", MessageBoxButtons.OK);
        }

        private void kullaniciAdiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
