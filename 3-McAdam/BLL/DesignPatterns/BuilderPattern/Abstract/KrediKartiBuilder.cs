using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DesignPatterns.BuilderPattern.Abstract
{
    public abstract class KrediKartiBuilder
    {
        protected KrediKarti kart;
        public KrediKarti Kart
        {
            get
            {
                return kart;
            }
        }

        public abstract void BankaAdi(string bankaAdi);
        public abstract void KartTip(string kartTip);
        public abstract void KartLimit(decimal kartLimit);

        public abstract void Taksit(bool taksit);

    }
}
