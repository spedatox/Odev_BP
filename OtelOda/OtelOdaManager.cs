using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.OtelOda
{

    public class OtelOdaManager : IOtelOdaService

    {
        private IOtelOdaDal _OtelOdaDal;
        public OtelOdaManager(IOtelOdaDal OtelOdaDal)
        {
            _OtelOdaDal = OtelOdaDal;
        }
        public void Add(Odev_BP.Models.otelOda OtelOdaDal)
        {
            _OtelOdaDal.Add(OtelOdaDal);
        }

       

        public void Delete(Odev_BP.Models.otelOda OtelOdaDal)
        {
            _OtelOdaDal.Delete(OtelOdaDal);
        }

        

        public List<Odev_BP.Models.otelOda> GetAll()
        {
            return _OtelOdaDal.GetAll();
        }

        public void Update(Odev_BP.Models.otelOda OtelOdaDal)
        {
            _OtelOdaDal.Update(OtelOdaDal);
        }

        
    }
}
