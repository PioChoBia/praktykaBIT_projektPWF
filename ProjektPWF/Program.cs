using ProjektPWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPWF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartWindow());

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
        }
    }
}
