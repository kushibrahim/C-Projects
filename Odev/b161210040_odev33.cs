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


                                        //Tam Mamul

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class b161210040_odev33:b161210040_odev35
    {
        public new string UrunAdi;
        public new double UretimKutleBuyuklugu = 1;
        public new double fiyat;
        public new double UrunMiktari;

        public override void bilgi()
        {
            Console.WriteLine("Uretim Kutle Buyuklugu(0.5=YariMamul,TamMamul=1): " + UretimKutleBuyuklugu);
            Console.Write("Fiyatını giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün adini giriniz: ");
            UrunAdi = Convert.ToString(Console.ReadLine());
            Console.Write("Urun Miktarını giriniz: ");
            UrunMiktari = Convert.ToInt32(Console.ReadLine());
        }

    }
}
