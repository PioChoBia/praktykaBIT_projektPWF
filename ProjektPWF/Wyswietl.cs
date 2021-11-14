using ProjektPWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPWF
{
    class Wyswietl
    {

        public List<SprzedazViewModel> BezFiltru()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                //dbContext.SprzedazC.Add(new TabSprzedaz { NrUmowy = 1 });
              
                var dane = dbContext.SprzedazC.AsNoTracking().
                    Select(s => new SprzedazViewModel
                    {
                        IdSprzedaz = s.IdSprzedaz,
                        DataSprzedazy = s.DataSprzedazy,
                        DataWystawienia = s.DataWystawienia,
                        NrZlecenia = s.NrZlecenia,
                        NrUmowy = s.NrUmowy,
                        Tresc = s.Tresc,
                        Netto = s.Netto,
                        VatStawka = s.Vat.StawkaVat,
                        Uwagi = s.Uwagi,
                        DostarczanieSposob = s.Dostarczanie.Sposob,
                        KierownikImieNazwisko = s.Kierownik.ImieKierownika + " " +
                            s.Kierownik.NazwiskoKierownika,
                        NabywcaNazwa = s.Nabywca.NazwaNabywcy,
                        NabywcaAdres = s.Nabywca.AdresNabywcy,
                        NabywcaNip = s.Nabywca.NIP,
                        PlatnoscRodzaj = s.Platnosc.Rodzaj,
                        StatusStatus = s.Status.Status,
                        TerminTermin = s.Termin.Termin
                    }).ToList();
                return dane;
            }
        }


        public List<VatViewModel> Vat()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                 var dane = dbContext.VatC.
                    Select(s => new VatViewModel
                    {
                        Id = s.Id,
                        StawkaVat = s.StawkaVat                       
                    }).ToList();
                return dane;
            }
        }

        public List<DostarczanieViewModel> Dostarczanie()
            //ComboBoxDopiszDostarczanie()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.DostarczanieC.
                   Select(s => new DostarczanieViewModel
                   {
                       Id = s.Id,
                       Sposob = s.Sposob
                   }).ToList();
                return dane;
            }
        }

        public List<KierownikViewModel> Kierownik()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.KierownikC.
                   Select(s => new KierownikViewModel
                   {
                       Id = s.Id,
                       NazwiskoKierownika = s.ImieKierownika+" "+ s.NazwiskoKierownika,
                       ImieKierownika=s.ImieKierownika
                   }).ToList();
                return dane;
            }
        }

        public List<NabywcaViewModel> Nabywca()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.NabywcaC.
                   Select(s => new NabywcaViewModel
                   {
                       Id = s.Id,
                       NazwaNabywcy = s.NazwaNabywcy,
                       AdresNabywcy = s.AdresNabywcy,
                       NIP=s.NIP
                   }).ToList();
                return dane;
            }
        }

        public List<PlatnoscViewModel> Platnosc()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.PlatnoscC.
                   Select(s => new PlatnoscViewModel
                   {
                       Id = s.Id,
                       Rodzaj = s.Rodzaj,
                   }).ToList();
                return dane;
            }
        }

        public List<StatusViewModel> Status()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.StatusC.
                   Select(s => new StatusViewModel
                   {
                       Id = s.Id,
                       Status = s.Status,
                   }).ToList();
                return dane;
            }
        }

        public List<TerminViewModel> Termin()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.TerminC.
                   Select(s => new TerminViewModel
                   {
                       Id = s.Id,
                       Termin = s.Termin,
                   }).ToList();
                return dane;
            }
        }


    }
}
