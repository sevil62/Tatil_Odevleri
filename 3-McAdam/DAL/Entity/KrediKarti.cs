using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class KrediKarti:BaseEntity
    {
        public string BankaAdi { get; set; }
        public string Karttip { get; set; }
        public decimal KartLimit { get; set; }
        public bool Taksit { get; set; }
    }
}
