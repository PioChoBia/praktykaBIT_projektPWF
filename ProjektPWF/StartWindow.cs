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
        private const string V = "ala";
        Obsluga obsluga = new Obsluga();
        Wyswietl wyswietl = new Wyswietl();

        public StartWindow()
        {
            InitializeComponent();

            //obsluga.WpiszStartoweDoTabel();

            dataGridView1.DataSource = wyswietl.BezFiltru();



        }

        private void StartWindow_Load(object sender, EventArgs e)
        {
            groupBoxDopisz.Visible = false;
        }


        private void buttonDopisz_Click(object sender, EventArgs e)
        {
            groupBoxDopisz.Visible = true;

            dateTimePickerDopiszDataSprzedazy.CustomFormat = "d MMMM yyyy";
            dateTimePickerDopiszDataSprzedazy.Format = DateTimePickerFormat.Custom;
            dateTimePickerDopiszDataWystawienia.CustomFormat = "d MMMM yyyy";
            dateTimePickerDopiszDataWystawienia.Format = DateTimePickerFormat.Custom;

            textBoxDopiszNrZlecenia.Text = "0";
            textBoxDopiszNrUmowy.Text = "0";
            richTextBoxDopiszTrescUmowy.Text = "wpisz treść umowy";



            //List<string> l1= new List<string>() { "Ala", "Bela", "Cela" };
            //comboBoxDopiszVatStawka.DataSource = l1;



            
            List<DoKontrolki> listTabVat;

            using (var dbContext = new ApplicationDbContext())
            {
                listTabVat = dbContext.VatC.AsNoTracking<TabVat>().Select(s => new DoKontrolki { NazwaPola = s.StawkaVat }).ToList();
                comboBoxDopiszVatStawka.DataSource = listTabVat;
            }
            //comboBoxDopiszVatStawka.DataSource = listTabVat;



                //AsNoTracking<Student>().ToList<Student>();

            //               dbContext.VatC.Add(t);
            //               dbContext.SaveChanges();





            /*
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
                        VatStawka = s.Vat.StawkaVat,
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
            */

            /*
                    public void WpiszTabVat(TabVat t)
            {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.VatC.Add(t);
                dbContext.SaveChanges();
            }
            }

            foreach (var item in collection)
            {

            }

            */





            //comboBoxDopiszVatStawka.DataSource = l1;            
            //wyswietl.DopiszComboBoxVat();


        }

        private void buttonDopiszZatwierdz_Click(object sender, EventArgs e)
        {
            TabSprzedaz tabSprzedaz = new TabSprzedaz();
            Obsluga obsluga1 = new Obsluga();

            tabSprzedaz.DataSprzedazy = dateTimePickerDopiszDataSprzedazy.Value;
            tabSprzedaz.DataWystawienia = dateTimePickerDopiszDataWystawienia.Value;

            tabSprzedaz.NrZlecenia = int.Parse(textBoxDopiszNrZlecenia.Text);
            tabSprzedaz.NrUmowy = int.Parse(textBoxDopiszNrUmowy.Text);

            //tabSprzedaz.Netto =
            //tabSprzedaz.Uwagi=

            //tabSprzedaz.IdVat=



            groupBoxDopisz.Visible = false;
        }

        private void textBoxDopiszNrZlecenia_TextChanged(object sender, EventArgs e)
        {
            int parseValue;
            if (!int.TryParse(textBoxDopiszNrZlecenia.Text, out parseValue))
            {
                textBoxDopiszNrZlecenia.Text = "0";
            }
        }

        private void textBoxDopiszNrUmowy_TextChanged(object sender, EventArgs e)
        {
            int parseValue;
            if (!int.TryParse(textBoxDopiszNrUmowy.Text, out parseValue))
            {
                textBoxDopiszNrUmowy.Text = "0";
            }
        }

        private void comboBoxDopiszVatStawka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}