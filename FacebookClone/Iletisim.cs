using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Facebook.Clone
{
    class Iletisim
    {
        public      string      _sehir          ;
        public      string      _postaKodu      ;
        public      string      _tel            ;
        public      string      _adresi         ;
        public      string      _webAdresi      ;


        public void goster()
        {
            Console.WriteLine("########################");
            Console.WriteLine("---İletişim Bilgileri---");
            Console.WriteLine("Şehir        : " + _sehir)       ;
            Console.WriteLine("Posta kodu   : " + _postaKodu)   ;
            Console.WriteLine("Telefon NO   : " + _tel)         ;
            Console.WriteLine("Adresi       : " + _adresi)      ;
            Console.WriteLine("Web Adresi   : " + _webAdresi)   ;
            Console.WriteLine("########################");


        }
    }
}
