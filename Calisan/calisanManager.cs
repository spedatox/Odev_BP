using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Calisan
{

    public class calisanManager : ICalisanService

    {
        private IcalisanDal _calisanDal;
        public calisanManager(IcalisanDal CalisanDal)
        {
            _calisanDal = CalisanDal;
        }
        public void Add(Odev_BP.Models.calisan CalisanDal)
        {
            _calisanDal.Add(CalisanDal);
        }

       

        public void Delete(Odev_BP.Models.calisan CalisanDal)
        {
            _calisanDal.Delete(CalisanDal);
        }

        

        public List<Odev_BP.Models.calisan> GetAll()
        {
            return _calisanDal.GetAll();
        }

        public void Update(Odev_BP.Models.calisan CalisanDal)
        {
            _calisanDal.Update(CalisanDal);
        }

        
    }
}
