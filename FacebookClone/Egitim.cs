using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Facebook.Clone
{
    enum Derece
    {
        ilkogretim      ,
        lise            ,
        universite      ,
        yuksekLisans    , 
        doktora         
    }

    class Egitim
    {
        public      string       _okulAdi        ;

        //##############################################
        private     int          __baslamaYili   ;
        public int _baslamaYili
        {
            get
            {
                return __baslamaYili; 
            }
            set
            {
                __baslamaYili = value; 
                if (value < 1950) __baslamaYili = 1950;
                if (value > 2016) __baslamaYili = 2016; 

            }
        }

        //##############################################

        private     int         __bitirmeYili    ;
        public int _bitirmeYili
        {
            get
            {
                return __bitirmeYili;
            }
            set
            {
                __bitirmeYili = value; 
                if (value < 1950) __bitirmeYili = 1950;
                if (value > 2016) __bitirmeYili = 2016;

            }
        }
        //##############################################

        public      bool         _mezunDurumu    ;
        public      string       _aciklama       ;
        public      List<string> bolumler        ;//bu gösterim şekline generic tip denilir. 
        public      Derece       derece          ;

        public Egitim(string okulAdi_)
        {
            this._okulAdi = okulAdi_;
            bolumler = new List<string>();
        }

        public void bolumEkle(string bolumAdi_)
        {
            bolumler.Add(bolumAdi_);
        }

        public void goster()
        {
            Console.WriteLine("######################");
            Console.WriteLine("---Egitim Bilgileri---")             ;
            Console.WriteLine("Okul adi         : " +  _okulAdi )   ;
            Console.WriteLine("Başlama Yılı     : " + _baslamaYili) ;
            Console.WriteLine("Bitirme Yılı     : " + _bitirmeYili) ;
            Console.WriteLine("Mezuniyet Durumu : " + _mezunDurumu) ;
            Console.WriteLine("Açıklama         : " + _aciklama)    ;

            foreach (String eleman in bolumler)
            {
                Console.WriteLine("Bölüm adı        : " + eleman)   ;
            }

            Console.WriteLine("Derece           : " + derece)       ;
            Console.WriteLine("---Egitim Bilgileri---")             ;
            Console.WriteLine("######################")             ;

        }
    }
}
