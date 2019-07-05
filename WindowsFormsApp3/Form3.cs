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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int sira = 0;
       
        char oyuncu_harf, pc_harf;
        int[] hamleler = new int[9];
        Random rastgele = new Random();
        int zorluk=Form1.gonderilecek_zorluk;
        //Bütün her yerde gerekli olacak değişkenler

        private void Form3_Load(object sender, EventArgs e)
        {
            oyuncu_adi.Text = Form1.gonderilecek_ad1;
           DialogResult secim = MessageBox.Show("X harfiyle oynamak istiyor musunuz?","",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
           if(DialogResult.Yes== secim) { oyuncu_harf = 'X';pc_harf = 'O'; sira = 1; }
           else if(DialogResult.No == secim) { oyuncu_harf = 'O';pc_harf = 'X'; }
           else { Close(); }
           //Oyuncu ve bilgisayar harfi ataması yapıldı.
           for (int x = 0; x < 9; x++) { hamleler[x] = 0; }
           //Hamle verilerini 0 yapıyor.
           Oyun();
        }


        void PC_hamle_dusunme()
        {   //Zorluk olasılık,bilgisayarın insan gibi hata yapması için.Zorluk değerine kolay-orta-zor seçimine göre atama yapıldı.
            if (Zorluk_olasilik() < zorluk)
            {
                PC_kazanma_dusunmesi();//Bilgisayar kazanabilir mi ona bakıyor.
            }
            //Hata yaptı diye düşünülüyor.
            else { PC_dusunmeden_oynama(); }
        }

        int Zorluk_olasilik()
        {//1 ile 100 arası değer atıyor.
          return rastgele.Next(1,100);
        }
        //Bilgisayarın rastgele oynadığı yer.
        void PC_dusunmeden_oynama()
        {

           
            int sayi = 0;
            sayi = rastgele.Next(1, 10);
            bool hamle_kontrol = true;




            while (hamle_kontrol)
            {
                hamle_kontrol = false;

                foreach (int i in hamleler)
                {
                    if (sayi == i)
                    {
                        hamle_kontrol = true;
                        sayi = 0;
                        sayi = rastgele.Next(1, 10);


                    }
                    else { }
                }
            }

            PC_hamle(sayi);
            
        }

        void Oyun()
        {   //Oyunu başlatma fonksiyonu
            Oyuncu_hamle_kontrol();
        }

        void Oyuncu_hamle_kontrol()
        {   //Sıraya göre hamle veriyor.
            sira = sira % 2;
            
            if (sira == 0)
                PC_hamle_dusunme();
            else { }

           

        }

        void PC_hamle(int sayi) {
           //Bilgisayar hamleleri için olan fonksiyon.
            
            if (sayi == 1)
            {
                buton_1.Text = pc_harf.ToString();//Bilgisayar harfi hangi yere oynadıysa ona atama yapıldı.
                buton_1.Enabled = false;//Buton tıklanılması etkisiz hale getirildi.
                sira++;//Sıra rakibe geçti
                hamleler[0] = 1;//hamleler dizisine veri eklendi.
                Kim_kazandi();//Kim kazandı kontrol ediliyor.
            }
            else if (sayi == 2)
            {
                buton_2.Text = pc_harf.ToString();
                buton_2.Enabled = false;
                sira++;
                hamleler[1] = 2;
                Kim_kazandi();
            }
            else if (sayi == 3)
            {
                buton_3.Text = pc_harf.ToString();
                buton_3.Enabled = false;
                sira++;
                hamleler[2] = 3;
                Kim_kazandi();
            }
            else if (sayi == 4)
            {
                buton_4.Text = pc_harf.ToString();
                buton_4.Enabled = false;
                sira++;
                hamleler[3] = 4;
                Kim_kazandi();

            }

            else if (sayi == 5)
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();
            }
            else if (sayi == 6)
            {
                buton_6.Text = pc_harf.ToString();
                buton_6.Enabled = false;
                sira++;
                hamleler[5] = 6;
                Kim_kazandi();

            }
            else if (sayi == 7)
            {
                buton_7.Text = pc_harf.ToString();
                buton_7.Enabled = false;
                sira++;
                hamleler[6] = 7;
                Kim_kazandi();
            }
            else if (sayi == 8)
            {
                buton_8.Text = pc_harf.ToString();
                buton_8.Enabled = false;
                sira++;
                hamleler[7] = 8;
                Kim_kazandi();
            }
            else if(sayi == 9)
            {
                buton_9.Text = pc_harf.ToString();
                buton_9.Enabled = false;
                sira++;
                hamleler[8] = 9;
                Kim_kazandi();
            }
            //Eğer bir sorun olursa diye:
            else { MessageBox.Show("BURADA BİR HATA VAR!"+sayi.ToString());Close();  }

           

        }
        //Bilgisayar,kazanma dusunmesi fonksiyonundan çıkarsa kaybetmeme onun için 2.öncelik olacağı için bu fonksiyon:
        void PC_kaybetmeme_dusunmesi()
        {
            if(buton_1.Text==oyuncu_harf.ToString() && buton_2.Text==oyuncu_harf.ToString() && 3!=hamleler[2])
            {//Rakibin oynadığı hamleleri kontrol ediyor.
                buton_3.Text = pc_harf.ToString();//Eğer 2 harf yan yanaysa oraya hamle yapıyor.
                buton_3.Enabled = false;//Buton tıklanılması etkisiz hale getiriliyor.
                sira++;//Sıra insana geçiyor
                hamleler[2] = 3;//Oynanılan hamle verisi saklanılıyor.
                Kim_kazandi();//Kim kazandı kontrol ediliyor.

            }

            else if (buton_1.Text == oyuncu_harf.ToString() && buton_4.Text == oyuncu_harf.ToString() && 7 != hamleler[6])
            {
                buton_7.Text = pc_harf.ToString();
                buton_7.Enabled = false;
                sira++;
                hamleler[6] = 7;
                Kim_kazandi();

            }

            else if (buton_1.Text == oyuncu_harf.ToString() && buton_5.Text == oyuncu_harf.ToString() && 9 != hamleler[8])
            {
                buton_9.Text = pc_harf.ToString();
                buton_9.Enabled = false;
                sira++;
                hamleler[8] = 9;
                Kim_kazandi();
            }

            else if (buton_1.Text == oyuncu_harf.ToString() && buton_7.Text == oyuncu_harf.ToString() && 4 != hamleler[3])
            {
                buton_4.Text = pc_harf.ToString();
                buton_4.Enabled = false;
                sira++;
                hamleler[3] = 4;
                Kim_kazandi();

            }

            else if (buton_1.Text == oyuncu_harf.ToString() && buton_9.Text == oyuncu_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();

            }
            else if (buton_2.Text == oyuncu_harf.ToString() && buton_3.Text == oyuncu_harf.ToString() && 1 != hamleler[0])
            {
                buton_1.Text = pc_harf.ToString();
                buton_1.Enabled = false;
                sira++;
                hamleler[0] = 1;
                Kim_kazandi();
            }
            else if (buton_2.Text == oyuncu_harf.ToString() && buton_5.Text == oyuncu_harf.ToString() && 8 != hamleler[7])
            {
                buton_8.Text = pc_harf.ToString();
                buton_8.Enabled = false;
                sira++;
                hamleler[7] = 8;
                Kim_kazandi();

            }

            else if (buton_2.Text == oyuncu_harf.ToString() && buton_8.Text == oyuncu_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();
            }
            else if (buton_3.Text == oyuncu_harf.ToString() && buton_5.Text == oyuncu_harf.ToString() && 7 != hamleler[6])
            {
                buton_7.Text = pc_harf.ToString();
                buton_7.Enabled = false;
                sira++;
                hamleler[6] = 7;
                Kim_kazandi();
            }
            else if (buton_3.Text == oyuncu_harf.ToString() && buton_6.Text == oyuncu_harf.ToString() && 9 != hamleler[8])
            {
                buton_9.Text = pc_harf.ToString();
                buton_9.Enabled = false;
                sira++;
                hamleler[8] = 9;
                Kim_kazandi();
            }

            else if (buton_3.Text == oyuncu_harf.ToString() && buton_7.Text == oyuncu_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();
            }
            else if (buton_3.Text == oyuncu_harf.ToString() && buton_9.Text == oyuncu_harf.ToString() && 6 != hamleler[5])
            {
                buton_6.Text = pc_harf.ToString();
                buton_6.Enabled = false;
                sira++;
                hamleler[5] = 6;
                Kim_kazandi();
            }
            else if (buton_4.Text == oyuncu_harf.ToString() && buton_5.Text == oyuncu_harf.ToString() && 6 != hamleler[5])
            {
                buton_6.Text = pc_harf.ToString();
                buton_6.Enabled = false;
                sira++;
                hamleler[5] = 6;
                Kim_kazandi();

            }
            else if (buton_4.Text == oyuncu_harf.ToString() && buton_6.Text == oyuncu_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();

            }
            else if (buton_4.Text == oyuncu_harf.ToString() && buton_7.Text == oyuncu_harf.ToString() && 1 != hamleler[0])
            {
                buton_1.Text = pc_harf.ToString();
                buton_1.Enabled = false;
                sira++;
                hamleler[0] = 1;
                Kim_kazandi();

            }
            else if (buton_5.Text == oyuncu_harf.ToString() && buton_6.Text == oyuncu_harf.ToString() && 4 != hamleler[3])
            {
                buton_4.Text = pc_harf.ToString();
                buton_4.Enabled = false;
                sira++;
                hamleler[3] = 4;
                Kim_kazandi();

            }
            else if (buton_5.Text == oyuncu_harf.ToString() && buton_7.Text == oyuncu_harf.ToString() && 3 != hamleler[2])
            {
                buton_3.Text = pc_harf.ToString();
                buton_3.Enabled = false;
                sira++;
                hamleler[2] = 3;
                Kim_kazandi();

            }
            else if (buton_5.Text == oyuncu_harf.ToString() && buton_8.Text == oyuncu_harf.ToString() && 2 != hamleler[1])
            {
                buton_2.Text = pc_harf.ToString();
                buton_2.Enabled = false;
                sira++;
                hamleler[1] = 2;
                Kim_kazandi();

            }
            else if (buton_5.Text == oyuncu_harf.ToString() && buton_9.Text == oyuncu_harf.ToString() && 1 != hamleler[0])
            {
                buton_1.Text = pc_harf.ToString();
                buton_1.Enabled = false;
                sira++;
                hamleler[0] = 1;
                Kim_kazandi();

            }
            else if (buton_6.Text == oyuncu_harf.ToString() && buton_9.Text == oyuncu_harf.ToString() && 3 != hamleler[2])
            {
                buton_3.Text = pc_harf.ToString();
                buton_3.Enabled = false;
                sira++;
                hamleler[2] = 3;
                Kim_kazandi();

            }
            else if (buton_7.Text == oyuncu_harf.ToString() && buton_8.Text == oyuncu_harf.ToString() && 9 != hamleler[8])
            {
                buton_9.Text = pc_harf.ToString();
                buton_9.Enabled = false;
                sira++;
                hamleler[8] = 9;
                Kim_kazandi();
            }
            else if (buton_8.Text == oyuncu_harf.ToString() && buton_9.Text == oyuncu_harf.ToString() && 7 != hamleler[6])
            {
                buton_7.Text = pc_harf.ToString();
                buton_7.Enabled = false;
                sira++;
                hamleler[6] = 7;
                Kim_kazandi();
            }
            //Hiçbir koşul sağlanmazsa rastgele oynuyor.
            else { PC_dusunmeden_oynama(); }



        }
        //Bilgisayarın önceliği kazanma olduğu için bu fonksiyon:
        void PC_kazanma_dusunmesi()
        {
            if (buton_1.Text == pc_harf.ToString() && buton_2.Text == pc_harf.ToString() && 3 != hamleler[2])
            {   //Oynadığı hamleleri kontrol ediyor.
                buton_3.Text = pc_harf.ToString();//Eğer uyuşursa hamleyi yapıyor.
                buton_3.Enabled = false;//Buton etkisiz hale getiriliyor.
                sira++;//Sıra rakibe geçiyor.
                hamleler[2] = 3;//Hamle verisi depolanıyor.
                Kim_kazandi();//Bilgisayarın kazandığı göstermek için gerekli.

            }

            else if (buton_1.Text == pc_harf.ToString() && buton_4.Text == pc_harf.ToString() && 7 != hamleler[6])
            {
                buton_7.Text = pc_harf.ToString();
                buton_7.Enabled = false;
                sira++;
                hamleler[6] = 7;
                Kim_kazandi();

            }

            else if (buton_1.Text == pc_harf.ToString() && buton_5.Text == pc_harf.ToString() && 9 != hamleler[8])
            {
                buton_9.Text = pc_harf.ToString();
                buton_9.Enabled = false;
                sira++;
                hamleler[8] = 9;
                Kim_kazandi();
            }

            else if (buton_1.Text == pc_harf.ToString() && buton_7.Text == pc_harf.ToString() && 4 != hamleler[3])
            {
                buton_4.Text = pc_harf.ToString();
                buton_4.Enabled = false;
                sira++;
                hamleler[3] = 4;
                Kim_kazandi();

            }

            else if (buton_1.Text == pc_harf.ToString() && buton_9.Text == pc_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();

            }
            else if (buton_2.Text == pc_harf.ToString() && buton_3.Text == pc_harf.ToString() && 1 != hamleler[0])
            {
                buton_1.Text = pc_harf.ToString();
                buton_1.Enabled = false;
                sira++;
                hamleler[0] = 1;
                Kim_kazandi();
            }
            else if (buton_2.Text == pc_harf.ToString() && buton_5.Text == pc_harf.ToString() && 8 != hamleler[7])
            {
                buton_8.Text = pc_harf.ToString();
                buton_8.Enabled = false;
                sira++;
                hamleler[7] = 8;
                Kim_kazandi();

            }

            else if (buton_2.Text == pc_harf.ToString() && buton_8.Text == pc_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();
            }
            else if (buton_3.Text == pc_harf.ToString() && buton_5.Text == pc_harf.ToString() && 7 != hamleler[6])
            {
                buton_7.Text = pc_harf.ToString();
                buton_7.Enabled = false;
                sira++;
                hamleler[6] = 7;
                Kim_kazandi();
            }
            else if (buton_3.Text == pc_harf.ToString() && buton_6.Text == pc_harf.ToString() && 9 != hamleler[8])
            {
                buton_9.Text = pc_harf.ToString();
                buton_9.Enabled = false;
                sira++;
                hamleler[8] = 9;
                Kim_kazandi();
            }

            else if (buton_3.Text == pc_harf.ToString() && buton_7.Text == pc_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();
            }
            else if (buton_3.Text == pc_harf.ToString() && buton_9.Text == pc_harf.ToString() && 6 != hamleler[5])
            {
                buton_6.Text = pc_harf.ToString();
                buton_6.Enabled = false;
                sira++;
                hamleler[5] = 6;
                Kim_kazandi();
            }
            else if (buton_4.Text == pc_harf.ToString() && buton_5.Text == pc_harf.ToString() && 6 != hamleler[5])
            {
                buton_6.Text = pc_harf.ToString();
                buton_6.Enabled = false;
                sira++;
                hamleler[5] = 6;
                Kim_kazandi();

            }
            else if (buton_4.Text == pc_harf.ToString() && buton_6.Text == pc_harf.ToString() && 5 != hamleler[4])
            {
                buton_5.Text = pc_harf.ToString();
                buton_5.Enabled = false;
                sira++;
                hamleler[4] = 5;
                Kim_kazandi();

            }
            else if (buton_4.Text == pc_harf.ToString() && buton_7.Text == pc_harf.ToString() && 1 != hamleler[0])
            {
                buton_1.Text = pc_harf.ToString();
                buton_1.Enabled = false;
                sira++;
                hamleler[0] = 1;
                Kim_kazandi();

            }
            else if (buton_5.Text == pc_harf.ToString() && buton_6.Text == pc_harf.ToString() && 4 != hamleler[3])
            {
                buton_4.Text = pc_harf.ToString();
                buton_4.Enabled = false;
                sira++;
                hamleler[3] = 4;
                Kim_kazandi();

            }
            else if (buton_5.Text == pc_harf.ToString() && buton_7.Text == pc_harf.ToString() && 3 != hamleler[2])
            {
                buton_3.Text = pc_harf.ToString();
                buton_3.Enabled = false;
                sira++;
                hamleler[2] = 3;
                Kim_kazandi();

            }
            else if (buton_5.Text == pc_harf.ToString() && buton_8.Text == pc_harf.ToString() && 2 != hamleler[1])
            {
                buton_2.Text = pc_harf.ToString();
                buton_2.Enabled = false;
                sira++;
                hamleler[1] = 2;
                Kim_kazandi();

            }
            else if (buton_5.Text == pc_harf.ToString() && buton_9.Text == pc_harf.ToString() && 1 != hamleler[0])
            {
                buton_1.Text = pc_harf.ToString();
                buton_1.Enabled = false;
                sira++;
                hamleler[0] = 1;
                Kim_kazandi();

            }
            else if (buton_6.Text == pc_harf.ToString() && buton_9.Text == pc_harf.ToString() && 3 != hamleler[2])
            {
                buton_3.Text = pc_harf.ToString();
                buton_3.Enabled = false;
                sira++;
                hamleler[2] = 3;
                Kim_kazandi();

            }
            else if (buton_7.Text == pc_harf.ToString() && buton_8.Text == pc_harf.ToString() && 9 != hamleler[8])
            {
                buton_9.Text = pc_harf.ToString();
                buton_9.Enabled = false;
                sira++;
                hamleler[8] = 9;
                Kim_kazandi();
            }
            else if (buton_8.Text == pc_harf.ToString() && buton_9.Text == pc_harf.ToString() && 7 != hamleler[6])
            {
                buton_7.Text = pc_harf.ToString();
                buton_7.Enabled = false;
                sira++;
                hamleler[6] = 7;
                Kim_kazandi();
            }
            //Koşullar sağlanmazsa 2.öncelik olan kaybetmeme dusunmesi fonksiyonunu kullanıyor.
            else {PC_kaybetmeme_dusunmesi(); }
        }

        void Kim_kazandi()
        {   //Kimin kazandığını kontrol eden fonksiyon.
            if ('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_2.Text && 'O'.ToString() == buton_3.Text)
            {
                buton_1.BackColor = Color.Red;//Uyuşan harfler renklendiriliyor.'O'lar için kırmızı 'X'ler için mavi.
                buton_2.BackColor = Color.Red;
                buton_3.BackColor = Color.Red;
                Bitis('O');//Hangi harf 3'lü haldeyse onu Bitis fonksiyonuna gönderiyor.
            }

            else if('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_4.Text && 'O'.ToString() == buton_7.Text)
            {
                buton_1.BackColor = Color.Red;
                buton_4.BackColor = Color.Red;
                buton_7.BackColor = Color.Red;
                Bitis('O');
            }

            else if('O'.ToString() == buton_1.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_1.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                Bitis('O');
            }

            else if('O'.ToString() == buton_2.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_8.Text)
            {
                buton_2.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_8.BackColor = Color.Red;
                Bitis('O');
            }

            else if('O'.ToString() == buton_3.Text && 'O'.ToString() == buton_6.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_3.BackColor = Color.Red;
                buton_6.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                Bitis('O');
            }

            else if('O'.ToString() == buton_4.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_6.Text)
            {
                buton_4.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_6.BackColor = Color.Red;
                Bitis('O');
            }

            else if('O'.ToString() == buton_7.Text && 'O'.ToString() == buton_8.Text && 'O'.ToString() == buton_9.Text)
            {
                buton_7.BackColor = Color.Red;
                buton_8.BackColor = Color.Red;
                buton_9.BackColor = Color.Red;
                Bitis('O');
            }

            else if('O'.ToString() == buton_7.Text && 'O'.ToString() == buton_5.Text && 'O'.ToString() == buton_3.Text)
            {
                buton_7.BackColor = Color.Red;
                buton_5.BackColor = Color.Red;
                buton_3.BackColor = Color.Red;
                Bitis('O');
            }

            else if('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_2.Text && 'X'.ToString() == buton_3.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_2.BackColor = Color.Blue;
                buton_3.BackColor = Color.Blue;
                Bitis('X');
            }

            else if('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_4.Text && 'X'.ToString() == buton_7.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_4.BackColor = Color.Blue;
                buton_7.BackColor = Color.Blue;
                Bitis('X');
            }

            else if('X'.ToString() == buton_1.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_1.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                Bitis('X');
            }

            else if('X'.ToString() == buton_2.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_8.Text)
            {
                buton_2.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_8.BackColor = Color.Blue;
                Bitis('X');
            }

            else if('X'.ToString() == buton_3.Text && 'X'.ToString() == buton_6.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_3.BackColor = Color.Blue;
                buton_6.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                Bitis('X');
            }

            else if('X'.ToString() == buton_4.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_6.Text)
            {
                buton_4.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_6.BackColor = Color.Blue;
                Bitis('X');
            }

            else if('X'.ToString() == buton_7.Text && 'X'.ToString() == buton_8.Text && 'X'.ToString() == buton_9.Text)
            {
                buton_7.BackColor = Color.Blue;
                buton_8.BackColor = Color.Blue;
                buton_9.BackColor = Color.Blue;
                Bitis('X');
            }

            else if('X'.ToString() == buton_7.Text && 'X'.ToString() == buton_5.Text && 'X'.ToString() == buton_3.Text)
            {
                buton_7.BackColor = Color.Blue;
                buton_5.BackColor = Color.Blue;
                buton_3.BackColor = Color.Blue;
                Bitis('X');
            }

            else
            {   //Eğer hamle sayısı 9 olmuşsa Bitis fonksiyonuna '-' değerini gönderiyor.
                int a = 0;
                foreach (int y in hamleler)

                {
                    if (y != 0) { a++; }
                   
                    if (a == 9)
                    {
                        Bitis('-');
                    }
                }
                
                
            }
        }

        void Bitis(char kazanan)
        {   //Butonlar etkisizleştiriliyor.
            tum_buton_etkisizlestirme();

            if (kazanan == oyuncu_harf)
            {   //Oyuncu kazanmışsa :
                sira = 1;//Bilgisayar oyun bittikten sonra devam etmesin diye.
                MessageBox.Show("Oyunu Kazandınız!", "Oyun Sonu", MessageBoxButtons.OK);
            }
            else if(kazanan == pc_harf)
            {   //Bilgisayar kazanmışsa:
                sira = 1;//Bilgisayar oyun bittikten sonra devam etmesin diye.
               
                MessageBox.Show("Oyunu Kaybettiniz!", "Oyun Sonu", MessageBoxButtons.OK);
            
            }
            //'-' mesajı burada devreye giriyor.
            else { sira = 1; MessageBox.Show("Berabere Bitti!", "Oyun Sonu", MessageBoxButtons.OK); }
            Close();//Mesaj pencerelerinde tamama basıldıktan sonra pencere kapatılıyor.
            //Bilgisayar oyun bittikten sonra devam etmesin diye sira değişkeni 1 oluyor.

        }

        void tum_buton_etkisizlestirme()
        {   //Oyun bittiği zaman insan hamle yapmasın diye.
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
        //Buton 1,2,3,4,5,6,7,8,9'a basılınca yapılacak eylemler.
        private void buton_1_Click(object sender, EventArgs e)
        { 
            buton_1.Text = oyuncu_harf.ToString();//Oyuncunun harfi atanıyor.
            buton_1.Enabled = false;//Butona tıklanma etkisiz hale getiriliyor.
            sira++;//Sıra bilgisayara geçiyor.
            hamleler[0] = 1;//Oynanan hamle verisi depolanıyor.
            Kim_kazandi();//Kim kazandı kontrol ediliyor.
            Oyuncu_hamle_kontrol();//Hamle sırası bilgisayara geçiyor.
                
        }
        private void buton_2_Click(object sender, EventArgs e)
        {
            buton_2.Text = oyuncu_harf.ToString();
            buton_2.Enabled = false;
            sira++;
            hamleler[1] = 2;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }

        private void buton_3_Click(object sender, EventArgs e)
        {
            buton_3.Text = oyuncu_harf.ToString();
            buton_3.Enabled = false;
            sira++;
            hamleler[2] = 3;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }

        private void buton_4_Click(object sender, EventArgs e)
        {
            buton_4.Text = oyuncu_harf.ToString();
            buton_4.Enabled = false;
            sira++;
            hamleler[3] = 4;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }

        private void buton_5_Click(object sender, EventArgs e)
        {
            buton_5.Text = oyuncu_harf.ToString();
            buton_5.Enabled = false;
            sira++;
            hamleler[4] = 5;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }

        private void buton_6_Click(object sender, EventArgs e)
        {
            buton_6.Text = oyuncu_harf.ToString();
            buton_6.Enabled = false;
            sira++;
            hamleler[5] = 6;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }

        private void buton_7_Click(object sender, EventArgs e)
        {
            buton_7.Text = oyuncu_harf.ToString();
            buton_7.Enabled = false;
            sira++;
            hamleler[6] = 7;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }

        private void buton_8_Click(object sender, EventArgs e)
        {
            buton_8.Text = oyuncu_harf.ToString();
            buton_8.Enabled = false;
            sira++;
            hamleler[7] = 8;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }

        

        private void buton_9_Click(object sender, EventArgs e)
        {
            buton_9.Text = oyuncu_harf.ToString();
            buton_9.Enabled = false;
            sira++;
            hamleler[8] = 9;
            Kim_kazandi();
            Oyuncu_hamle_kontrol();
        }


        

    }
}
