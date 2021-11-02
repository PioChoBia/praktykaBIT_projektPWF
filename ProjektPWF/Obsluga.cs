using System;
using System.ComponentModel.DataAnnotations;
using ProjektPWF.Models;

namespace ProjektPWF
{
    public class Obsluga
    {
        public void  WpiszTabDostarczanie(TabDostarczanie t)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.DostarczanieC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void  WpiszTabKierownik(TabKierownik t)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.KierownikC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void  WpiszTabNabywca(TabNabywca t)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.NabywcaC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void  WpiszTabPlatnosc(TabPlatnosc t)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.PlatnoscC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void  WpiszTabSprzedaz(TabSprzedaz t)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.SprzedazC.Add(t);
                dbContext.SaveChanges();
            }
        }  
     

        public void  WpiszTabStatus(TabStatus t)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.StatusC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void  WpiszTabTermin(TabTermin t)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.TerminC.Add(t);
                dbContext.SaveChanges();
            }
        }


        public void  WpiszTabVat(TabVat t)
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
            Obsluga obsluga = new Obsluga();

            //tabela DostarczanieC
            obsluga.WpiszTabDostarczanie(new TabDostarczanie { Sposob = "list polecony" });
            obsluga.WpiszTabDostarczanie(new TabDostarczanie { Sposob = "e-mail" });
            obsluga.WpiszTabDostarczanie(new TabDostarczanie { Sposob = "osobiście" });
            obsluga.WpiszTabDostarczanie(new TabDostarczanie { Sposob = "kurier" });


            //tabela KierownikC
            obsluga.WpiszTabKierownik(new TabKierownik { ImieKierownika = "Jan", NazwiskoKierownika = "Kowalski" });
            obsluga.WpiszTabKierownik(new TabKierownik { ImieKierownika = "Adam", NazwiskoKierownika = "Nowak" });
            obsluga.WpiszTabKierownik(new TabKierownik { ImieKierownika = "Michał", NazwiskoKierownika = "Mały" });


            //tabela NabywcaC
            obsluga.WpiszTabNabywca(new TabNabywca { NazwaNabywcy = "Słoneczny Wschód", AdresNabywcy = "Soso ul Wschodnia 3", NIP = "1123456789" });
            obsluga.WpiszTabNabywca(new TabNabywca { NazwaNabywcy = "Słoneczne Południe", AdresNabywcy = "Wrocław ul Południowa 13", NIP = "2123456789" });
            obsluga.WpiszTabNabywca(new TabNabywca { NazwaNabywcy = "Słoneczny Zachód", AdresNabywcy = "Gdynia ul Zachodnia 113", NIP = "3123456789" });


            //tabela PlatnoscC
            obsluga.WpiszTabPlatnosc(new TabPlatnosc { Rodzaj = "przelew" });
            obsluga.WpiszTabPlatnosc(new TabPlatnosc { Rodzaj = "za pobraniem" });


            //tabela StatusC
            obsluga.WpiszTabStatus(new TabStatus { Status = "nowa" });
            obsluga.WpiszTabStatus(new TabStatus { Status = "anulowana" });
            obsluga.WpiszTabStatus(new TabStatus { Status = "częściowo wystawiona ( cykliczna )" });
            obsluga.WpiszTabStatus(new TabStatus { Status = "wystawiona" });


            //tabela TerminC
            obsluga.WpiszTabTermin(new TabTermin { Termin = 7 });
            obsluga.WpiszTabTermin(new TabTermin { Termin = 14 });
            obsluga.WpiszTabTermin(new TabTermin { Termin = 21 });
            obsluga.WpiszTabTermin(new TabTermin { Termin = 30 });


            //tabela VatC
            obsluga.WpiszTabVat(new TabVat { Stawka = "00" });
            obsluga.WpiszTabVat(new TabVat { Stawka = "ZW" });
            obsluga.WpiszTabVat(new TabVat { Stawka = "5 %" });
            obsluga.WpiszTabVat(new TabVat { Stawka = "8 %" });
            obsluga.WpiszTabVat(new TabVat { Stawka = "23 %" });


            obsluga.WpiszTabSprzedaz(new TabSprzedaz
            {
                DataSprzedazy = System.DateTime.Today,
                DataWystawienia = DateTime.Today,
                NrZlecenia = 1,
                NrUmowy = 1,
                Tresc = "to jest treść1",
                Netto = 123.12,
                Uwagi = "to są uwagi1",

                IdDostarczanie = 1,
                IdKierownik = 1,
                IdNabywca = 1,
                IdPlatnosc = 1,
                IdStatus = 1,
                IdTermin = 1,
                IdVat = 1
            }); ;

            obsluga.WpiszTabSprzedaz(new TabSprzedaz
            {
                DataSprzedazy = DateTime.Today,
                DataWystawienia = DateTime.Today,
                NrZlecenia = 2,
                NrUmowy = 2,
                Tresc = "to jest treść2",
                Netto = 223.12,
                Uwagi = "to są uwagi2",

                IdDostarczanie = 2,
                IdKierownik = 2,
                IdNabywca = 2,
                IdPlatnosc = 2,
                IdStatus = 2,
                IdTermin = 2,
                IdVat = 2
            });



        }














    }
}