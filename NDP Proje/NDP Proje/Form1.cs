using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
        // random resim üretmek için rastgele classıyla bir int değer oluşturdum

        Random rand = new Random();
        private int rastgele;



        public Form1()
        {
            InitializeComponent();
        }

        // Gerekli değişkenleri tanımladım

        int vitADeger = 0;
        int vitCDeger = 0;
        int saniye = 60;
        int yanlis = 0;
        int atik = 0;

        // nesneleri oluşturdum

        Portakal portakal = new Portakal();
        Mandalina mandalina = new Mandalina();
        Greyfurt greyfurt = new Greyfurt();

        Elma elma = new Elma();
        Cilek cilek = new Cilek();
        Armut armut = new Armut();

        // oyuna hak özelliği getirmek için gerek fonksiyonu yazdım

        void Life_index()

        {
            if (yanlis == 1) // 1.hak kaybedilirse
            {

                lyf_1.Image = Properties.Resources._8;

            }

            if (yanlis == 2) //2.hak kaybedilirse
            {

                lyf_2.Image = Properties.Resources._8;

            }

            if (yanlis == 3) // 3.hak kaybedilirse
            {

                lyf_3.Image = Properties.Resources._8;
                Sayac.Stop();
                btnNarenciye.Enabled = false;
                btnKatıM.Enabled = false;
                btnBaslat.Enabled = true;
            }
        }

        // yükleme ekranında nelerin olması gerektiğini belirttim

        private void Form1_Load(object sender, EventArgs e)
        {

            Sayac.Stop();
            lblSaniye.Hide();
            grpVeri.Hide();
            btnKatıM.Enabled = false;
            btnNarenciye.Enabled = false;

            rastgele = rand.Next(0, 6);

        }

        // Sayaç

        private void Sayac_Tick(object sender, EventArgs e)
        {
            //saniye aktığı zamanlarda ki olması gerekenleri koydum.

            if (saniye >= 0)
            {
                Sayac.Interval = 1000;
                int sayac = saniye--;
                lblSaniye.Text = sayac.ToString();
                btnBaslat.Enabled = false;
            }

            // saniye durunca olması gerekenleri koydum.

            else
            {

                btnBaslat.Enabled = true;
                btnKatıM.Enabled = false;
                btnNarenciye.Enabled = false;
                Sayac.Stop();
                Life_index();
            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {

            // başta tanımlasdığım değişkenleri sıfırladım ve her tekrar başlatınca sıfırlanması için yazdım.

            btnKatıM.Enabled = true;
            btnNarenciye.Enabled = true;

            yanlis = 0;
            atik = 0;
            vitADeger = 0;
            vitCDeger = 0;

            lblvitAveri.Text = "";
            lblvitCveri.Text = "";
            lblAtikVeri.Text = "";

            lblAnlıkGramVeri.Text = "";
            lblAnlıkVitAVeri.Text = "";
            lblAnlıkVitCVeri.Text = "";

            // hak için gerekli kalpler

            lyf_1.Image = Properties.Resources._7;
            lyf_2.Image = Properties.Resources._7;
            lyf_3.Image = Properties.Resources._7;

            Life_index(); // hak fonksiyonum.

            grpVeri.Show();

            saniye = 60;

            Sayac.Start();
            lblSaniye.Show();

            btnKatıM.Enabled = true;
            btnNarenciye.Enabled = true;

            // başlata tıklayınca ekrana gelecek resmi ürettim.

            pctrbMeyve.Image = ımageList1.Images[rastgele];

        }

        // narenciye butonu

        private void btnNarenciye_Click(object sender, EventArgs e)
        {

            // eğer ekranda portakal varsa ve portakal seçilirse

            if (rastgele == 0) // portakal
            {

                portakal.Agirlik();
                portakal.vitAhesap();
                portakal.vitChesap();


                atik += portakal.Atik;
                vitCDeger += portakal.vitC;
                vitADeger += portakal.vitA;

                lblvitAveri.Text = vitADeger.ToString();
                lblvitCveri.Text = vitCDeger.ToString();
                lblAtikVeri.Text = atik.ToString();

                lblAnlıkGramVeri.Text = portakal.Gram.ToString();
                lblAnlıkVitAVeri.Text = portakal.vitA.ToString();
                lblAnlıkVitCVeri.Text = portakal.vitC.ToString();

            }

            // eğer ekranda mandalina varsa ve seçilirse

            else if (rastgele == 2) // mandalina
            {

                mandalina.Agirlik();
                mandalina.vitAhesap();
                mandalina.vitChesap();


                atik += mandalina.Atik;
                vitCDeger += mandalina.vitC;
                vitADeger += mandalina.vitA;

                lblvitAveri.Text = vitADeger.ToString();
                lblvitCveri.Text = vitCDeger.ToString();
                lblAtikVeri.Text = atik.ToString();

                lblAnlıkGramVeri.Text = mandalina.Gram.ToString();
                lblAnlıkVitAVeri.Text = mandalina.vitA.ToString();
                lblAnlıkVitCVeri.Text = mandalina.vitC.ToString();

            }

            // eğer ekranda greyfurt varsa ve seçilirse

            else if (rastgele == 3) // greyfurt
            {

                greyfurt.Agirlik();
                greyfurt.vitAhesap();
                greyfurt.vitChesap();

                atik += greyfurt.Atik;
                vitCDeger += greyfurt.vitC;
                vitADeger += greyfurt.vitA;

                lblvitAveri.Text = vitADeger.ToString();
                lblvitCveri.Text = vitCDeger.ToString();
                lblAtikVeri.Text = atik.ToString();

                lblAnlıkGramVeri.Text = greyfurt.Gram.ToString();
                lblAnlıkVitAVeri.Text = greyfurt.vitA.ToString();
                lblAnlıkVitCVeri.Text = greyfurt.vitC.ToString();


            }

            // eğer katı meyve varsa yanlış sayacını bir arttır.

            else if (rastgele == 1||rastgele==4||rastgele==5) 
            {
                yanlis++;

            }
            
            // hak fonksiyonum çağırılsın

            Life_index();

            // butona tıklanınca doğruysa da yanlışsa da rastgele fotoğraf gelir ve haklardan bir tanesi azalır.

            rastgele = rand.Next(0, 6);
            pctrbMeyve.Image = ımageList1.Images[rastgele];
        }


        // katı meyve butonum

        private void btnKatıM_Click(object sender, EventArgs e)
        {
            //eğer ekranda armut varsa ve seçilirse

            if (rastgele == 1)//armut

            {

                armut.agirlik();
                armut.vitAhesap();
                armut.vitChesap();

                atik += armut.Atik;
                vitCDeger += armut.vitC;
                vitADeger += armut.vitA;

                lblAnlıkGramVeri.Text = armut.Gram.ToString();
                lblAnlıkVitAVeri.Text = armut.vitA.ToString();
                lblAnlıkVitCVeri.Text = armut.vitC.ToString();

                lblvitAveri.Text = vitADeger.ToString();
                lblvitCveri.Text = vitCDeger.ToString();
                lblAtikVeri.Text = atik.ToString();

            }

            // eğer ekranda çilek varsa ve seçilirse

            else if (rastgele == 4)//cilek

            {

                cilek.agirlik();
                cilek.vitAhesap();
                cilek.vitChesap();

                atik += cilek.Atik;
                vitCDeger += cilek.vitC;
                vitADeger += cilek.vitA;

                lblAnlıkGramVeri.Text = cilek.Gram.ToString();
                lblAnlıkVitAVeri.Text = cilek.vitA.ToString();
                lblAnlıkVitCVeri.Text = cilek.vitC.ToString();

                lblvitAveri.Text = vitADeger.ToString();
                lblvitCveri.Text = vitCDeger.ToString();
                lblAtikVeri.Text = atik.ToString();

            }

            // eğer ekranda elma varsa ve seçilirse

            else if (rastgele == 5)// elma
            {

                elma.agirlik();
                elma.vitAhesap();
                elma.vitChesap();

                atik += elma.Atik;
                vitCDeger += elma.vitC;
                vitADeger += elma.vitA;

                lblAnlıkGramVeri.Text = elma.Gram.ToString();
                lblAnlıkVitAVeri.Text = elma.vitA.ToString();
                lblAnlıkVitCVeri.Text = elma.vitC.ToString();

                lblvitAveri.Text = vitADeger.ToString();
                lblvitCveri.Text = vitCDeger.ToString();
                lblAtikVeri.Text = atik.ToString();

            }


            // eğer ekranda katı meyve yoksa ve seçilirse yanlış sayacını arttır.

            else if (rastgele == 0 || rastgele == 2 || rastgele == 3)
            {
                yanlis++;
            }

            // hak fonksiyonum

            Life_index();

            // rastgele resim üret doğru seçilse de seçilmese de 

            rastgele = rand.Next(0, 6);
            pctrbMeyve.Image = ımageList1.Images[rastgele];

        }

        // oyundan çıkış butonu

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblvitAveri_Click(object sender, EventArgs e)
        {

        }
    }
}
