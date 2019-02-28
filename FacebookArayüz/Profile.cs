using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FacebookArayüz 
{
    //bu sınıftan nesneler türetilmesin istiyorum , temel sınıf olacak. Başka sınıflar bunlardan türemeyecek . 
    class Profile : IXMLIslemleri
    {
        public      string   _mailAdresi    {set; get;}    //sadece profil sınıfından türemiş olan sınıflar kullanacak . Bunun dısında ki sınıflar bunu kullanamayacak demektir protected. 
        public      string   _parola        {set; get;}     
        public      string   _adi           {set; get;}    //herkes tarafından gözüktüğü için isim soy isim public yapacağız.
        public      string   _yasadigiYer   {set; get;}   
        public      int      _kayitYili     {set; get;}   
        public      Iletisim iletisim       {set; get;}    //Bütün iletişim bilgilerini iletişim sınıfından aldık . 
        public      string    _resim        {get; set;}

        public      Profile(string mailAdresi_ , string parola_)
        {
            this._mailAdresi        = mailAdresi_   ;
            this._parola            = parola_       ;
            iletisim                = new Iletisim(); //sınıf içerisin de örnekledik en başta örnekleseydik boş yere yer kaplayacaktı . 
        }

        public virtual void goster()//virtual alt tarafta ezmeyebilirim demektir. 
        {
            Console.WriteLine("Adı         : " + _adi)          ;
            Console.WriteLine("Kayıt Yılı  : " + _kayitYili)    ;
            iletisim.goster();
        }

        public void fromXML(XmlDocument xmlDoc)
        {
            XmlNodeList nodes = xmlDoc.SelectNodes("//Profil");

            foreach (XmlNode item in nodes)
            {
                if (item["Adi"].InnerText == _adi)
                {
                    _parola = item["Parola"].InnerText;
                    _kayitYili = Convert.ToInt32(item["KayitYili"].InnerText);
                    _resim = item["resim"].InnerText;
                }
            }
        }
    }

    //classın başına public koyarsan başka namespace'lerde de bunu kullanabilirsin demektir
}
