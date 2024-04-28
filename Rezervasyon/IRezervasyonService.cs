using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odev_BP.Rezervasyon
{
    public interface IRezervasyonService
    {
        List<Odev_BP.Models.rezervasyon> GetAll();
        void Add(Odev_BP.Models.rezervasyon rezervasyon);
        void Delete(Odev_BP.Models.rezervasyon rezervasyon);
        void Update(Odev_BP.Models.rezervasyon rezervasyon);
    }
}
