using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odev_BP.Calisan
{
    public interface ICalisanService
    {
        List<Odev_BP.Models.calisan> GetAll();
        void Add(Odev_BP.Models.calisan calisan);
        void Delete(Odev_BP.Models.calisan calisan);
        void Update(Odev_BP.Models.calisan calisan);
    }
}
