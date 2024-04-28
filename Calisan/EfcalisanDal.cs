using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev_BP.Models;

namespace Odev_BP.Calisan
{
    public class EfcalisanDal : EfEntityRepositoryBase<Odev_BP.Models.calisan, OtelDbContext>, IcalisanDal
    {
    }
}
