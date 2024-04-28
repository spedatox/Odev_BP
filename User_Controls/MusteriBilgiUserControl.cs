using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Odev_BP.Models;

namespace Odev_BP
{
    public partial class MusteriBilgiUserControl : UserControl
    {
        private readonly OtelDbContext _context;

        public MusteriBilgiUserControl()
        {
            InitializeComponent();
            _context = new OtelDbContext();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
            string aramaMetni = txtArama.Text.ToLower();

            List<musteri> musteriListesi = _context.Musteri
                .Where(m => m.Ad.ToLower().Contains(aramaMetni) || m.Soyad.ToLower().Contains(aramaMetni))
                .ToList();

            dgvMusteriler.DataSource = musteriListesi;
        }

        private void MusteriBilgiUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
