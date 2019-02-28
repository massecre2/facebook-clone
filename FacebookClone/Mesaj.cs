using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22.Facebook.Clone
{

    class Mesaj : IEtiket
    {
        public      string          _text       ;
        public Mesaj(string aciklama_) : base()
        {
            this._text = aciklama_              ; 
        }
    }
}
