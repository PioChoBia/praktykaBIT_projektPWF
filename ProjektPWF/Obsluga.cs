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

    }
}