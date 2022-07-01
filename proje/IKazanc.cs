using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    interface IKazanc
    {
        void Kazanc(string kelime, int uzunluk, string kasa);//Fonksiyon tanımlanır
       
        //property'ler tanımlanır.
        int Kasa { get; set; }
        string Kazanılan { get; set; }
    }
}
