using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev_BP.Models;
using Odev_BP.Odeme;

namespace Odev_BP.Odeme
{
    public class EfodemeDal : EfEntityRepositoryBase<Odev_BP.Models.odeme, OtelDbContext>, IodemeDal
    {
    }
}
