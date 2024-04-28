using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Odev_BP.Models
{
    public class odeme : IEntity
    {
        public int ID { get; set; }
        public int RezervasyonID { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public decimal OdemeMiktari { get; set; }

        [ForeignKey("RezervasyonID")]
        public virtual rezervasyon Rezervasyon { get; set; }

       
        [NotMapped]
        public string MusteriAdSoyad => Rezervasyon?.Musteri?.Ad + " " + Rezervasyon?.Musteri?.Soyad;
    }
}