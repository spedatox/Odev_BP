using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Foreign key için eklenen kütüphane
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Models
{
    public class musteri : IEntity
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
        public string TelefonNumarasi { get; set; }
        public string TcKimlikNo { get; set; }
        public string RezDurum { get; set; }

        [ForeignKey("OtelOda")] // Foreign key annotation
        public int OdaID { get; set; } // OdaID foreign key

        public virtual ICollection<rezervasyon> Rezervasyon { get; set; }
    }
}
