using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Models
{
    public class rezervasyon : IEntity

    {
        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public DateTime CheckinTarihi { get; set; }
        public DateTime CheckoutTarihi { get; set; }

        public virtual musteri Musteri { get; set; }
        public virtual otelOda OtelOda { get; set; }
        public virtual ICollection<odeme> Odemeler { get; set; }
    }

}
