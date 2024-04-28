using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev_BP.Models;

namespace Odev_BP.Rezervasyon
{
    public class EfrezervasyonDal : EfEntityRepositoryBase<Odev_BP.Models.rezervasyon, OtelDbContext>, IrezervasyonDal
    {
    }
}
