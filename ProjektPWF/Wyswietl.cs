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
                        VatStawka = s.Vat.Stawka,
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




    }
}
