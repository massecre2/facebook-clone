using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22.Facebook.Clone
{
    abstract class IEtiket
    {
            public      List<Profile> _etiketler   ;
            public void etiket_Ekle(Profile profil_)
            {
                _etiketler.Add(profil_)             ;
            }

            public IEtiket()
            {
                _etiketler = new List<Profile>()    ;
            }

    }
}
