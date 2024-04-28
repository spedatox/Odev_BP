using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev_BP.Models;

namespace Odev_BP.Musteri
{
    public class EfmusteriDal : EfEntityRepositoryBase<Odev_BP.Models.musteri, OtelDbContext>, IMusteriDal
    {
    }
}
