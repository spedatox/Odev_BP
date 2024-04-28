using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Odev_BP.Odeme
{
    public interface IOdemeService
    {
        List<Odev_BP.Models.odeme> GetAll();
        void Add(Odev_BP.Models.odeme Odeme);
        void Delete(Odev_BP.Models.odeme Odeme);
        void Update(Odev_BP.Models.odeme Odeme);
    }
}
