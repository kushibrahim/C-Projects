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
    public class KontrolPaneli
    {
        
        private Dortgen cizimAlani = new Dortgen();
        private int genislik;
        private int x;
        private int y;
        private int yukseklik;

        
        public KontrolPaneli(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.cizimAlani.BoyutAta(genislik, yukseklik);
            this.cizimAlani.RenkAta(ConsoleColor.Yellow);
        }

        public void MenuCiz()
        {
            int ortala = this.x + 10;

            Console.SetCursorPosition(ortala, this.y + 0);
            Console.WriteLine("KONTROL PANELI");
            Console.SetCursorPosition(ortala, this.y + 2);
            Console.WriteLine("Şekil Ekle   ( E )");
            Console.SetCursorPosition(ortala, this.y + 4);
            Console.WriteLine("Sola Ötele   ( A )");
            Console.SetCursorPosition(ortala, this.y + 6);
            Console.WriteLine("Sağa Ötele   ( D )");
            Console.SetCursorPosition(ortala, this.y + 8);
            Console.WriteLine("Yukarı Ötele ( W )");
            Console.SetCursorPosition(ortala, this.y + 10);
            Console.WriteLine("Aşağı Ötele  ( S )");
        }

       
        public void KonumAta(int x, int y)
        {
            this.y = y;
            this.x = x;
            this.cizimAlani.KonumAta(x, y);
        }

        public void Ciz()
        {
            this.cizimAlani.Ciz();
            this.MenuCiz();
        }
    }
}
