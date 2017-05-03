                    /****************************************************************************
                    **                            SAKARYA ÜNİVERSİTESİ
                    **                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                    **                         BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                    **                      NESNEYE DAYALI PROGRAMLAMA DERSİ
                    **                          2016-2017 BAHAR DÖNEMİ
                    **
                    **                  ÖDEV NUMARASI..........:1.Ödev
                    **                  ÖĞRENCİ ADI............:İbrahim KUŞ
                    **                  ÖĞRENCİ NUMARASI.......:b161210040
                    **                  DERSİN ALINDIĞI GRUP...:I-C (Birinci öğretim-C Grubu)
                    ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOkulOdev
{
    class Program
    {
        public static string araBul(string kelimeGir,char karakterGir)
        {
            string ara = "";
            int iIndis = kelimeGir.IndexOf(karakterGir);
            int sIndis = kelimeGir.IndexOf(karakterGir, iIndis + 1);

            int uzunluk = sIndis - iIndis - 1;
            ara = kelimeGir.Substring(iIndis + 1, uzunluk);
            return ara;

        }

        public static string araTers(string kelimeGir)
        {
            string tersKelime = "";

            char[] klm = kelimeGir.ToCharArray();
            int uzunluk = klm.Length - 1;
            for(int i=uzunluk; i>=0 ;i--)
            {
                tersKelime += klm[i];
            }
            return tersKelime;

        }

        static void Main(string[] args)
        {
            
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(".....:İşlemler:.....");
                Console.WriteLine("1-Matris İşlemleri");
                Console.WriteLine("2-String İşlemleri");
                Console.WriteLine("3-Çıkış");
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());


            switch (secim)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("....::Matris İşlemleri::....");
                    Console.Write("Matrisin satır sayısını giriniz(1-10 arasında): ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int[,] dizib = new int[b, b];
                    //dizib dizisininin satırlarına kullanıcıdan sayılar alıyorum.
                    for (int i = 0; i < b; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        //dizib dizisinin sütunlarına kullanıcıdan sayılar alıyorum.
                        for (int j = 0; j < b; j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            dizib[i, j] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("[{0},{1}]={2}", i + 1, j + 1, dizib[i, j]);

                        }

                    }
                    //dizib içindeki satırlar arasında dönecek döngümü oluşturuyorum.
                    for (int i = 0; i < b; i++)
                    {
                        // Dizib içindeki sütunlar arasında dönecek döngümüzü oluşturuyorum 
                        for (int j = 0; j < b; j++)
                        {
                            Console.Write("{0} ", dizib[i, j]);
                        }
                        Console.WriteLine(); //boş satır
                    } //Dön

                    Console.WriteLine(" ");
                    Console.WriteLine("1-Satır En Buyuk");
                    Console.WriteLine("2-Satır Toplam");
                    Console.Write("Seçiminiz: ");
                    int sec = Convert.ToInt32(Console.ReadLine());
                    switch (sec)
                    {
                        case 1:
                            int max = 0;
                            //dizib içerisindeki sayıları tartıp sayıların en büyüğünü buluyorum.
                            foreach (int r in dizib)
                            {
                                if (r > max)
                                    max = r;
                                else
                                    max = max;
                            }

                            Console.WriteLine("Sonuç: ");
                            Console.WriteLine("{0} ", max);
                            Console.WriteLine("Devam etmek için tıklayınız.");
                            Console.ReadKey();
                            break;
                        case 2:
                            int toplam = 0;
                            //dizib içerisindeki sayıları taratıp bu sayıların hepsini toplma değişkenine atıyorum.
                            foreach (int r in dizib)
                            {
                                toplam += r;
                            }

                            Console.WriteLine("{0} ", toplam);
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Hatalı Seçim");
                            Console.WriteLine("Devam Etmek İçin Tıklayınız.");
                            Console.Clear();
                            break;
                    }
                    Console.Clear();

                    break;
                    
                case 2:
                    Console.Clear();
                    Console.WriteLine("...::String İşlemleri::...");
                    Console.Write("İşlem Yapılacak Stringi Seçiniz: ");

                    string str = Console.ReadLine();
                    Console.Write("İstenen harf: ");
                    char aranan = Convert.ToChar(Console.ReadLine());
                    int harfSayisi = 0;

                    //diziyi taratıyorum eğer istediğimiz harf varsa harfsayısını bir arttıryorum.
                    foreach (char i in str)
                    {
                        if (aranan == i)
                            harfSayisi++;
                    }

                    if (harfSayisi >= 2)
                    {
                        Console.WriteLine("1-Ara metni tersten yazdır");
                        Console.WriteLine("2-Ara metni tekrarlı yazdır");
                        Console.Write("Seçiminiz: ");
                        int strSec = Convert.ToInt32(Console.ReadLine());

                        switch (strSec)
                        {
                            case 1:
                                //Metotlar aracılığıyla ara kelimeyi buluyorum.
                                string araKelime = araBul(str, aranan);
                                //MEtotlar aracılığıyla bulduğum kelimeyi başka bir metot kullanarak
                                //ara kelimeyi ekrana tersten yazdırıyorum.
                                Console.WriteLine(araTers(araKelime));
                                Console.ReadKey();          

                                break;
                            case 2:
                                string araKlm1 = araBul(str, aranan);
                                //Bulduğum ara kelimeyi 5 kere ekrana basıyorum.
                                for (int i=0;i<5;i++)
                                {
                                    Console.WriteLine(araKlm1);
                                }
                                Console.ReadKey();
                               
                                break;
                            default:
                                Console.WriteLine("hatalı secim");
                                Console.ReadKey();
                                break;

                        }
                        Console.WriteLine("Devam etmek için tıklayınız.");
                        Console.Clear();
                    }
                    //eğer verdiğimiz cümle içerisinde aradığımız harf yoksa yapılacak olan işlemleri yazıyorum.
                    else
                    {
                        Console.WriteLine("Cümle içerisinde aranan harf bulunamamıstır");
                        Console.WriteLine("Devam etmek için tıklayınız.");
                        Console.ReadKey();
                    }
                    
                    break;
            
                    case 3:
                        Console.WriteLine("Çıkış Yapmak");
                        Console.WriteLine("Devam etmek için tıklayınız.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim");
                        Console.WriteLine("Devam etmek için tıklayınız.");
                        Console.ReadKey();
                        break;
                }
            //Ekranı temizliyorum.
            Console.Clear();
        }
    }
}
