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
    public class Dortgen
    {
        
        private int genislik;
        private ConsoleColor renk;
        private int x;
        private int xSinir;
        private int y;
        private int ySinir;
        private int yukseklik;

        
        public Dortgen()
        { 
            this.renk = ConsoleColor.DarkRed;
        }

        public Dortgen(int xSinir, int ySinir)
        {
            this.xSinir = xSinir;
            this.ySinir = ySinir;
            this.renk = (ConsoleColor)RastgeleSayi.SayiUret(1, 15);
            this.x = RastgeleSayi.SayiUret(1, (xSinir-this.genislik ) - 20);
            this.y = RastgeleSayi.SayiUret(1, (ySinir-this.yukseklik )- 10);
            this.genislik = RastgeleSayi.SayiUret(2, 20);
            this.yukseklik = RastgeleSayi.SayiUret(2, 10);
        }

         public void BoyutAta(int genislik, int yukseklik)
        {
            //genislik ve yükseklik degişkeninin bu sınıfta olan değişkenlere ait olduğunu bildiriyorum.
            this.yukseklik = yukseklik;
            this.genislik = genislik;
        }


        public void KonumAta(int x, int y)
        {
            this.y = y;
            this.x = x;
           
        }

        public void Ciz()
        {
            ConsoleColor foreCol1 = Console.ForegroundColor;
            Console.ForegroundColor = this.renk;
            this.TepeCiz();
            this.DikeyCiz();
            this.TabanCiz();
            Console.ForegroundColor = foreCol1;
        }

        public void RenkAta(ConsoleColor renk)
        {
            //renk değişkeninin bu sınıfta olan renk değişkenine ait olduğunu bildiriyorum.
            this.renk = renk;
        }

        public void SagaOtele()
        {
            //x'i bir arttırıyorum.
            this.x++;
        }
        public void AsagiOtele()
        {
            //y'yi bir arttırıyorum.
            this.y++;
        }
        public void SolaOtele()
        {
            //x'i bir azaltıyorum.
            this.x--;
        }
        public void YukariOtele()
        {
            //y'yi bir azaltıyorum.
            this.y--;
        }

        public void DikeyCiz()
        {

            for (int i = 1; i < (this.yukseklik - 1); i++)
            {
                //Her seferinde imlecim bir aşağı tarafa inecek şekilde imleci tanımlıyorum.
                Console.SetCursorPosition(this.x, this.y + i);
                //(yukseklik-1)'e kadar dörtgenin (0,0) noktasındaki kenarını cizdiriyorum
                Console.Write(KarakterSeti.Dikey);
                //İmleci bu sefer genislik kadar ileriye götürüp (0,0) noktasının karsısındaki kenarı yazdırması için tanımlıyorum.
                Console.SetCursorPosition((this.x + this.genislik) - 1, (this.y + i));
                //(genislik-1)'e kadar dörtgenin başlangıç noktasının karşısındaki kenarını cizdiriyorum
                Console.Write(KarakterSeti.Dikey);
            }
        }

        public void TabanCiz()
        {
            //imlecimi tanımlıyorum.
            Console.SetCursorPosition((this.x), (this.y + this.yukseklik) - 1);
            Console.Write(KarakterSeti.SolAltKose);
            //Daha sonra imlecin başlangıç değerinden (genislik-2) kadar KarakterSeti sınıfının düz elemanını yazdırıyorum.
            //(genislik-2) olmasının sebebi basta ve sonda dörtgenin köselerini yazdırmam dolayısıyla (genislik-2)'ye kadar!
            for (int i = 0; i < (this.genislik - 2); i++)
            {
                Console.Write(KarakterSeti.Duz);
            }
            //Daha sonra dörtgenin sağaltköse karakterseti'ni ekrana yazdırıyorum.
            Console.Write(KarakterSeti.SagAltKose);
        }

        public void TepeCiz()
        {
            //İmlecimi tanımlıyorum.
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(KarakterSeti.SolUstKose);
            //Çizdirmeden sonra imlecin nerede duracağını tanımlıyorum.
            Console.SetCursorPosition(this.x + 1, this.y);
            //Daha sonra imlecin başlangıç değerinden (genislik-2) kadar KarakterSeti sınıfının düz elemanını yazdırıyorum.
            //(genislik-2) olmasının sebebi basta ve sonda dörtgenin köselerini yazdırmam dolayısıyla (genislik-2)'ye kadar!
            for (int i = 0; i < (this.genislik - 2); i++)
            {
                Console.Write(KarakterSeti.Duz);
            }
            //Daha sonra dörtgenin sağüstköse karakterseti'ni ekrana yazdırıyorum.
            Console.Write(KarakterSeti.SagUstKose);
        }

        //Private olan üye elemanları property kullanarak dışarı kapattım.Dışarıdan sadece set ve get blokları ile erişilebilirler.
        public int Genislik
        {
            
            set
                {
                    this.genislik = value;
                }
            get
                {
                    return genislik;
                }
        }

        
        public ConsoleColor Renk
        {
            
            set
                {
                    this.renk = value;
                }
            get
                {
                    return renk;
                }
        }

        
        public int X
        {
           
            set
            {
                this.x = value;
            }
            get
            {
                return x;
            }
        }


        public int Y
        {
           
            set
                {
                    this.y = value;
                }
            get
                {
                    return y;
                }
        }

       
        public int Yukseklik
        {
           
            set
                {
                    this.yukseklik = value;
                }
            get
                {
                    return yukseklik;
                }
        }
    }


}
