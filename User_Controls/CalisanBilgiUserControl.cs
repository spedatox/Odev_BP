using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Odev_BP.Models;

namespace Odev_BP
{
    public partial class CalisanBilgiUserControl : UserControl
    {
        private readonly OtelDbContext _context;

        public CalisanBilgiUserControl()
        {
            InitializeComponent();
            _context = new OtelDbContext();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.ToLower();

            List<calisan> calisanListesi = _context.Calisan
                .Where(c => c.Ad.ToLower().Contains(aramaMetni) || c.Soyad.ToLower().Contains(aramaMetni))
                .ToList();

            dgvCalisanlar.DataSource = calisanListesi;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalisanBilgiUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
