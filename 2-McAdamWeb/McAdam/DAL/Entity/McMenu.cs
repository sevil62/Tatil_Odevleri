using DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class McMenu:BaseEntity
    {
        public string MenuName { get; set; }
        public decimal MenuFiyat { get; set; }

        public override string ToString()
        {
            return MenuName;
        }

    }
}
