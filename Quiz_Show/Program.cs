using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Show
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Bilgi Yarışmasına Hoşgeldiniz ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Yarışma Başlıyor.. Bol Şans");
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("1");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            int soru = 1;
            string cevap;


            if (soru == 1)
            {
                Console.WriteLine("1.Türkiye'nin Başkenti Neresidir? ");
                Console.WriteLine();
                Console.WriteLine("A) İSTANBUL \nB) ANKARA \nC) BURSA \nD) ADANA ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "b" || cevap == "B")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Cevap Yanlış Tekrar Deneyiniz...");
                    Console.WriteLine("Çıkış Yapılıyor Toplam Puanınız = 0");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }

            Console.WriteLine("**TEBRİKLER**  2.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();


            Console.WriteLine();
            if (soru == 2)
            {
                Console.WriteLine("2.Cumhuriyet Kaç Yılında İlan Edilmiştir?");
                Console.WriteLine();
                Console.WriteLine("A) 1920 \nB) 1921 \nC) 1922 \nD) 1923 ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 10");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }


            Console.WriteLine("**TEBRİKLER** 3.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (soru == 3)
            {
                Console.WriteLine("3.İzmir Hangi Coğrafi Bölgemizdedir");
                Console.WriteLine();
                Console.WriteLine("A) EGE \nB) MARMARA \nC) KARADENİZ \nD) DOĞU ANADOLU ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "a" || cevap == "A")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 20");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }


            Console.WriteLine("**TEBRİKLER**  4.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (soru == 4)
            {
                Console.WriteLine("4.Boyozu İle Meşhur İlimiz Hangisidir");
                Console.WriteLine();
                Console.WriteLine("A) IĞDIR \nB) MARDİN \nC) İZMİR \nD) KONYA ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "c" || cevap == "C")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 30");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }

            Console.WriteLine("**TEBRİKLER**  5.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (soru == 5)
            {
                Console.WriteLine("5.Toros Dağları Türkiye'nin Hangi Bölgesindedir? ");
                Console.WriteLine();
                Console.WriteLine("A) KARADENİZ \nB) EGE \nC) AKDENİZ \nD) GÜNEY ANADOLU ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "c" || cevap == "C")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 40");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }

            Console.WriteLine("**TEBRİKLER**  6.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();


            if (soru == 6)
            {
                Console.WriteLine("6.Seyatnamenin Yazarı Kimdir? ");
                Console.WriteLine();
                Console.WriteLine("A) NAMIK KEMAL \nB) TOLSTOY \nC) TURGUT UYAR \nD) EVLİYA ÇELEBİ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 50");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }



            Console.WriteLine("**TEBRİKLER**  7.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (soru == 7)
            {
                Console.WriteLine("7.Hangi Sayı 2 ve 9  Sayılarına Kalansız Bölünür? ");
                Console.WriteLine();
                Console.WriteLine("A) 121 \nB) 126 \nC) 128 \nD) 129 ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "b" || cevap == "B")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 60");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }


            Console.WriteLine("**TEBRİKLER**  8.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (soru == 8)
            {
                Console.WriteLine("8.Türkiye Kaç Cografi Bölgeden Oluşur? ");
                Console.WriteLine();
                Console.WriteLine("A) 5 \nB) 8 \nC) 6 \nD) 7 ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "d" || cevap == "D")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 70");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }


            Console.WriteLine("**TEBRİKLER**  9.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (soru == 9)
            {
                Console.WriteLine("9.Sıra Gecesi ile Bilinen Şehrimiz Hangisidir? ");
                Console.WriteLine();
                Console.WriteLine("A) ŞANLIURFA \nB) GAZİANTEP \nC) MARDİN \nD) KONYA ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "a" || cevap == "A")
                {
                    soru = soru + 1;

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 80");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(soru);
                }
            }


            Console.WriteLine("**TEBRİKLER**  10.SORU GELİYOR.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            if (soru == 10)
            {
                Console.WriteLine("10.Avrupa Birliğinin Başkenti Neresidir?");
                Console.WriteLine();
                Console.WriteLine("A) İSTANBUL \nB) PARİS \nC) BRÜKSEL \nD) BERLİN ");
                Console.WriteLine();
                Console.Write("Cevabınız :");
                cevap = Console.ReadLine();
                Console.WriteLine();

                if (cevap == "c" || cevap == "C")
                {

                    Console.WriteLine("Tebrikler Yarışmayı Bitirdiniz");
                    Console.WriteLine("Toplam Puanınız : 100");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(soru);

                }
                else
                {
                    Console.WriteLine("Cevabınız Yanlış Yarışma Bitti");
                    Console.WriteLine("Toplam Puanınız : 90");
                }
            }
            Console.Read();
        }
    }
}
