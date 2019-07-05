using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        int oyunsira;

        int hamle_sayisi;

        int zaman_sayac = 1;
        string oynanan_harf;

        //oyunsira:1.oyuncu/2.oyuncu sırasını belirliyor.
        //hamle_sayisi:9 olunca süreler karşılaştırılsın diye bellekte tutuluyor.
        //zaman_sayac:Zamanı 1'er 1'er azaltmak için.
        private void Form2_Load(object sender, EventArgs e)
        {   //Oyun fonksiyonu başlatılıyor.
            oyun();
            
            
        }
        /*Oyuncu Hamleleri*/
        private void buton_1_Click(object sender, EventArgs e)
        {   
            oyunsira = oyunsira % 2;//Oyun sırası 2 moduyla sadece 0 ile 1 değeri kalmasını sağlıyor.Eğer sıra 0'sa 1.oyuncu ;değilse 2.oyuncu sırası.
            oynanan_harf = veridepo.Text;//Oynanacak harf ana ekrandaki XO yazısından alınacak.
            buton_1.Text = oynanan_harf[oyunsira].ToString();//Oyuncunun sırasına göre alınıyor.
            buton_1.Enabled = false;//Tıklanılan buton tekrar tıklanılamasın diye etkisiz hale getiriliyor.
            oyunsira++;//Oyunun sırası diğer oyuncuya geçiyor.
            hamle_sayisi++;//Hamle sayısı güncelleniyor.
            sure_sayma();//Geri sayım rakibe geçiyor.
            kim_kazandi();//Kim kazandı kontrol ediliyor.

        }

        private void buton_2_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_2.Text = oynanan_harf[oyunsira].ToString();
            buton_2.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void buton_3_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_3.Text = oynanan_harf[oyunsira].ToString();
            buton_3.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void buton_4_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_4.Text = oynanan_harf[oyunsira].ToString();
            buton_4.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void buton_5_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_5.Text = oynanan_harf[oyunsira].ToString();
            buton_5.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void buton_6_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_6.Text = oynanan_harf[oyunsira].ToString();
            buton_6.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void buton_7_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_7.Text = oynanan_harf[oyunsira].ToString();
            buton_7.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void buton_8_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_8.Text = oynanan_harf[oyunsira].ToString();
            buton_8.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void buton_9_Click(object sender, EventArgs e)
        {
            oyunsira = oyunsira % 2;
            oynanan_harf = veridepo.Text;
            buton_9.Text = oynanan_harf[oyunsira].ToString();
            buton_9.Enabled = false;
            oyunsira++;
            hamle_sayisi++;
            sure_sayma();
            kim_kazandi();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Birinci oyuncu için zaman sayma

            prgrsBar_oyuncu1.Value -= zaman_sayac*10;
            //Toplam 10 saniyelik süreleri var.
            if(prgrsBar_oyuncu1.Value == 0)
            {   //Eğer süre biterse 2.oyuncu kazanıyor.
                bitis(2);
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Toplam 10 saniyelik süreleri var.
            prgrsBar_oyuncu2.Value -= zaman_sayac*10;

            if (prgrsBar_oyuncu2.Value == 0)
            {   //Eğer süre biterse 1.oyuncu kazanıyor.
                bitis(1);
                
            }
        }

        void sure_sayma()
        {   //Oyunun sırasına göre zamanlayıcıyı kapatıyor.
            if (oyunsira % 2 == 0)
            {

                timer1.Start();
                timer2.Stop();
              

            }

            else
            {
                timer2.Start();
                timer1.Stop();
                

            }

        }

        void bitis(int kazanan)
        {
           
            //İlk başta zamanlayıcılar kapatılıyor sonra hamle yapılamasın diye butonlar etkisizleştiriliyor.
            timer2.Stop();
            timer1.Stop();
            tum_buton_etkisizlestirme();
            

            //Kazanan gösteriliyor.
            MessageBox.Show("Kazanan "+kazanan.ToString() +".Oyuncu", "Kontrol Penceresi", MessageBoxButtons.OK,MessageBoxIcon.Information);

            Close();
             

        }
        //Oyunu başlatan fonksiyon
        void oyun()
        {   //Oyuncu adı Form1'den girilen değerle alınıyor.
            oyuncuadi1.Text = Form1.gonderilecek_ad1;
            oyuncuadi2.Text = Form1.gonderilecek_ad2;

            hamle_sayisi = 0;//Hamle sayısı en başta 0 oluyor.


            oyunsira = 0;
            siradepo.Text = '1'.ToString();//Sıra kimde onu pencereye aktarıyor.

            int eleman_sayisi = 2;
            char[] adimlar = new char[eleman_sayisi];
            adimlar[0] = 'X';
            adimlar[1] = 'O';
            //Oynanacak adımlar ekrana eklenmesi için dizide saklanıyor.
            veridepo.Text = null;

            for (int z = 0; z < eleman_sayisi; z++)
            {
                veridepo.Text += adimlar[z].ToString();

            }//Adımlara 0 değeri atanıyor.


            timer1.Interval = 1000;
            timer2.Interval = 1000;
            //Zamanlayıcının 1/saniye birimi olsun diye 1000 değeri veriliyor.
            sure_sayma();
            //Süre sayma başlatılıyor.
            prgrsBar_oyuncu1.Value = 100;
            prgrsBar_oyuncu2.Value = 100;
        }
        //Kimin kazandığını belli eden fonksiyon
        void kim_kazandi()
        {
            if ('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_2.Text && 'O'.ToString() == buton_3.Text)
            {   //Eğer O harfli olan kazanırsa:
                buton_1.BackColor = Color.Red;//Eşleşen butonlar kırmızı oluyor.
                buton_2.BackColor = Color.Red;
                buton_3.BackColor = Color.Red;
                bitis(2);//2.Oyuncunun kazandığı bilgisi veriliyor.
            }

            else if('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_4.Text && 'O'.ToString() == buton_7.Text)
            {
                buton_1.BackColor = Color.Red;
                buton_4.BackColor = Color.Red;
                buton_7.BackColor = Color.Red;
                bitis(2);
            }

            else if('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_1.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                bitis(2);
            }

            else if('O'.ToString() == buton_2.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_8.Text)
            {
                buton_2.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_8.BackColor = Color.Red;
                bitis(2);
            }

            else if('O'.ToString() == buton_3.Text && 'O'.ToString() == buton_6.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_3.BackColor = Color.Red;
                buton_6.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                bitis(2);
            }

            else if('O'.ToString() == buton_4.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_6.Text)
            {
                buton_4.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_6.BackColor = Color.Red;
                bitis(2);
            }

            else if('O'.ToString() == buton_7.Text && 'O'.ToString() == buton_8.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_7.BackColor = Color.Red;
                buton_8.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                bitis(2);
            }

            else if('O'.ToString() == buton_7.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_3.Text)
            {
                buton_7.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_3.BackColor = Color.Red;
                bitis(2);
            }
            
            else if('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_2.Text && 'X'.ToString() == buton_3.Text)
            {//Eğer X harfli olan kazanırsa:
                buton_1.BackColor = Color.Blue;//Eşleşen butonlar mavi oluyor.
                buton_2.BackColor = Color.Blue;
                buton_3.BackColor = Color.Blue;
                bitis(1);//Birinci oyuncunun kazandığı bilgisi veriliyor.
            }

            else if('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_4.Text && 'X'.ToString() == buton_7.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_4.BackColor = Color.Blue;
                buton_7.BackColor = Color.Blue;
                bitis(1);
            }

            else if('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                bitis(1);
            }

            else if('X'.ToString() == buton_2.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_8.Text)
            {
                buton_2.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_8.BackColor = Color.Blue;
                bitis(1);
            }

            else if('X'.ToString() == buton_3.Text && 'X'.ToString() == buton_6.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_3.BackColor = Color.Blue;
                buton_6.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                bitis(1);
            }

            else if('X'.ToString() == buton_4.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_6.Text)
            {
                buton_4.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_6.BackColor = Color.Blue;
                bitis(1);
            }

            else if('X'.ToString() == buton_7.Text && 'X'.ToString() == buton_8.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_7.BackColor = Color.Blue;
                buton_8.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                bitis(1);
            }

            else if('X'.ToString() == buton_7.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_3.Text)
            {
                buton_7.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_3.BackColor = Color.Blue;
                bitis(1);
            }

            else
            {   //Hamle sayısı olursa süreye bakılıyor.
                if (hamle_sayisi == 9)
                {
                    if (prgrsBar_oyuncu1.Value > prgrsBar_oyuncu2.Value) { bitis(1); }
                    else { bitis(2);}
                }

                else { }
            }

        }

        void tum_buton_etkisizlestirme()
        {   //Butonlar etkisizleştiriliyor.
            buton_1.Enabled = false;
            buton_2.Enabled = false;
            buton_3.Enabled = false;
            buton_4.Enabled = false;
            buton_5.Enabled = false;
            buton_6.Enabled = false;
            buton_7.Enabled = false;
            buton_8.Enabled = false;
            buton_9.Enabled = false;

        }

        
    }   


}
