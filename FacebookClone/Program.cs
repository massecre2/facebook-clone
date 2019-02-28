using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
//Design Pattern(tasarım desenleri) , Composite(Bileşik desene bak)
//wpf  , xaml

namespace _22.Facebook.Clone
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Kullanici a_profile = new Kullanici("helloworld@gmail.com", "aguaguagu");
            a_profile.iletisim._sehir = "Gümüşhane";
            a_profile.iletisim._webAdresi = "www.google.com";
            a_profile._adi = "Oğuzhan";
            a_profile._kayitYili = 2016;

            a_profile.egitimler.Add(new Egitim("Atatürk ilköğretim Okulu") 
                                    { 
                                      derece = Derece.ilkogretim , 
                                      _baslamaYili = 2000        , 
                                      _bitirmeYili = 2008        ,
                                      _mezunDurumu = true
                                    });

            a_profile.egitimler.Add(new Egitim("Cumhuriyet lisesli")
                                    { 
                                      derece = Derece.lise       , 
                                      _baslamaYili = 2008        , 
                                      _bitirmeYili = 2012        ,
                                      _mezunDurumu = true
                                    });

            a_profile.isyerleri.Add(new IsYeri("TTT Limited Şirketi")
                                    {
                                        _baslamaYili = 2013,
                                        _pozisyon = "MdrYardmc",
                                    });

            a_profile.isyerleri.Add(new IsYeri("TTT Limited Şirketi")
                                    {
                                        _baslamaYili = 2014,
                                        _pozisyon = "Müdür",
                                    });

            Kullanici b_profile = new Kullanici("asdasd@gmail.com", "1231");
            b_profile._adi = "New User";

            a_profile.takipEttikleri.Add(b_profile);
            a_profile.takipEttikleri.Add(new Kullanici("asd", "432")
                                    {
                                        _adi = "Son Kullanici" ,
                                        _kayitYili = 2015       

                                    });

            a_profile.goster();

            */


            /*
            XMLProfiles c_profile = new XMLProfiles("ProfileXML.XML");
            c_profile.Yukle();
            c_profile.Goster();
            c_profile.Ekle(new Kullanici(" ", "")
                    {
                        _adi = "deneme",
                        _kayitYili = 1995,
                        _mailAdresi = "asda@gmail.com",
                        _parola = "asfasd"

                    });

            c_profile.Goster();
            */

            Baglanti A = Baglanti.NesneVer();

            if (A == null)
            {
                Console.WriteLine("Bağlantı kurulamadı..");
            }
            else
            {
                Console.WriteLine("Bağlantı kuruldu.");
            }
        }
    }
}
