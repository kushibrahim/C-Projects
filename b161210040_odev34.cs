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

                                //Tedarikçi

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class b161210040_odev34
    {
        public string adi;
        public string adresi;
        public long iFax;
        public long iTel;
        public long iGsm;
        public string mail;
        public string WebLink;
        public long VergiNumara;
        DateTime siparisVerilenGun;


        private int bakiye;
        public int Bakiye
        {
            set
            {
                value = bakiye;
            }

            get
            {
                return bakiye;
            }

        }

        public b161210040_odev34(string tA,string tAdr,int b1,DateTime sG,int tF,int tGsm,int tTel,string tMail,int tVergiN,string tWebL)
        {
            this.adi = tA;
            this.adresi = tAdr;
            this.Bakiye = b1;
            this.siparisVerilenGun = sG;
            this.iFax = tF;
            this.iGsm = tGsm;
            this.iTel = tTel;
            this.mail = tMail;
            this.VergiNumara = tVergiN;
            this.WebLink = tWebL;
        }

        public void TedarikBilgi()
        {
            Console.WriteLine("Tedarikci adi: " + adi);
            Console.WriteLine("Tedarikci adresi: " + adresi);
            Console.WriteLine("Tedarikci bakiyesi: " + Bakiye);
            Console.WriteLine("Tedarikçiye sipariş verilen tarih(gun/ay/yıl):{0}",siparisVerilenGun);
            Console.WriteLine("Tedarikci fax: " + iFax);
            Console.WriteLine("Tedarikci Gsm: " + iGsm);
            Console.WriteLine("Tedarikci Tel: " + iTel);
            Console.WriteLine("Tedarikci mail: " + mail);
            Console.WriteLine("Tedarikci Vergi Numarası: " + VergiNumara);
            Console.WriteLine("Tedarikci WebLink: " + WebLink);
            

        }
    }
}
