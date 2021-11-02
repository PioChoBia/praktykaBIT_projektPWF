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







        public StartWindow()
        {
            InitializeComponent();
            Obsluga obsluga = new Obsluga();
            Wyswietl wyswietl = new Wyswietl();
                          
            //obsluga.WpiszStartoweDoTabel();
           
            


            //tabela SprzedazC
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
                this.dataGridView1.DataSource = dane;
            }


        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

        }
    }
}