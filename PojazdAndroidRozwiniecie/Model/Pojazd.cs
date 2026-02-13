using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdAndroidRozwiniecie
{
    public abstract class Pojazd
    {
        public string marka;
        public ushort rokProdukcji;
        public Pojazd(string marka, ushort rokProdukcji)
        {
            this.marka = marka;
            this.rokProdukcji = rokProdukcji;
        }
        public abstract double ObliczKosztWynajmu(int dni);
        public virtual string Opis()
        {
            return $"Opis pojazdu: {this.marka}, rok produkcji: {this.rokProdukcji}";
        }

        public virtual string OpisShort()
        {
            return $"{this.marka}, {this.rokProdukcji}";
        }
    }
}