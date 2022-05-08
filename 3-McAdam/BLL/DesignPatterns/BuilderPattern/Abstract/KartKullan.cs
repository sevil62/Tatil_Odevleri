using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DesignPatterns.BuilderPattern.Abstract
{
    public class KartKullan
    {
        public void KrediKartiKullan(KrediKartiBuilder kart, string bankaAdi, decimal kartLimit, bool taksit, string kartTip)
        {
            kart.BankaAdi(bankaAdi);
            kart.KartLimit(kartLimit);
            kart.Taksit(taksit);
            kart.KartTip(kartTip);
        }
    }
}
