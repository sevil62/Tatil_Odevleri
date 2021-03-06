using BLL.DesignPatterns.BuilderPattern.Abstract;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DesignPatterns.BuilderPattern.Concrete
{
    public class MasterCartConc : KrediKartiBuilder
    {
        public MasterCartConc()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi(string bankaAdi)
        {
            kart.BankaAdi = bankaAdi;
        }

        public override void KartLimit(decimal kartLimit)
        {
            kart.KartLimit = kartLimit;
        }

        public override void KartTip(string kartTip)
        {
            kart.Karttip = kartTip;
        }

        public override void Taksit(bool taksit)
        {
            kart.Taksit = taksit;
        }
    }
}
