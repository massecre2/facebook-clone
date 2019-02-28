using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22.Facebook.Clone
{
    class IsYeri
    {
        public      string      _adi        ;
        public      string      _pozisyon   ;
        public      Iletisim    iletisim    ;
        public      string      _aciklama   ;
        public      int         _baslamaYili;
        public      int         _bitisYili  ;

        public IsYeri(string adi_)
        {
            this._adi = adi_;
            iletisim = new Iletisim(); 
        }

        public void goster()
        {
            Console.WriteLine("########################")           ;
            Console.WriteLine("---İş Yeri Bilgileri ---")           ;
            Console.WriteLine("Şirket adı       : " + _adi )        ;
            Console.WriteLine("Pozisyon         : " + _pozisyon)    ;
            //iletisim.goster(); //iletişim sınıfını gösterir
            Console.WriteLine("Açıklama         : " + _aciklama)    ;
            Console.WriteLine("Başlama Yılı     : " + _baslamaYili) ;
            Console.WriteLine("Bitiş Yılı       : " + _bitisYili)   ;
            Console.WriteLine("########################");
        } 
    }
}
