using DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class SiparisOlustur:BaseEntity
    {
        public McMenu McMenu { get; set; }
        public List<Ekstra>Ekstralar { get; set; }
        public Boyut Boyut { get; set; }
        public KrediKarti KrediKarti { get; set; }
        public Rapor Rapor { get; set; }
        public decimal Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            //Menu fiyat
            ToplamTutar += McMenu.MenuFiyat;

            //Boyut
            switch (Boyut)
            {
                case Boyut.Small:
                    ToplamTutar += 0;
                    break;
                case Boyut.Medium:
                    ToplamTutar += 3;
                    break;
                case Boyut.Large:
                    ToplamTutar += 5;
                    break;
              
            }
            //Ekstra Fiyat
            foreach (Ekstra ekstra in Ekstralar)
            {
                ToplamTutar += ekstra.EkstraFiyat;
            }

            ToplamTutar *= Adet;

        }
        public override string ToString()
        {
            string ekstraBilgi = "";
            foreach (Ekstra ekstra in Ekstralar)
            {
                ekstraBilgi += ekstra.EkstraName + " ";
            }
            return   $"{McMenu} Menu, {Adet} Adet, {Boyut.ToString()}, Ekstra: ({ekstraBilgi}) {ToplamTutar.ToString("C2")}";
        }

    }
}
