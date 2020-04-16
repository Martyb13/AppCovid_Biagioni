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
        List<DatiCovid> dati;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_VisualizzaDati_Click(object sender, RoutedEventArgs e)
        {
            dati = new List<DatiCovid>();
            string path = @"DatiCovid.xml";
            XDocument xmlDoc = XDocument.Load(path);
            XElement xmlroot = xmlDoc.Element("root");
            var xmlrow = xmlroot.Elements("row");
            foreach (var item in xmlrow)
            {
                XElement xmlData = item.Element("data");
                XElement xmlStato = item.Element("stato");
                XElement xmlSintomatici = item.Element("ricoverati_con_sintomi");
                XElement xmlTerapiaIntensiva = item.Element("terapia_intensiva");
                XElement xmlTotaleOspedalizzati = item.Element("totale_ospedalizzati");
                XElement xmlIsolamentoDomiciliare = item.Element("isolamento_domiciliare");
                XElement xmlTotalePositivi = item.Element("totale_positivi");
                XElement xmlVariazionePositivi = item.Element("variazione_totale_positivi");
                XElement xmlNuoviPositivi = item.Element("nuovi_positivi");
                XElement xmlDimessiGuariti = item.Element("dimessi_guariti");
                XElement xmlDeceduti = item.Element("deceduti");
                XElement xmlTotaleCasi = item.Element("totale_casi");
                XElement xmlTamponi = item.Element("tamponi");
                XElement xmlNoteIt = item.Element("note_it");
                XElement xmlNoteEn = item.Element("note_en");

                DatiCovid d = new DatiCovid();
                {
                    d.Data = Convert.ToDateTime(xmlData.Value);
                    d.Stato = xmlStato.Value;
                    d.Sintomatici = Convert.ToInt32(xmlSintomatici.Value);
                    d.TerapiaIntensiva = Convert.ToInt32(xmlTerapiaIntensiva.Value);
                    d.TotaleOspedalizzati = Convert.ToInt32(xmlTotaleOspedalizzati.Value);
                    d.IsolamentoDomiciliare = Convert.ToInt32(xmlIsolamentoDomiciliare.Value);
                    d.TotalePositivi = Convert.ToInt32(xmlTotalePositivi.Value);
                    d.VariazionePositivi = Convert.ToInt32(xmlVariazionePositivi.Value);
                    d.NuoviPositivi = Convert.ToInt32(xmlNuoviPositivi.Value);
                    d.DimessiGuariti = Convert.ToInt32(xmlDimessiGuariti.Value);
                    d.Deceduti = Convert.ToInt32(xmlDeceduti.Value);
                    d.TotaleCasi = Convert.ToInt32(xmlTotaleCasi.Value);
                    d.Tamponi = Convert.ToInt32(xmlTamponi.Value);
                    d.NoteIt = xmlNoteIt.Value;
                    d.NoteEn = xmlNoteEn.Value;
                    dati.Add(d);
                }

            }
        }
    }
}
