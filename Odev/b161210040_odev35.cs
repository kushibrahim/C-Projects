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

                                    //Yarı Mamul
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
     class b161210040_odev35
    {
        public string UrunAdi;
        public DateTime UretimTarihi;
        public double UretimKutleBuyuklugu=0.5;
        public double UrunMiktari;
        public double fiyat;


        public virtual void bilgi()
        {
            Console.WriteLine("Uretim Kutle Buyuklugu(0.5=YariMamul,TamMamul=1): " + UretimKutleBuyuklugu);
            Console.Write("Fiyatını giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Urun Miktarını giriniz: ");
            UrunMiktari = Convert.ToInt32(Console.ReadLine());
        }

    }
}
