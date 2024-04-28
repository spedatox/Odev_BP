using System;
using System.Linq;
using System.Windows.Forms;
using Odev_BP.Models;

namespace Odev_BP
{
    public partial class RoomStatusForm : Form
    {
        private readonly OtelDbContext _context;

        public RoomStatusForm()
        {
            InitializeComponent();
            _context = new OtelDbContext();
            PopulateRoomStatusComboBox();
            LoadRooms();
        }

        private void PopulateRoomStatusComboBox()
        {
            cmbRoomStatus.Items.Add("Rezerve");
            cmbRoomStatus.Items.Add("Müsait");
            cmbRoomStatus.SelectedIndex = 0;
        }

        private void LoadRooms()
        {
            string selectedStatus = cmbRoomStatus.SelectedItem.ToString();
            var rooms = _context.OtelOda
                .Where(o => o.OdaDurumu == selectedStatus)
                .Select(o => new
                {
                    OdaID = o.OdaID,
                    Kapasite = o.Kapasite,
                    OdaFiyati = o.OdaFiyati,
                    OdaDurumu = o.OdaDurumu
                })
                .ToList();
            dgvRooms.DataSource = rooms;
            // DataGridView'e veri bağlama
            dgvRooms.DataSource = rooms;

            // OdaID sütununu Oda Numarası olarak gösterme
            dgvRooms.Columns["OdaID"].HeaderText = "Oda Numarası";
        }

        private void cmbRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void RoomStatusForm_Load(object sender, EventArgs e)
        {
            dgvRooms.Columns["OdaID"].HeaderText = "Oda Numarası"; // Sütun başlığını güncelle
            dgvRooms.Columns.Remove("Rezervasyon"); // Rezervasyon sütununu kaldır
        }
    }
}
