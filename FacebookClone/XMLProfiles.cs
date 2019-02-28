using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace _22.Facebook.Clone
{
    class XMLProfiles
    {
        XmlDocument xmlDoc;
        StreamReader sr;
        string _fileName;
        List<Kullanici> profiller; 
        
        public XMLProfiles(string fileName_)
        {
            this._fileName = fileName_;
            profiller = new List<Kullanici>();
            xmlDoc = new XmlDocument();
            sr = new StreamReader(fileName_);
        }

        public void Yukle()
        {
            string okunan = sr.ReadToEnd(); //Bu dosyayı sonuna kadar oku ve bütün verileri okunan değerin içine ata
            xmlDoc.LoadXml(okunan); //xmlDoc isminde bi dökümanımız var . Stringi al xml mantığına göre parçala

            XmlNodeList nodes = xmlDoc.GetElementsByTagName("Profil"); //bütün profil nodlarını , nodes'lar içerisinde bi nodda tutt. 


            //bu nodes ' ler içinde ki her bir elemanı 
            foreach (XmlNode item in nodes)
            {
                Kullanici p = new Kullanici("" , "");
                p._adi = item["Adi"].InnerText;
                p._parola = item["Parola"].InnerText; 
                p._kayitYili = Convert.ToInt32(item["KayitYili"].InnerText);
                p._mailAdresi = item["MailAdresi"].InnerText;
                profiller.Add(p);
            }
        }

        public void Goster()
        {
            Console.WriteLine("--#######--KULLANICI LİSTESİ--#######--");
            foreach (Kullanici item in profiller)
            {
                Console.WriteLine("Adi          :"+item._adi);
                Console.WriteLine("Mail Adresi  :"+item._mailAdresi);
            }

        }

        public void Ekle(Kullanici kullanici_)
        {
            XmlNode root = xmlDoc.DocumentElement;
            XmlElement eleman = xmlDoc.CreateElement("Profil");
            XmlElement altEleman = xmlDoc.CreateElement("Adi");
            altEleman.InnerText = kullanici_._adi;
            eleman.AppendChild(altEleman);


            altEleman = xmlDoc.CreateElement("Parola");
            altEleman.InnerText = kullanici_._parola;
            eleman.AppendChild(altEleman);

            altEleman = xmlDoc.CreateElement("KayitYili");
            altEleman.InnerText = kullanici_._kayitYili.ToString();
            eleman.AppendChild(altEleman);

            altEleman = xmlDoc.CreateElement("MailAdresi");
            altEleman.InnerText = kullanici_._mailAdresi;
            eleman.AppendChild(altEleman);

            root.AppendChild(eleman);

            xmlDoc.Save("deneme.XML");
        }

    }
}
