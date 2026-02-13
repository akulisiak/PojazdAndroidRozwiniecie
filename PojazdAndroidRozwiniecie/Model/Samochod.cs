using PojazdAndroidRozwiniecie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdAndroidRozwiniecie
{
    public class Samochod : Pojazd
    {
        public int liczbaDrzwi;
        public static double standardowyKosztWynajmu = 100;
        public double dedykowanyKosztWynajmu = 0;

        public Samochod(int liczbaDrzwi, ushort rokProdukcji, string marka) : base(marka, rokProdukcji)
        {
            this.liczbaDrzwi = liczbaDrzwi;
        }
        public Samochod(int liczbaDrzwi, ushort rokProdukcji, string marka, double kosztWynajmu) : base(marka, rokProdukcji)
        {
            this.liczbaDrzwi = liczbaDrzwi;
            this.dedykowanyKosztWynajmu = kosztWynajmu;
        }
        public Samochod(Samochod auto) : base(auto.marka, auto.rokProdukcji)
        {
            this.liczbaDrzwi = auto.liczbaDrzwi;
        }


        public override double ObliczKosztWynajmu(int dni)
        {
            if (dedykowanyKosztWynajmu > 0) return dedykowanyKosztWynajmu * dni;
            return standardowyKosztWynajmu * dni;
        }
        public override string Opis()
        {
            //return base.Opis() + $" liczba drzwi {this.liczbaDrzwi}";
            return $"Opis pojazdu: {this.marka}, rok produkcji: {this.rokProdukcji}, liczba drzwi: {this.liczbaDrzwi}";
        }

    }
}