using ProjektPWF.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ProjektPWF
{
    class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(): base("ApplicationDbContext")
        {

        }
               
        public DbSet<TabSprzedaz> tabSprzedazs { get; set; }

        public DbSet<TabNabywca> tabNabywcas { get; set; }

        public DbSet<TabKierownik> tabKierowniks { get; set; }

        public DbSet<TabDostarczanie> tabDostarczanies { get; set; }

        public DbSet<TabPlatnosc> tabPlatnoscs { get; set; }

        public DbSet<TabStatus> tabStatuses { get; set; }

        public DbSet<TabTermin> tabTermins { get; set; }

        public DbSet<TabVat> tabVats { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
