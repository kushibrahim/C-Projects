                                    /****************************************************************************
                                    **                          SAKARYA ÜNİVERSİTESİ
                                    **                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
                                    **                       BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
                                    **                      NESNEYE DAYALI PROGRAMLAMA DERSİ
                                    **                          2016-2017 BAHAR DÖNEMİ
                                    **
                                    **                      ÖDEV NUMARASI..........:3.Ödev
                                    **                      ÖĞRENCİ ADI............:İbrahim KUŞ
                                    **                      ÖĞRENCİ NUMARASI.......:b161210040
                                    **                      DERSİN ALINDIĞI GRUP...:I-C
                                    ****************************************************************************/

                                    //Program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class b161210040_odev32
    {
        public static int Menu()
        {
            int secim = 0;
            Console.Clear();
            Console.WriteLine("1-Yarı Mamul Sat");
            Console.WriteLine("2-Tam Mamul Sat");
            Console.WriteLine("3-Hammadde Al");
            Console.WriteLine("4-Musteri Listele");
            Console.WriteLine("5-Tedarikci Listele");
            Console.WriteLine("6-Çıkış");
            Console.Write("Seçim:");
            secim = int.Parse(Console.ReadLine());
            return secim;
        }
        static void Main(string[] args)
        {
            int sayac = 0;
            int sayac2 = 0;
            
            //Musteri sınıfından 100 birimlik dizi olusturuyorum.
            b161210040_odev31[] musteriler = new b161210040_odev31[100];
            //tedarikci sınıfından 100 birimlik dizi olusturuyorum.
            b161210040_odev34[] tedarikciler = new b161210040_odev34[100];

            int secim = 0;
            do
            {
                secim = Menu();
                Console.Clear();
                switch (secim)
                {
                    case 6: break;
                    case 1:
                        {
                            int a;
                            string mAd, mAdr, mWeb, mMail;
                            long mF, mG, mTel;
                            int mB1, mVergi;
                            //Müşteri bilgilerini kullanıcıdan alıyorum.
                            Console.Write("Müşteri adını giriniz: ");
                            mAd = Console.ReadLine();
                            Console.Write("Müşteri adresini giriniz: ");
                            mAdr = Console.ReadLine();
                            Console.Write("Müşteri bakiyesini giriniz: ");
                            mB1 = Convert.ToInt32(Console.ReadLine());
                            DateTime aS = DateTime.Now;
                            Console.WriteLine("Siparis tarihi:{0}", aS);
                            Console.Write("Müşteri fax'ı giriniz: ");
                            mF = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Müşteri gsm'i giriniz: ");
                            mG = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Müşteri telefonunu giriniz: ");
                            mTel = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Müşteri maili giriniz: ");
                            mMail = Console.ReadLine();
                            Console.Write("Müşteri vergi numarasını giriniz: ");
                            mVergi = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Müşteri web adrwsini giriniz: ");
                            mWeb = Console.ReadLine();


                            Console.Clear();

                            b161210040_odev35 y1 = new b161210040_odev35();
                            y1.bilgi();
                            //Musteri bilgilerini musteri dizisine atıyorum.
                            musteriler[sayac++] = new b161210040_odev31(mAd,mAdr,mB1,aS,mF,mG,mTel,mMail,mVergi,mWeb);
                            //Kalan bakiyeyi hesaplıyorum.(a=Kalan bakiye)
                            a = mB1 - Convert.ToInt32(y1.fiyat * y1.UrunMiktari);
                            musteriler[sayac-1].MusteriBilgi();
                            //Eğer (a=Kalan bakiye) a<0 ise yapılacak işlemleri yazıyorum.
                            if (a < 0)
                            {
                                Console.WriteLine("Siparis iptal edilmiştir");
                                Console.WriteLine("Müşteri son bakiyesi: " + mB1);
                            }
                            //(a=Kalan bakiye) a>0 ise yapılacak işlemleri yazıyorum.
                            else if (a > 0)
                            {
                                Console.Write("Musteri son bakiyesi: " + a);
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            int a;
                            string mAd, mAdr, mWeb, mMail;
                            long mF, mG, mTel;
                            int mB1, mVergi;

                           
                            //Müşteri bilgilerini kullanıcıdan alıyorum.
                            Console.Write("Müşteri adını giriniz: ");
                            mAd = Console.ReadLine();
                            Console.Write("Müşteri adresini giriniz: ");
                            mAdr = Console.ReadLine();
                            Console.Write("Müşteri bakiyesini giriniz: ");
                            mB1 = Convert.ToInt32(Console.ReadLine());
                            DateTime aS = DateTime.Now;
                            Console.WriteLine("Siparis tarihi: {0}", aS);
                            Console.Write("Müşteri fax'ı giriniz: ");
                            mF = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Müşteri gsm'i giriniz: ");
                            mG = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Müşteri telefonunu giriniz: ");
                            mTel = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Müşteri maili giriniz: ");
                            mMail = Console.ReadLine();
                            Console.Write("Müşteri vergi numarasını giriniz: ");
                            mVergi = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Müşteri web adrwsini giriniz: ");
                            mWeb = Console.ReadLine();
                            

                            Console.Clear();

                            
                            b161210040_odev33 y1 = new b161210040_odev33();
                            y1.bilgi();
                            musteriler[sayac++] = new b161210040_odev31(mAd, mAdr, mB1, aS, mF, mG, mTel, mMail, mVergi, mWeb);
                            //Kalan bakiyeyi hesaplıyorum.(a=Müsteri kalan bakiye)
                            a = mB1 - Convert.ToInt32(y1.fiyat * y1.UrunMiktari);
                            musteriler[sayac-1].MusteriBilgi();
                            //Eğer (a=Müsteri kalan bakiye) a<0 ise yapılacak işlemleri yazıyorum.
                            if (a < 0)
                            {
                                Console.WriteLine("Siparis iptal edilmiştir");
                                Console.WriteLine("Müşteri son bakiyesi: " + mB1);
                            }
                            //(a=Müsteri kalan bakiye) a>0 ise yapılacak işlemleri yazıyorum.
                            else if (a > 0)
                            {
                                Console.Write("Musteri son bakiyesi: " + a);
                            }
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            int b;
                            string hA, hT;
                            int hM, hB, hMSM, hF;

                           //Hammadde bilgilerini kullanıcıdan alıyorum.
                            Console.Write("Hammadde adi giriniz: ");
                            hA = Console.ReadLine();
                            Console.Write("Hammadde miktarını giriniz: ");
                            hM = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Hammadde barkodunu giriniz: ");
                            hB = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Hammadde tedarikcisini giriniz: ");
                            hT = Console.ReadLine();
                            Console.Write("Minimmum siparis miktarını giriniz: ");
                            hMSM = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Hammadde fiyatı giriniz: ");
                            hF = Convert.ToInt32(Console.ReadLine());

                            //Hammadde bilgilerini tutarak, ekranı temizliyorum.
                            Console.Clear();

                            Random rnd = new Random();
                            string tA, tAdr, tMail, tWebL;
                            int b1, tF, tGsm, tTel, tVergiN,sonBakiye;

                            //Tedarikçi bilgilerini kullanıcıdan alıyorum.
                            Console.Write("Tedarikçi adi giriniz: ");
                            tA = Console.ReadLine();
                            Console.Write("Tedarikçi adresi giriniz: ");
                            tAdr = Console.ReadLine();
                            Console.Write("Tedarikçi bakiyesi giriniz: ");
                            b1 = Convert.ToInt32(Console.ReadLine());
                            DateTime sG = DateTime.Now;
                            Console.WriteLine("Siparis tarihi:{0}",sG);
                            Console.Write("Tedarikçi fax'ı giriniz: ");
                            tF = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tedarikçi GSM giriniz: ");
                            tGsm = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tedarikçi telefonu giriniz: ");
                            tTel = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tedarikçi maili giriniz: ");
                            tMail = Console.ReadLine();
                            Console.Write("Tedarikçi vergi numarası giriniz: ");
                            tVergiN = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Tedarikçi web linki giriniz: ");
                            tWebL = Console.ReadLine();

                            
                            //Tedarikci bilgilerini tutarak, ekranı temizliyorum.
                            Console.Clear();

                            b161210040_odev3 h1 = new b161210040_odev3(hA,hM,hB,hT,hMSM,hF);
                            tedarikciler[sayac2++] = new b161210040_odev34(tA,tAdr,b1,sG,tF,tGsm,tTel,tMail,tVergiN,tWebL);
                            h1.HBilgiGoster();
                            tedarikciler[sayac2-1].TedarikBilgi();
                            //Eğer minSiparisMiktarı hammade miktarından büyükse yapılacak işlemleri yazdım.
                            if (hM<hMSM)
                            {
                                Console.WriteLine("!!!En az " + hMSM + " birim siparis vermelisiniz");
                                
                            }

                            //Eğer hammadde miktarı, minSiparisMiktarı'ndan büyükse yapılacak işlemleri yazdım.
                            if (hM > hMSM)
                            {
                                //Eğer tedarikci adı, hammadde tedarikcisi adına eşitse tedarikci bakiyesinde işlem yapıyorum.
                                if (tA == hT)
                                {
                                    b = b1 + (hF * hM);
                                    sonBakiye = b;
                                    Console.WriteLine("Tedarikçi son bakiyesi: " + b);

                                }
                                //Eğer tedarikci adı, hammadde tedarikcisi adına eşit değilse tedarikci bakiyesinde işlem yapıyorum.
                                else
                                {
                                    sonBakiye = b1;
                                    Console.WriteLine("Tedarikçi son bakiyesi: " + b1);
                                }
                                
                            }

                            Console.ReadKey();
                            break;
                        }
                    case 4:

                        
                        //Eklenen müsteri bilgileri içerisinde gezerek, müsteri bilgilerini ekrana yazdırıyorum.
                        for (int i = 0; i < sayac; i++)
                            { 
                                musteriler[i].MusteriBilgi();
                                Console.WriteLine(i+1 + ". müsteri bilgileri getirilmiştir.");
                                Console.WriteLine("--------------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        
                    case 5:
                        
                        //Eklenen tedarikci bilgileri içerisinde gezerek, tedarikci bilgilerini ekrana yazdırıyorum.
                        for (int i = 0; i < sayac2; i++)
                            {

                            tedarikciler[i].TedarikBilgi();
                            Console.WriteLine(i + 1 + " . müşteri bilgileri getirilmiştir");
                            Console.WriteLine("-----------------------");
                            }
                            Console.ReadKey();
                            break;
                        
                    default:
                        //Kullanıcı eğer menu dısındaki sayılardan herhangi birini girerse karsısına hata mesajı çıkartıyorum.
                        Console.WriteLine("Hatalı giriş yapılmıştır");
                        break;
                }
            } while (secim != 6);


            Console.ReadKey();
        }
    }
}
