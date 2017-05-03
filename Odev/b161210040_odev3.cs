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

                                            //Hammadde
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class b161210040_odev3
    {
        public string HammaddeAdi;
        public int HammaddeMiktari;
        public int HammaddeBarkod;
        public string HammaddeTedarikci;
        public DateTime HammaddeSatınAlma;
        public int minSiparisMiktari;
        public int HammaddeFiyat;


        public b161210040_odev3(string hA,int hM,int hB,string hT,int hMSM,int hF)
        {
            this.HammaddeAdi = hA;
            this.HammaddeMiktari = hM;
            this.HammaddeBarkod = hB;
            this.HammaddeTedarikci = hT;
            this.minSiparisMiktari = hMSM;
            this.HammaddeFiyat = hF;
        }


        public void HBilgiGoster()
        {
            Console.WriteLine("Hammadde Adi: " + HammaddeAdi);
            Console.WriteLine("Hammadde Miktarı:{0}",HammaddeMiktari);
            Console.WriteLine("Hammadde Barkod:{0}",HammaddeBarkod );
            Console.WriteLine("Hammadde Tedarikci Adi:{0}",HammaddeTedarikci);
            Console.WriteLine("Hammadde Minimum Siparis Miktarı:{0}",minSiparisMiktari);
            Console.WriteLine("Hammadde Fiyatı:{0}", HammaddeFiyat);
        }
    }
}
