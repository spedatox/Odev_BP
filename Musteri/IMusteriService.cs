using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odev_BP.Musteri
{
    public interface IMusteriService
    {
        List<Odev_BP.Models.musteri> GetAll();
        void Add(Odev_BP.Models.musteri musteri);
        void Delete(Odev_BP.Models.musteri musteri);
        void Update(Odev_BP.Models.musteri musteri);
    }
}
