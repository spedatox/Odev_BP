using Odev_BP.Odeme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Odeme
{

    public class odemeManager : IOdemeService

    {
        private IodemeDal _odemeDal;
        public odemeManager(IodemeDal odemeDal)
        {
            _odemeDal = odemeDal;
        }
        public void Add(Odev_BP.Models.odeme odemeDal)
        {
            _odemeDal.Add(odemeDal);
        }

       

        public void Delete(Odev_BP.Models.odeme odemeDal)
        {
            _odemeDal.Delete(odemeDal);
        }

        

        public List<Odev_BP.Models.odeme> GetAll()
        {
            return _odemeDal.GetAll();
        }

        public void Update(Odev_BP.Models.odeme odemeDal)
        {
            _odemeDal.Update(odemeDal);
        }

        
    }
}
