using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _22.Facebook.Clone
{
    class Baglanti
    {
        private static Baglanti nesne;
        private Baglanti()
        {

        }

        public static Baglanti NesneVer()
        {
            if (nesne == null && File.Exists("ProfileXML.XML"))
            {
                nesne = new Baglanti();
            }

            return nesne ; 
        }
    }
}
