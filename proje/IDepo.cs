using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    interface IDepo
    {
        void UrunMiktar(string kelime, int uzunluk, int sure, int enerji);//Fonksiyon tanımlanır.
        string MevcutUrunMiktari { get; set; }//property tanımlanır.
    }
}
