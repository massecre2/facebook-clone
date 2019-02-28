using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Facebook.Clone
{
    //yeni kullanıcı tanımlarken de bunu yapacağız , varolan kullanıcılar için de bunu kullanacağız . 
    class Kullanici:Profile
    {
        public List<Egitim>    egitimler       ; //mesela kişi profilinde birden fazla eğitim listesi olabilir lisans , önlisans , yükseklisans vb gibi . Listte bütün elemanlar aynı tipte olması gerekiyor. 
        public List<IsYeri> isyerleri; //işyeri sınıfından hazırlanmış olan nesneleri tutacak(List<IsYeri>)
        public List<Profile> takipEttikleri; //Takip edilenler listesi profilden olusacak , bu profil hem sayfaları hem grupları hem de arkadasları kapsayacak.

        public Kullanici(string mailAdresi_, string parola_)
            :base(mailAdresi_ , parola_)
        {
            egitimler       = new List<Egitim>()    ;
            isyerleri       = new List<IsYeri>()    ;
            takipEttikleri  = new List<Profile>()   ;
        }


        public override void goster()
        {
            base.goster();
            foreach (Egitim item in egitimler)
            {
                item.goster();
            }

            foreach (IsYeri item in isyerleri)
            {
                item.goster();
            }

            foreach (Profile item in takipEttikleri)
            {
                item.goster();
            }
        }

    }
}
