using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odev_BP.OtelOda
{
    public interface IOtelOdaService
    {
        List<Odev_BP.Models.otelOda> GetAll();
        void Add(Odev_BP.Models.otelOda OtelOda);
        void Delete(Odev_BP.Models.otelOda OtelOda);
        void Update(Odev_BP.Models.otelOda OtelOda);
    }
}
