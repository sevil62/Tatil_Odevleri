using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Rapor:BaseEntity
    {
        public decimal Ciro { get; set; }
        public decimal KDVHaricFiyat { get; set; }
        public int SatilanEkstraAdet { get; set; }
        public string SatilanEkstra { get; set; }
        public int SatilanMenuAdet { get; set; }

    }
}
