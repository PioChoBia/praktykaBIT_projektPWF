using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProjektPWF.Models;

namespace ProjektPWF
{
    public partial class StartWindow : Form
    {


        public static void TabDostarczanie()
        {
            var dostarczanieL = new List<TabDostarczanie>
            {
                new TabDostarczanie{Sposob="list polecony"},
                new TabDostarczanie{Sposob="e-mail"},
                new TabDostarczanie{Sposob="osobiście"},
                new TabDostarczanie{Sposob="kurier"}
            };        
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.DostarczanieC.AddRange(dostarczanieL);
                dbContext.SaveChanges();
            }
        }


        public static void StartoweTabKierownik()
        {
            var kierownikL = new List<TabKierownik>
            {
                new TabKierownik{ImieKierownika="Jan", NazwiskoKierownika="Kowalski"},
                new TabKierownik{ImieKierownika="Adam", NazwiskoKierownika="Nowak"},
                new TabKierownik{ImieKierownika="Michał", NazwiskoKierownika="Mały"},
            };        
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.KierownikC.AddRange(kierownikL);
                dbContext.SaveChanges();
            }
        }


        public static void StartoweTabNabywca()
        {
            var list = new List<TabNabywca>
            {
                new TabNabywca{ NazwaNabywcy="Słoneczny Wschód",  AdresNabywcy="Soso ul Wschodnia 3", NIP="1123456789"},
                new TabNabywca{ NazwaNabywcy="Słoneczne Południe",  AdresNabywcy="Wrocław ul Południowa 13", NIP="2123456789"},
                new TabNabywca{ NazwaNabywcy="Słoneczny Zachód",  AdresNabywcy="Gdynia ul Zachodnia 113", NIP="3123456789"},
            };        
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.NabywcaC.AddRange(list);
                dbContext.SaveChanges();
            }
        }


        public static void StartoweTabPlatnosc()
        {
            var list = new List<TabPlatnosc>
            {
                new TabPlatnosc{ Rodzaj="przelew"},
                new TabPlatnosc{ Rodzaj="za pobraniem"}
            };        
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.PlatnoscC.AddRange(list);
                dbContext.SaveChanges();
            }
        }


        public static void DopisTabStatus(TabStatus o1)
        {     
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.StatusC.Add(o1);
                dbContext.SaveChanges();
            }
        }






        public StartWindow()
        {
            InitializeComponent();

            //tworzenie przykladowych rekordów i zapis do tabel     
            //StartoweTabDostarczanie();
            //StartoweTabKierownik();
            //StartoweTabNabywca();
            //StartoweTabPlatnosc();
           // DopisTabStatus(new TabStatus { Status="nowa"});

            var xx = new TabVat();
           var obsluga= new Obsluga();
       



            /*
            using (var dbContext = new ApplicationDbContext())
            {

            }

            var sprzedaz = new List<TabSprzedaz>
            {

            };

            using(var context = new ApplicationDbContext())
            {
                context.tabSprzedazs.AddRange(sprzedaz);

                context.SaveChanges();
            }

            var dostarczanie = new List<TabDostarczanie>
            {

            };

            using (var context = new ApplicationDbContext())
            {
                context.tabDostarczanies.AddRange(dostarczanie);

                context.SaveChanges();
            }

            var kierownik = new List<TabKierownik>
            {

            };

            using (var context = new ApplicationDbContext())
            {
                context.tabKierowniks.AddRange(kierownik);

                context.SaveChanges();
            }

            var nabywca = new List<TabNabywca>
            {

            };

            using (var context = new ApplicationDbContext())
            {
                context.tabNabywcas.AddRange(nabywca);

                context.SaveChanges();
            }

            var platnosc = new List<TabPlatnosc>
            {

            };

            using (var context = new ApplicationDbContext())
            {
                context.tabPlatnoscs.AddRange(platnosc);

                context.SaveChanges();
            }

            var status = new List<TabStatus>
            {

            };

            using (var context = new ApplicationDbContext())
            {
                context.tabStatuses.AddRange(status);

                context.SaveChanges();
            }

            var termin = new List<TabTermin>
            {

            };

            using (var context = new ApplicationDbContext())
            {
                context.tabTermins.AddRange(termin);

                context.SaveChanges();
            }

            var vat = new List<TabVat>
            {

            };

            using (var context = new ApplicationDbContext())
            {
                context.tabVats.AddRange(vat);

                context.SaveChanges();
            }

            */
        }
    }
}