using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdAndroidRozwiniecie
{
    public class Motocykl : Pojazd
    {
        public bool czyZabytkowy;

        public Motocykl(bool czyZabytkowy, string marka, ushort rokProdukcji) : base(marka, rokProdukcji)
        {
            this.czyZabytkowy = czyZabytkowy;
        }

        public override double ObliczKosztWynajmu(int dni)
        {
            double koszt = 70.0 * dni;
            if (czyZabytkowy)
                koszt += koszt * 0.2;
            return koszt;
        }
        public override string Opis()
        {
            if (czyZabytkowy)
                return base.Opis() + ", pojazd zabytkowy";
            return base.Opis() + ", pojazd niezabytkowy";
        }
    }
}