using System;
using System.Collections.Generic;
using System.Text;

namespace AppCovid
{
    public class DatiCovid
    {
        public DateTime Data { get; set; }
        public string Stato { get; set; }
        public int Sintomatici { get; set; }
        public int TerapiaIntensiva { get; set; }
        public int TotaleOspedalizzati { get; set; }
        public int IsolamentoDomiciliare { get; set; }
        public int TotalePositivi { get; set; }
        public int VariazionePositivi { get; set; }
        public int NuoviPositivi { get; set; }
        public int DimessiGuariti { get; set; }
        public int Deceduti { get; set; }
        public int TotaleCasi { get; set; }
        public int Tamponi { get; set; }
        public string NoteIt { get; set; }
        public string NoteEn { get; set; }

        public override string ToString()
        {
            return $"{Data} {Stato} {Sintomatici} {TerapiaIntensiva} {TotaleOspedalizzati} {IsolamentoDomiciliare} {TotalePositivi} {VariazionePositivi} {NuoviPositivi} {DimessiGuariti} {Deceduti} {TotaleCasi} {Tamponi} {NoteIt} {NoteEn}";
        }
    }
}
