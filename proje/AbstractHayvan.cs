using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    
    abstract class  AbstractHayvan
    {
        //property'ler tanımlanır.
        public abstract int Enerji { get; set; }
        public abstract string Sure { get; set; }
        public abstract string Yazi { get; set; }

        //Fonksiyonlar tanımlanır.
        public abstract void Canlilik(int enerji,string yazi);
        public abstract void YemVer(int enerji);
        public abstract void EnerjiAzalt(int enerji);

    }
}
