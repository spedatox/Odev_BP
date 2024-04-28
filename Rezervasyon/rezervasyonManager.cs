using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Rezervasyon
{

    public class rezervasyonManager : IRezervasyonService

    {
        private IrezervasyonDal _rezervasyonDal;
        public rezervasyonManager(IrezervasyonDal RezervasyonDal)
        {
            _rezervasyonDal = RezervasyonDal;
        }
        public void Add(Odev_BP.Models.rezervasyon RezervasyonDal)
        {
            _rezervasyonDal.Add(RezervasyonDal);
        }

       

        public void Delete(Odev_BP.Models.rezervasyon RezervasyonDal)
        {
            _rezervasyonDal.Delete(RezervasyonDal);
        }

        

        public List<Odev_BP.Models.rezervasyon> GetAll()
        {
            return _rezervasyonDal.GetAll();
        }

        public void Update(Odev_BP.Models.rezervasyon RezervasyonDal)
        {
            _rezervasyonDal.Update(RezervasyonDal);
        }

        
    }
}
