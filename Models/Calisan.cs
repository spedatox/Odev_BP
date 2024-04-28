using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Models
{
    public class calisan:IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yetki { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
