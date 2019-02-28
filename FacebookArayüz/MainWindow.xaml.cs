using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;


namespace FacebookArayüz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOku_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            StreamReader sr = new StreamReader("ProfileXML.xml");

            string okunan = sr.ReadToEnd();
            xmlDoc.LoadXml(okunan);

            Profile a = new Profile("", "");
            Profile b = new Profile("", "");
            Profile c = new Profile("", "");

            a._adi = "Ali Veli"; a.fromXML(xmlDoc);
            b._adi = "Ayfe Fatma"; b.fromXML(xmlDoc);
            c._adi = "Hasan Hüseyin"; c.fromXML(xmlDoc);

            List<Profile> profiller = new List<Profile>();
            profiller.Add(a);
            profiller.Add(b);
            profiller.Add(c);

            lvProfiller.ItemsSource = profiller; 


        }

        private void btnPanel_Click(object sender, RoutedEventArgs e)
        {
            wb2.Navigate("http://www.facebook.com");
        }



        private void lvProfiller_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            btnOku.Content = (lvProfiller.SelectedItem as Profile)._adi + " arkadaşları ";
            Uri nn = new Uri((lvProfiller.SelectedItem as Profile)._resim, UriKind.Absolute);
            resim.Source = new BitmapImage(nn);

        }
    }
}
