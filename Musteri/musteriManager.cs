using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Musteri
{

    public class musteriManager : IMusteriService

    {
        private IMusteriDal _musteriDal;
        public musteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }
        public void Add(Odev_BP.Models.musteri musteriDal)
        {
            _musteriDal.Add(musteriDal);
        }



        public void Delete(Odev_BP.Models.musteri musteriDal)
        {
            _musteriDal.Delete(musteriDal);
        }



        public List<Odev_BP.Models.musteri> GetAll()
        {
            return _musteriDal.GetAll();
        }

        public void Update(Odev_BP.Models.musteri musteriDal)
        {
            _musteriDal.Update(musteriDal);
        }


    }
}
