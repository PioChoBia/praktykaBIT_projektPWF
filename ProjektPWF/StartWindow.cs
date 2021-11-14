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
            tabControlTabelePoboczne.Visible = false;
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
            richTextBoxDopiszTresc.Text = "";
            textBoxDopiszNetto.Text = "0";

            comboBoxDopiszVatStawka.DataSource = wyswietl.Vat();
            comboBoxDopiszVatStawka.DisplayMember = "StawkaVat";
            comboBoxDopiszVatStawka.ValueMember = "Id";

            richTextBoxDopiszUwagi.Text = "";

            comboBoxDopiszDostarczanie.DataSource = wyswietl.Dostarczanie();
            comboBoxDopiszDostarczanie.DisplayMember = "Sposob";
            comboBoxDopiszDostarczanie.ValueMember = "Id";

            comboBoxDopiszKierownik.DataSource = wyswietl.Kierownik();
            comboBoxDopiszKierownik.DisplayMember = "NazwiskoKierownika";//wyświetli łacznie imię i nazwisko
            comboBoxDopiszKierownik.ValueMember = "Id";

            comboBoxDopiszNabywca.DataSource = wyswietl.Nabywca();
            comboBoxDopiszNabywca.DisplayMember = "NazwaNabywcy";
            comboBoxDopiszNabywca.ValueMember = "Id";

            comboBoxDopiszPlatnosc.DataSource = wyswietl.Platnosc();
            comboBoxDopiszPlatnosc.DisplayMember = "Rodzaj";
            comboBoxDopiszPlatnosc.ValueMember = "Id";

            comboBoxDopiszStatus.DataSource = wyswietl.Status();
            comboBoxDopiszStatus.DisplayMember = "Status";
            comboBoxDopiszStatus.ValueMember = "Id";

            comboBoxDopiszTermin.DataSource = wyswietl.Termin();
            comboBoxDopiszTermin.DisplayMember = "Termin";
            comboBoxDopiszTermin.ValueMember = "Id";
        }

        private void buttonDopiszZatwierdz_Click(object sender, EventArgs e)
        {
            TabSprzedaz tabSprzedaz = new TabSprzedaz();

            tabSprzedaz.DataSprzedazy = dateTimePickerDopiszDataSprzedazy.Value;
            tabSprzedaz.DataWystawienia = dateTimePickerDopiszDataWystawienia.Value;

            tabSprzedaz.NrZlecenia = int.Parse(textBoxDopiszNrZlecenia.Text);
            tabSprzedaz.NrUmowy = int.Parse(textBoxDopiszNrUmowy.Text);
            tabSprzedaz.Tresc = richTextBoxDopiszTresc.Text;

            tabSprzedaz.Netto = double.Parse(textBoxDopiszNetto.Text);

            tabSprzedaz.IdVat = ((VatViewModel)comboBoxDopiszVatStawka.SelectedItem).Id;

            tabSprzedaz.Uwagi = richTextBoxDopiszUwagi.Text;

            tabSprzedaz.IdDostarczanie = ((DostarczanieViewModel)comboBoxDopiszDostarczanie.SelectedItem).Id;

            tabSprzedaz.IdKierownik = ((KierownikViewModel)comboBoxDopiszKierownik.SelectedItem).Id;

            tabSprzedaz.IdNabywca = ((NabywcaViewModel)comboBoxDopiszNabywca.SelectedItem).Id;

            tabSprzedaz.IdPlatnosc = ((PlatnoscViewModel)comboBoxDopiszPlatnosc.SelectedItem).Id;

            tabSprzedaz.IdStatus = ((StatusViewModel)comboBoxDopiszStatus.SelectedItem).Id;

            tabSprzedaz.IdTermin = ((TerminViewModel)comboBoxDopiszTermin.SelectedItem).Id;

            obsluga.WpiszTabSprzedaz(tabSprzedaz);
            dataGridView1.DataSource = wyswietl.BezFiltru();

            groupBoxDopisz.Visible = false;
        }

        private void textBoxDopiszNrZlecenia_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDopiszNrZlecenia.Text, out _))
            {
                textBoxDopiszNrZlecenia.Text = "0";
            }
        }

        private void textBoxDopiszNrUmowy_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDopiszNrUmowy.Text, out _))
            {
                textBoxDopiszNrUmowy.Text = "0";
            }
        }

        private void textBoxDopiszNetto_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxDopiszNetto.Text, out _))
            {
                textBoxDopiszNetto.Text = "0";
            }
        }


        private void buttonTabelePoboczne_Click(object sender, EventArgs e)
        {
            tabControlTabelePoboczne.Visible = true;
            //Dostarczanie
            groupBoxTabelePoboczneDostarczanieDopisz.Visible = false;
            groupBoxTabelePoboczneDostarczanieEdytuj.Visible = false;
            listBoxTabelePoboczneDostarczanie.DataSource = wyswietl.Dostarczanie();
            listBoxTabelePoboczneDostarczanie.DisplayMember = "Sposob";
            listBoxTabelePoboczneDostarczanie.ValueMember = "Id";
            //Kierownik
            groupBoxTabelePoboczneKierownikDopisz.Visible = false;
            groupBoxTabelePoboczneKierownikEdytuj.Visible = false;
            listBoxTabelePoboczneKierownik.DataSource = wyswietl.Kierownik();
            listBoxTabelePoboczneKierownik.DisplayMember = "NazwiskoKierownika";//wyświetli łacznie imię i nazwisko
            listBoxTabelePoboczneKierownik.ValueMember = "Id";


            //Platnosc
            groupBoxTabelePobocznePlatnoscDopisz.Visible = false;
            groupBoxTabelePobocznePlatnoscEdytuj.Visible = false;
            listBoxTabelePobocznePlatnosc.DataSource = wyswietl.Platnosc();
            listBoxTabelePobocznePlatnosc.DisplayMember = "Rodzaj";
            listBoxTabelePobocznePlatnosc.ValueMember = "Id";
            //Status
            groupBoxTabelePoboczneStatusDopisz.Visible = false;
            groupBoxTabelePoboczneStatusEdytuj.Visible = false;
            listBoxTabelePoboczneStatus.DataSource = wyswietl.Status();
            listBoxTabelePoboczneStatus.DisplayMember = "Status";
            listBoxTabelePoboczneStatus.ValueMember = "Id";
            //Termin
            groupBoxTabelePoboczneTerminDopisz.Visible = false;
            groupBoxTabelePoboczneTerminEdytuj.Visible = false;
            listBoxTabelePoboczneTermin.DataSource = wyswietl.Termin();
            listBoxTabelePoboczneTermin.DisplayMember = "Termin";
            listBoxTabelePoboczneTermin.ValueMember = "Id";
            //Vat
            groupBoxTabelePoboczneVatDopisz.Visible = false;
            groupBoxTabelePoboczneVatEdytuj.Visible = false;
            listBoxTabelePoboczneVat.DataSource = wyswietl.Vat();
            listBoxTabelePoboczneVat.DisplayMember = "StawkaVat";
            listBoxTabelePoboczneVat.ValueMember = "Id";
        }



    }



}