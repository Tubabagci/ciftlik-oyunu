using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        Tavuk tavuk = new Tavuk();
        Inek inek = new Inek();
        Ordek ordek = new Ordek();
        Keci keci = new Keci();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sure_Tick(object sender, EventArgs e) //Her saniye yapılacak işler.
        {
            

            string[] sureTutucu = lblSureMiktar.Text.Split(' ');//Kronometre tanımlanır.
            int sure = Convert.ToInt32(sureTutucu[0]);
            sure++;
            lblSureMiktar.Text = sure.ToString() + " SN";


            //////////////////////////////

            tavuk.EnerjiAzalt(pbTavuk.Value); //Enerjinin azaltılmasını sağlayan fonksiyon her hayvan için çağırılır.
            pbTavuk.Value = tavuk.Enerji;

            inek.EnerjiAzalt(pbInek.Value);
            pbInek.Value = inek.Enerji;

            ordek.EnerjiAzalt(pbOrdek.Value);
            pbOrdek.Value = ordek.Enerji;

            keci.EnerjiAzalt(pbKeci.Value);
            pbKeci.Value = keci.Enerji;

            tavuk.Canlilik(pbTavuk.Value, lblTavukCanlilik.Text); //Canlılık durumunu gösteren fonksiyon her hayvan için çağırılır.
            lblTavukCanlilik.Text = tavuk.Yazi;

            inek.Canlilik(pbInek.Value, lblInekCanlilik.Text);
            lblInekCanlilik.Text = inek.Yazi;

            ordek.Canlilik(pbOrdek.Value, lblOrdekCanlilik.Text);
            lblOrdekCanlilik.Text = ordek.Yazi;

            keci.Canlilik(pbKeci.Value, lblKeciCanlilik.Text);
            lblKeciCanlilik.Text = keci.Yazi;

            inek.UrunMiktar(lblInekSutKg.Text, lblInekSutKg.Text.Length, sure,pbInek.Value);//Ürün mikarını gösteren fonksiyon her hayvan için çağırılır.
            lblInekSutKg.Text = inek.MevcutUrunMiktari;

            keci.UrunMiktar(lblKeciSutKg.Text, lblKeciSutKg.Text.Length, sure,pbKeci.Value);
            lblKeciSutKg.Text = keci.MevcutUrunMiktari;

            ordek.UrunMiktar(lblOrdekYumurtaSayi.Text, lblOrdekYumurtaSayi.Text.Length, sure,pbOrdek.Value);
            lblOrdekYumurtaSayi.Text = ordek.MevcutUrunMiktari;

            tavuk.UrunMiktar(lblTavukYumurtaSayi.Text, lblTavukYumurtaSayi.Text.Length, sure,pbTavuk.Value);
            lblTavukYumurtaSayi.Text = tavuk.MevcutUrunMiktari;



        }

        private void BtnTavukYemVer_Click(object sender, EventArgs e) //Yem ver butonuna basıldığında devreye girerek enerjiyi fulleyen fonksiyon her hayvan için çağırılır.
        {
            tavuk.YemVer(pbTavuk.Value);
            pbTavuk.Value = tavuk.Enerji;

        }

        private void BtnInekYemVer_Click(object sender, EventArgs e)
        {
            inek.YemVer(pbInek.Value);
            pbInek.Value = inek.Enerji;

        }

        private void BtnOrdekYemVer_Click(object sender, EventArgs e)
        {
            ordek.YemVer(pbOrdek.Value);
            pbOrdek.Value = ordek.Enerji;
        }

        private void BtnKeciYemVer_Click(object sender, EventArgs e)
        {
            keci.YemVer(pbKeci.Value);
            pbKeci.Value = keci.Enerji;
        }

        private void BtnİnekSutSat_Click(object sender, EventArgs e) //Basıldığında ürünleri satan ve kasadaki parayı belirleyen fonksiyonlar  her hayvan için çağırılır.
        {
            inek.Kazanc(lblInekSutKg.Text, lblInekSutKg.Text.Length, lblKasaMiktar.Text);
            lblKasaMiktar.Text = inek.Kazanılan;

            inek.UrunSat(lblInekSutKg.Text, lblInekSutKg.Text.Length);
            lblInekSutKg.Text = inek.MevcutUrunMiktari;


        }

        private void BtnTavukYumurtaSat_Click(object sender, EventArgs e)
        {
            tavuk.Kazanc(lblTavukYumurtaSayi.Text, lblTavukYumurtaSayi.Text.Length, lblKasaMiktar.Text);
            lblKasaMiktar.Text = tavuk.Kazanılan;

            tavuk.UrunSat(lblTavukYumurtaSayi.Text, lblTavukYumurtaSayi.Text.Length);
            lblTavukYumurtaSayi.Text = tavuk.MevcutUrunMiktari;
        }

        private void BtnOrdekYumurtaSat_Click(object sender, EventArgs e)
        {
            ordek.Kazanc(lblOrdekYumurtaSayi.Text, lblOrdekYumurtaSayi.Text.Length, lblKasaMiktar.Text);
            lblKasaMiktar.Text = ordek.Kazanılan;

            ordek.UrunSat(lblOrdekYumurtaSayi.Text, lblOrdekYumurtaSayi.Text.Length);
            lblOrdekYumurtaSayi.Text = ordek.MevcutUrunMiktari;

          
        }

        private void BtnKeciSutSat_Click(object sender, EventArgs e)
        {
            keci.Kazanc(lblKeciSutKg.Text, lblKeciSutKg.Text.Length, lblKasaMiktar.Text);
            lblKasaMiktar.Text = keci.Kazanılan;

            keci.UrunSat(lblKeciSutKg.Text, lblKeciSutKg.Text.Length);
            lblKeciSutKg.Text = keci.MevcutUrunMiktari;
        }
    }
}
