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

                                        //Müşteri

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class b161210040_odev31
    {
        public new string adi;
        public new string adresi;
        public new long iFax;
        public new long iTel;
        public new long iGsm;
        public new string mail;
        public new string WebLink;
        public new long VergiNumara;
        DateTime alınanSiparis;
        private new int bakiye1;

        public int Bakiye1
        {
            set
            {
                bakiye1=value;
                
            }
            get
            {
                return bakiye1;
            }
        }

        public b161210040_odev31(string mAd,string mAdr,int mB1,DateTime aS,long mF,long mG,long mTel,string mMail,int mVergi,string mWeb)
        {
            this.adi = mAd;
            this.adresi = mAdr;
            this.Bakiye1 = mB1;
            this.alınanSiparis = aS;
            this.iFax = mF;
            this.iGsm = mG;
            this.iTel = mTel;
            this.mail = mMail;
            this.VergiNumara = mVergi;
            this.WebLink = mWeb;
        }

        public void MusteriBilgi()
        {
            

            Console.WriteLine("Musteri adi: " + adi);
            Console.WriteLine("Musteri adresi: " + adresi);
            Console.WriteLine("Musteri bakiyesi: " + Bakiye1);
            Console.WriteLine("Müşteriden siparisin alındığı tarih: " + alınanSiparis);
            Console.WriteLine("Musteri fax: " + iFax);
            Console.WriteLine("Musteri Gsm: " + iGsm);
            Console.WriteLine("Musteri Tel: " + iTel);
            Console.WriteLine("Musteri mail: " + mail);
            Console.WriteLine("Musteri Vergi Numarası: " + VergiNumara);
            Console.WriteLine("Musteri WebLink: " + WebLink);
            Console.WriteLine("Musteri son bakiyesi: ");
            
        }
       
    }
}
