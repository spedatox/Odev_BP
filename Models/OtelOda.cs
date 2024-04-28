using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_BP.Models
{
   public class otelOda : IEntity

    {
        [Key]
    public int OdaID { get; set; }
    public string OdaTipi { get; set; }
    public decimal OdaFiyati { get; set; }
    public string OdaDurumu { get; set; }
    public decimal Kapasite { get; set; }

        public virtual ICollection<rezervasyon> Rezervasyon { get; set; }
}
}
