using ProjektPWF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ProjektPWF
{
   public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(): base("ApplicationDbContext")
        {
        }
 
        public DbSet<TabSprzedaz> SprzedazC { get; set; }
        public DbSet<TabDostarczanie> DostarczanieC { get; set; }
        public DbSet<TabKierownik> KierownikC { get; set; }
        public DbSet<TabNabywca> NabywcaC { get; set; }
        public DbSet<TabPlatnosc> PlatnoscC { get; set; }
        public DbSet<TabStatus> StatusC { get; set; }
        public DbSet<TabTermin> TerminC { get; set; }
        public DbSet<TabVat> VatC { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
