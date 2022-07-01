using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    interface ISatis
    {
        void UrunSat(string kelime,int uzunluk);
        
        int MevcutUrun { get; set; }
    }
}
