using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace proje
{
    class Ordek : AbstractHayvan, IDepo, ISatis, IKazanc 
         
    {
        private SoundPlayer ordekOlumSesi = new SoundPlayer(); 
        public Ordek() //Kurucu tanımlanır.
        {
            ordekOlumSesi.SoundLocation = Application.StartupPath + "\\ordek.wav";//Ölüm sesi eklenir.
        }
        public override string Sure { get; set; } //property'ler tanımlanır.
        public override int Enerji { get; set; }

        public override string Yazi { get; set; }
        public string MevcutUrunMiktari { get; set; }
        
        public int MevcutUrun { get; set; }
        public int Kasa { get; set; }
        public string Kazanılan { get; set; }

        public override void Canlilik(int enerji, string yazi) //Canlılık durumunu gösteren fonksiyon tanımlanır.
        {
            
            if (enerji == 0)//Enerjinin bitmesi durumunda öldüğünü diğer durumdada canlı olduğunu yazar.
            {
                yazi = "ÖLÜ";
            }

            else
            {
                yazi = "CANLI";
            }

            Yazi = yazi;


        }

        public override void EnerjiAzalt(int enerji) //Enerji miktarını belirleyen ve ölüm sesini çıkartan fonksiyon tanımlanır.
        {
            if (enerji == 1)
            {
                ordekOlumSesi.Play();//ÖLüm sesi çağırılır.
                enerji = 0;

            }
            else if (enerji == 0)//enerjinin negatife düşmemesi sağlanır.
            {
                enerji = 0;

            }
            else
            {
                enerji -= 3;

            }

            Enerji = enerji;
        }

        public override void YemVer(int enerji) //Enerji dolmasını sağlayan fonksiyon tanımlanır.
        {
            if (enerji <= 100 && enerji != 0) //ÖLmediği ve canı tam olmadığı sürece enerji 00'e eşitlenir.
            {
                enerji = 100;
            }
            else
            {
                enerji = 0;
            }
            Enerji = enerji;
        }

       
              

        public void UrunSat(string mevcutUrunMiktari, int uzunluk) //Ürün miktarindaki azalmayı belirleyen fonksiyon tanımlanır.
        {
            string gecici;
            int urunMiktari;
            MevcutUrunMiktari = mevcutUrunMiktari;

            uzunluk = MevcutUrunMiktari.Length; //Urun miktarinin uzunluğu bir değişkene atanır.

            gecici = MevcutUrunMiktari.Remove(uzunluk - 5, 5); //Ürün miktarındaki string değer atılır.
            urunMiktari = Convert.ToInt32(gecici);//Ürün miktarındaki int değer belirlenir.

            if (urunMiktari > 0) //Olmayan ürünü satma ihtimali yok edilir.
            {
                urunMiktari=0;
            }

            MevcutUrunMiktari = urunMiktari.ToString() + " ADET"; //Atılan string değer tekrar yazılır.

        }

        public void UrunMiktar(string mevcutUrunMiktari, int uzunluk, int sure, int enerji)
        {
            string gecici;
            int urunMiktari;
            MevcutUrunMiktari = mevcutUrunMiktari;

            if (enerji > 0)
            {
                if (sure > 0 && sure % 5 == 0) // Süre 5'in katı olduğunda yeni ürün üretir.
                {
                    uzunluk = MevcutUrunMiktari.Length;

                    gecici = MevcutUrunMiktari.Remove(uzunluk - 5, 5); //Ürün miktarındaki string değer atılır.
                    urunMiktari = Convert.ToInt32(gecici); //Ürün miktarındaki int değer belirlenir.
                    urunMiktari++;

                    MevcutUrunMiktari = urunMiktari.ToString() + " ADET"; //Atılan string değer tekrar yazılır.
                }
            }
        }

        public void Kazanc(string mevcutUrunMiktari, int uzunluk, string kasa)
        {
            string gecici;
            int urunMiktari;
            int kazanılan;
            MevcutUrunMiktari = mevcutUrunMiktari;

            uzunluk = MevcutUrunMiktari.Length;

            gecici = MevcutUrunMiktari.Remove(uzunluk - 5, 5);//Ürün miktarındaki string değer atılır.
            urunMiktari = Convert.ToInt32(gecici);//Ürün miktarındaki int değer belirlenir.


            if (urunMiktari > 0) 
            {

                Kazanılan = kasa;
                uzunluk = Kazanılan.Length;

                gecici = Kazanılan.Remove(uzunluk - 2, 2);//'tl' stringi atılır.
                kazanılan = Convert.ToInt32(gecici);//para miktarı belirlenir.
                kazanılan += urunMiktari*3;//fiyata ve ürün miktarına göre yei kazanılan para hesaplanır.

                Kazanılan = kazanılan.ToString() + " TL";//'TL' stringi geri getirilir ve kasaya atanır.
            }

            else
            {
                Kazanılan = kasa;

            }
        }

        
    }
    }

