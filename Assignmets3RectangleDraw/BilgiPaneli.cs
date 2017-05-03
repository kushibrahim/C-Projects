                            /****************************************************************************
                            **					        SAKARYA UNIVERSITY
                            **				        BILGISAYAR MUHENDISLIGI BOLUMU
                            **				          NESNEYE DAYALI PROGRAMLAMA 
                            **				
                            **				OGRENCI ISMI.....:İbrahim   
                            **				OGRENCI SOYISMI..:KUŞ
                            **				OGRENCI NUMARASI.:b161210040
                            **				DERS GRUBU…………………:I-C (1.Öğretim C grubu)
                            ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortgenOdev25Mart
{
    public class BilgiPaneli
    {
        
        private Dortgen aktifSekil;
        private Dortgen cizimAlani = new Dortgen();
        private int genislik;
        private int x;
        private int y;
        private int yukseklik;


        public BilgiPaneli(int genislik, int yukseklik)
        {
            this.cizimAlani.BoyutAta(genislik, yukseklik);
            this.cizimAlani.RenkAta(ConsoleColor.DarkBlue);
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }

        public void Ciz()
        {
            this.cizimAlani.Ciz();
            if (this.aktifSekil != null)
            {
                this.BilgiCiz();
            }
        }

        public void SekilAta(Dortgen sekil)
        {
            this.aktifSekil = sekil;
        }

        public void KonumAta(int x, int y)
        {
           
            this.x = x;
            this.y = y;
            this.cizimAlani.KonumAta(x, y);
        }

        public void BilgiCiz()
        {
            int ortala = this.x + 10;

            Console.SetCursorPosition(ortala, this.y + 0);
            Console.WriteLine("BİLGİ PANELİ");
            Console.SetCursorPosition(ortala, this.y + 2);
            Console.WriteLine("X................:{0}", this.aktifSekil.X);
            Console.SetCursorPosition(ortala, this.y + 4);
            Console.WriteLine("Y................:{0}", this.aktifSekil.Y);
            Console.SetCursorPosition(ortala, this.y + 6);
            Console.WriteLine("Genislik.........:{0}", this.aktifSekil.Genislik);
            Console.SetCursorPosition(ortala, this.y + 8);
            Console.WriteLine("Yukseklik........:{0}", this.aktifSekil.Yukseklik);
            Console.SetCursorPosition(ortala, this.y + 10);
            Console.WriteLine("Renk.............:{0}", this.aktifSekil.Renk.ToString());
        }
    }

}
