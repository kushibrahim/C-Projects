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
    public class SahnePaneli
    {
        
        private Dortgen aktifSekil;
        private Dortgen cizimAlani = new Dortgen();
        private int genislik;
        private int maksimumSekilSayisi;
        private Dortgen[] sekiller;
        private int sekilSayisi;
        private int x;
        private int y;
        private int yukseklik;

        
        public SahnePaneli(int genislik, int yukseklik)
        {
            this.cizimAlani.BoyutAta(genislik, yukseklik);
            this.maksimumSekilSayisi = 100;
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.sekiller = new Dortgen[this.maksimumSekilSayisi];
            this.sekilSayisi = 0;
        }

        public void AktifSekilAta(Dortgen yeniSekil)
        {
            //Eğer aktifSekil 100'den küçükse ve aktifSekil null degerine eşit değilse sekilSayısını bir arttırıyorum ve yeni sekli aktifsekile atıyorum. 
            if ((this.aktifSekil != null) && (this.sekilSayisi < 100))
            {
                this.sekiller[this.sekilSayisi] = this.aktifSekil;
                this.sekilSayisi++;
            }
            this.aktifSekil = yeniSekil;
        }

        public void Ciz()
        {
            this.cizimAlani.Ciz();
            if (this.aktifSekil != null)
                {
                    this.aktifSekil.Ciz();
                }
            //SekilSayısına kadar sekilleri ekrana yazdırıyorum.
            for (int i = 0; i < this.sekilSayisi; i++)
                {
                    this.sekiller[i].Ciz();
                }
        }

        public void KonumAta(int x, int y)
        {
            this.cizimAlani.KonumAta(x, y);
            this.x = x;
            this.y = y;
        }


        public void SekilAsagiOtele()
        {
            //Eğer aktifSekil'in Y değeri ve Genislik property'si (yukseklik-1)'den büyükse yukarı öteler.
            if ((this.aktifSekil.Yukseklik + this.aktifSekil.Y) < (this.yukseklik - 1))
            {
                this.aktifSekil.AsagiOtele();
                    if (this.SekillerCarpisiyormu())
                    {
                        this.aktifSekil.YukariOtele();
                    }
            }
        }

        public void SekilSagaOtele()
        {
            //Eğer aktifSekil'in x değeri ve Genislik property'si (genislik-1)'den büyükse yukarı öteler.
            if ((this.aktifSekil.Genislik + this.aktifSekil.X) < (this.genislik - 1))
            {
                this.aktifSekil.SagaOtele();
                    if (this.SekillerCarpisiyormu())
                        {
                            this.aktifSekil.SolaOtele();
                        }
            }
        }

        public void SekilSolaOtele()
        {
            //Eğer aktifSekil'in x değeri 1'den büyükse yukarı öteler.
            if (this.aktifSekil.X > 1)
            {
                this.aktifSekil.SolaOtele();
                //if'in içi true olursa sekillerin çarpıstıgını gösterir ve aktifSekil'i saga öteler.
                if (this.SekillerCarpisiyormu())
                        {
                            this.aktifSekil.SagaOtele();
                        }
            }
        }

        public void SekilYukariOtele()
        {
            //Eğer aktifSekil'in y değeri 1'den büyükse yukarı öteler.
            if (this.aktifSekil.Y > 1)
            {
                this.aktifSekil.YukariOtele();
                    //if'in içi true olursa sekillerin çarpıstıgını gösterir ve aktifSekil'i asagı öteler.
                    if (this.SekillerCarpisiyormu())
                        {
                            this.aktifSekil.AsagiOtele();
                        }
            }
        }

        public bool SekillerCarpisiyormu()
        {
            //Her yeni sekil eklendiğinde sekilsayısına kadar döndürüp bunların carpısıp carpısmadığına bakıyorum.
            for (int i = 0; i < this.sekilSayisi; i++)
            {
                if ((((this.aktifSekil.X < (this.sekiller[i].X + this.sekiller[i].Genislik))
                    && ((this.aktifSekil.X + this.aktifSekil.Genislik) > this.sekiller[i].X))
                    && (this.aktifSekil.Y < (this.sekiller[i].Y + this.sekiller[i].Yukseklik)))
                    && ((this.aktifSekil.Y + this.aktifSekil.Yukseklik) > this.sekiller[i].Y))
                {
                    return true;
                }
            }
            return false;
        }

    }


}
