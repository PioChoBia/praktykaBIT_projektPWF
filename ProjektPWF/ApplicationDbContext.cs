using ProjektPWF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ProjektPWF
{
    class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(): base("ApplicationDbContext")
        {

        }
        
        public DbSet<TabSprzedaz> Sprzedaz { get; set; }
        public DbSet<TabDostarczanie> Dostarczanie { get; set; }
        public DbSet<TabKierownik> Kierownik { get; set; }
        public DbSet<TabNabywca> Nabywca { get; set; }
        public DbSet<TabPlatnosc> Platnosc { get; set; }
        public DbSet<TabStatus> Status { get; set; }
        public DbSet<TabTermin> Termin { get; set; }
        public DbSet<TabVat> Vat { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
