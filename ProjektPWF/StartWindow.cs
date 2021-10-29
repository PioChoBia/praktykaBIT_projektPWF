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

        public void WpiszStartoweDoTabel()
        {     
            var obsluga = new Obsluga();
            obsluga.WpiszTabSprzedaz( new TabSprzedaz{ 
                DataSprzedazy=DateTime.Today, 
                DataWystawienia=DateTime.Today, 
                NrZlecenia=1,
                NrUmowy=1,
                Tresc="to jest treść1",
                Netto=123.12,
                Uwagi="to są uwagi1",

                IdDostarczanie=1,
                IdKierownik=1,
                IdNabywca=1,
                IdPlatnosc=1,
                IdStatus=1,
                IdTermin=1,
                IdVat=1
               } );;

            obsluga.WpiszTabSprzedaz( new TabSprzedaz{ 
                DataSprzedazy=DateTime.Today, 
                DataWystawienia=DateTime.Today, 
                NrZlecenia=2,
                NrUmowy=2,
                Tresc="to jest treść2",
                Netto=223.12,
                Uwagi="to są uwagi2",

                IdDostarczanie=2,
                IdKierownik=2,
                IdNabywca=2,
                IdPlatnosc=2,
                IdStatus=2,
                IdTermin=2,
                IdVat=2
               } );;


            //tabela DostarczanieC
            obsluga.WpiszTabDostarczanie( new TabDostarczanie{ Sposob="list polecony" } );
            obsluga.WpiszTabDostarczanie( new TabDostarczanie{ Sposob="e-mail" } );
            obsluga.WpiszTabDostarczanie( new TabDostarczanie{ Sposob="osobiście" } );
            obsluga.WpiszTabDostarczanie( new TabDostarczanie{ Sposob="kurier" } );

            
            //tabela KierownikC
            obsluga.WpiszTabKierownik( new TabKierownik{ ImieKierownika="Jan", NazwiskoKierownika="Kowalski" } );
            obsluga.WpiszTabKierownik( new TabKierownik{ ImieKierownika="Adam", NazwiskoKierownika="Nowak" } );
            obsluga.WpiszTabKierownik( new TabKierownik{ ImieKierownika="Michał", NazwiskoKierownika="Mały" } );

            
            //tabela NabywcaC
            obsluga.WpiszTabNabywca( new TabNabywca{ NazwaNabywcy="Słoneczny Wschód",  AdresNabywcy="Soso ul Wschodnia 3", NIP="1123456789" } );
            obsluga.WpiszTabNabywca( new TabNabywca{ NazwaNabywcy="Słoneczne Południe",  AdresNabywcy="Wrocław ul Południowa 13", NIP="2123456789" } );
            obsluga.WpiszTabNabywca( new TabNabywca{ NazwaNabywcy="Słoneczny Zachód",  AdresNabywcy="Gdynia ul Zachodnia 113", NIP="3123456789" } );

           
            //tabela PlatnoscC
            obsluga.WpiszTabPlatnosc( new TabPlatnosc{ Rodzaj="przelew" } );
            obsluga.WpiszTabPlatnosc( new TabPlatnosc{ Rodzaj="za pobraniem" } );

            
            //tabela StatusC
            obsluga.WpiszTabStatus(new TabStatus{ Status="nowa" } );
            obsluga.WpiszTabStatus(new TabStatus{ Status="anulowana" } );
            obsluga.WpiszTabStatus(new TabStatus{ Status="częściowo wystawiona ( cykliczna )" } );
            obsluga.WpiszTabStatus(new TabStatus{ Status="wystawiona" } );
           

            //tabela TerminC
            obsluga.WpiszTabTermin( new TabTermin{ Termin=7 } );
            obsluga.WpiszTabTermin( new TabTermin{ Termin=14 } );
            obsluga.WpiszTabTermin( new TabTermin{ Termin=21 } );
            obsluga.WpiszTabTermin( new TabTermin{ Termin=30 } );


            //tabela VatC
            obsluga.WpiszTabVat( new TabVat{ Stawka="00" } );
            obsluga.WpiszTabVat( new TabVat{ Stawka="ZW" } );
            obsluga.WpiszTabVat( new TabVat{ Stawka="5 %" } );
            obsluga.WpiszTabVat( new TabVat{ Stawka="8 %" } );
            obsluga.WpiszTabVat( new TabVat{ Stawka="23 %" } );            
        }






        public StartWindow()
        {
            InitializeComponent();
            // WpiszStartoweDoTabel();


            //tabela SprzedazC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.SprzedazC.AsNoTracking().
                    Select(s => new SprzedazModelView
                    {
                        IdSprzedaz=s.IdSprzedaz,
                        DataSprzedazy=s.DataSprzedazy,
                        DataWystawienia=s.DataWystawienia,
                        Netto=s.Netto,
                        NrZlecenia=s.NrZlecenia,
                        Tresc=s.Tresc,
                        Uwagi=s.Uwagi,
                        Dostarczanie=new DostarczanieViewModel
                        {
                            Id=s.Dostarczanie.Id,
                            Sposob=s.Dostarczanie.Sposob                            
                        },
                        Kierownik=new KierownikViewModel
                        {
                            Id=s.Kierownik.Id,
                            ImieKierownika=s.Kierownik.ImieKierownika,
                            NazwiskoKierownika=s.Kierownik.NazwiskoKierownika
                        },
                        Nabywca=new NabywcaViewModel
                        {
                            Id=s.Nabywca.Id,
                            NazwaNabywcy=s.Nabywca.NazwaNabywcy,
                            AdresNabywcy=s.Nabywca.AdresNabywcy,
                            NIP=s.Nabywca.NIP
                        },
                        Platnosc=new PlatnoscViewModel
                        {
                            Id=s.Platnosc.Id,
                            Rodzaj=s.Platnosc.Rodzaj
                        },
                        Status=new StatusViewModel
                        {
                            Id=s.Status.Id,
                            Status=s.Status.Status
                        },
                        Termin=new TerminViewModel
                        {
                            Id=s.Termin.Id,
                            Termin=s.Termin.Termin
                        },
                        Vat=new VatViewModel
                        {
                            Id=s.Vat.Id,
                            Stawka=s.Vat.Stawka
                        }
                        
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            }




            /*
            //tabela VatC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.VatC.AsNoTracking().
                    Select(s => new VatViewModel
                    {
                        Id = s.Id,
                        Stawka=s.Stawka
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            }            
            

            //tabela TerminC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.TerminC.AsNoTracking().
                    Select(s => new TerminViewModel
                    {
                        Id = s.Id,
                        Termin=s.Termin
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            }

            //tabela StatusC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.StatusC.AsNoTracking().
                    Select(s => new StatusViewModel
                    {
                        Id = s.Id,
                        Status=s.Status
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            }


            //tabela PlatnoscC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.PlatnoscC.AsNoTracking().
                    Select(s => new PlatnoscViewModel
                    {
                        Id = s.Id,
                        Rodzaj=s.Rodzaj
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            }
  
             
            //tabela NabywcaC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.NabywcaC.AsNoTracking().
                    Select(s => new NabywcaViewModel
                    {
                        Id = s.Id,
                        NazwaNabywcy=s.NazwaNabywcy,
                        AdresNabywcy=s.AdresNabywcy,
                        NIP=s.NIP
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            }             
             
            //tabela DostarczanieC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.DostarczanieC.AsNoTracking().
                    Select(s => new DostarczanieViewModel
                    {
                        Id = s.Id,
                        Sposob=s.Sposob
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            } 
             
            //tabela KierownikC
            using (var dbContext = new ApplicationDbContext())
            {
                var dane = dbContext.KierownikC.AsNoTracking().
                    Select(s => new KierownikViewModel
                    {
                        Id = s.Id,
                        ImieKierownika = s.ImieKierownika,
                        NazwiskoKierownika = s.NazwiskoKierownika
                    }).ToList();
                this.dataGridView1.DataSource = dane;
            }
            */



            /*
            var dane = new List<TabSprzedaz> { };        

            using (var dbContext = new ApplicationDbContext())
            {
                dane= dbContext.SprzedazC.ToList();               
             //   dane.Add( dbContext.SprzedazC.Where(t => t.IdSprzedaz == 1).First() );     
            }

            this.dataGridView1.DataSource = dane;
            */


        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

        }
    }
}