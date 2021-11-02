﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPWF.Models
{
    class SprzedazViewModel
    {
        public int IdSprzedaz { get; set; }
        public DateTime DataSprzedazy { get; set; }
        public DateTime DataWystawienia { get; set; }
        public int NrZlecenia { get; set; }
        public int NrUmowy { get; set; }
        public string Tresc { get; set; }
        public double Netto { get; set; }
        public string VatStawka { get; set;}
        public string Uwagi { get; set; }
        public string DostarczanieSposob { get; set; }
        public string KierownikImieNazwisko { get; set; }
        public string NabywcaNazwa { get; set; }
        public string NabywcaAdres { get; set; }
        public string NabywcaNip { get; set; }
        public string PlatnoscRodzaj { get; set; }
        public string StatusStatus { get; set; }
        public int TerminTermin { get; set; }



        /*
        public int IdSprzedaz { get; set; }
        public DateTime DataSprzedazy { get; set; }
        public DateTime DataWystawienia { get; set; }
        public int NrZlecenia { get; set; }
        public int NrUmowy { get; set; }
        public string Tresc { get; set; }
        public double Netto { get; set; }
        public string Uwagi { get; set; }
        public int IdDostarczanie { get; set; }
        public DostarczanieViewModel Dostarczanie { get; set; }
        public int IdKierownik { get; set; }
        public KierownikViewModel Kierownik { get; set; }
        public int IdNabywca { get; set; }
        public NabywcaViewModel Nabywca { get; set; }
        public int IdPlatnosc { get; set; }
        public PlatnoscViewModel Platnosc { get; set; }
        public int IdStatus { get; set; }
        public StatusViewModel Status { get; set; }
        public int IdTermin { get; set; }
        public TerminViewModel Termin { get; set; }
        public int IdVat { get; set; }
        public VatViewModel Vat { get; set; }
        */
    }
}