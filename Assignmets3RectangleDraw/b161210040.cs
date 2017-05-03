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
    public class b161210040
    {

        public static void Main(string[] args)
        {

            Console.SetWindowSize(100, 34);
            BilgiPaneli b1 = new BilgiPaneli(40, 17);
            KontrolPaneli k1 = new KontrolPaneli(40, 17);
            SahnePaneli s1 = new SahnePaneli(60, 33);
            k1.KonumAta(60, 0);
            b1.KonumAta(60, 17);
            Dortgen yeniSekil = null;

            while (true)
            {
                Console.Clear();
                k1.Ciz();
                s1.Ciz();
                b1.Ciz();


                ConsoleKeyInfo Tus = Console.ReadKey();
                
                if (Tus.Key == ConsoleKey.E)
                {
                    yeniSekil = new Dortgen(60, 33);
                    s1.AktifSekilAta(yeniSekil);
                    b1.SekilAta(yeniSekil);
                }

                if (yeniSekil != null)
                {
                    if (Tus.Key == ConsoleKey.A)
                    {
                        s1.SekilSolaOtele();
                    }
                    if (Tus.Key == ConsoleKey.D)
                    {
                        s1.SekilSagaOtele();
                    }
                    if (Tus.Key == ConsoleKey.W)
                    {
                        s1.SekilYukariOtele();
                    }
                    if (Tus.Key == ConsoleKey.S)
                    {
                        s1.SekilAsagiOtele();
                    }
                }
            }
        }
    }

}
