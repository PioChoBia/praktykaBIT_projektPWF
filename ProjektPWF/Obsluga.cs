using System;
using System.ComponentModel.DataAnnotations;
using ProjektPWF.Models;

namespace ProjektPWF
{
    public class Obsluga
    {
        public void WpiszTabDostarczanie(TabDostarczanie t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.DostarczanieC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void WpiszTabKierownik(TabKierownik t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.KierownikC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void WpiszTabNabywca(TabNabywca t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.NabywcaC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void WpiszTabPlatnosc(TabPlatnosc t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.PlatnoscC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void WpiszTabSprzedaz(TabSprzedaz t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.SprzedazC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void WpiszTabStatus(TabStatus t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.StatusC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void WpiszTabTermin(TabTermin t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.TerminC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void WpiszTabVat(TabVat t)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.VatC.Add(t);
                dbContext.SaveChanges();
            }
        }


        //dane startowe do tabel
        public void WpiszStartoweDoTabel()
        {
            //tabela DostarczanieC
            TabDostarczanie dostarczanie1 = new TabDostarczanie { Sposob = "list polecony" };
            WpiszTabDostarczanie(dostarczanie1);
            TabDostarczanie dostarczanie2 = new TabDostarczanie { Sposob = "osobiście" };
            WpiszTabDostarczanie(dostarczanie2);
            TabDostarczanie dostarczanie3 = new TabDostarczanie { Sposob = "e-mail" };
            WpiszTabDostarczanie(dostarczanie3);
            TabDostarczanie dostarczanie4 = new TabDostarczanie { Sposob = "kurier" };
            WpiszTabDostarczanie(dostarczanie4);


            //tabela KierownikC
            TabKierownik kierownik1 = new TabKierownik { ImieKierownika = "Jan", NazwiskoKierownika = "Kowalski" };
            WpiszTabKierownik(kierownik1);
            TabKierownik kierownik2 = new TabKierownik { ImieKierownika = "Robert", NazwiskoKierownika = "Mały" };
            WpiszTabKierownik(kierownik2);
            TabKierownik kierownik3 = new TabKierownik { ImieKierownika = "Mikołaj", NazwiskoKierownika = "Prezentowy" };
            WpiszTabKierownik(kierownik3);


            //tabela NabywcaC
            TabNabywca nabywca1 = new TabNabywca { NazwaNabywcy = "Słoneczny Wschód", AdresNabywcy = "Soso ul Wschodnia 3", NIP = "1123456789" };
            WpiszTabNabywca(nabywca1);
            TabNabywca nabywca2 = new TabNabywca { NazwaNabywcy = "Słoneczne Południe", AdresNabywcy = "Wrocław ul Południowa 13", NIP = "2123456789" };
            WpiszTabNabywca(nabywca2);
            TabNabywca nabywca3 = new TabNabywca { NazwaNabywcy = "Słoneczny Zachód", AdresNabywcy = "Gdynia ul Zachodnia 113", NIP = "3123456789" };
            WpiszTabNabywca(nabywca3);


            //tabela PlatnoscC
            TabPlatnosc platnosc1 = new TabPlatnosc { Rodzaj = "przelew" };
            WpiszTabPlatnosc(platnosc1);
            TabPlatnosc platnosc2 = new TabPlatnosc { Rodzaj = "za pobraniem" };
            WpiszTabPlatnosc(platnosc2);


            //tabela StatusC
            TabStatus status1 = new TabStatus { Status = "nowa" };
            WpiszTabStatus(status1);
            TabStatus status2 = new TabStatus { Status = "anulowana" };
            WpiszTabStatus(status2);
            TabStatus status3 = new TabStatus { Status = "częściow wystawiona ( cykliczna ) " };
            WpiszTabStatus(status3);
            TabStatus status4 = new TabStatus { Status = "wystawiona" };
            WpiszTabStatus(status4);


            //tabela TerminC
            TabTermin termin1 = new TabTermin { Termin = 7 };
            WpiszTabTermin(termin1);
            TabTermin termin2 = new TabTermin { Termin = 14 };
            WpiszTabTermin(termin2);
            TabTermin termin3 = new TabTermin { Termin = 21 };
            WpiszTabTermin(termin3);
            TabTermin termin4 = new TabTermin { Termin = 30 };
            WpiszTabTermin(termin4);


            //tabela VatC
            TabVat vat1 = new TabVat { Stawka = "00" };
            WpiszTabVat(vat1);
            TabVat vat2 = new TabVat { Stawka = "ZW" };
            WpiszTabVat(vat2);
            TabVat vat3 = new TabVat { Stawka = "5 %" };
            WpiszTabVat(vat3);
            TabVat vat4 = new TabVat { Stawka = "8 %" };
            WpiszTabVat(vat4);
            TabVat vat5 = new TabVat { Stawka = "23 %" };
            WpiszTabVat(vat5);


            WpiszTabSprzedaz(new TabSprzedaz
            {
                DataSprzedazy = System.DateTime.Today,
                DataWystawienia = DateTime.Today,
                NrZlecenia = 1,
                NrUmowy = 1,
                Tresc = "to jest treść1",
                Netto = 123.12,
                Uwagi = "to są uwagi1",
                IdDostarczanie = dostarczanie1.Id,
                IdKierownik = kierownik1.Id,
                IdNabywca = nabywca1.Id,
                IdPlatnosc = platnosc1.Id,
                IdStatus = status1.Id,
                IdTermin = termin1.Id,
                IdVat = vat1.Id
            }); 

            WpiszTabSprzedaz(new TabSprzedaz
            {
                DataSprzedazy = DateTime.Today,
                DataWystawienia = DateTime.Today,
                NrZlecenia = 2,
                NrUmowy = 2,
                Tresc = "to jest treść2",
                Netto = 223.12,
                Uwagi = "to są uwagi2",
                IdDostarczanie = dostarczanie2.Id,
                IdKierownik = kierownik2.Id,
                IdNabywca = nabywca2.Id,
                IdPlatnosc = platnosc2.Id,
                IdStatus = status2.Id,
                IdTermin = termin2.Id,
                IdVat = vat2.Id
            });
        }




    }
}