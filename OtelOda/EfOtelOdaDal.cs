using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev_BP.Models;

namespace Odev_BP.OtelOda
{
    public class EfOtelOdaDal : EfEntityRepositoryBase<Odev_BP.Models.otelOda, OtelDbContext>, IOtelOdaDal
    {
    }
}
