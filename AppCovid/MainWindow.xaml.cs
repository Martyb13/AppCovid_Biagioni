using System;
using System.Collections.Generic;
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
using System.Xml.Linq;

namespace AppCovid
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

        private void Btn_VisualizzaDati_Click(object sender, RoutedEventArgs e)
        {
            string path = @"DatiCovid.xml";
            XDocument xmlDoc = XDocument.Load(path);
            XElement xmlroot = xmlDoc.Element("root");
            var xmlrow = xmlroot.Elements("row");
        }
    }
}
