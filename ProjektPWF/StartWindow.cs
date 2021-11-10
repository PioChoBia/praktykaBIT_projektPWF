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

            comboBoxDopiszVatStawka.DataSource = wyswietl.ComboBoxDopiszVat();
            comboBoxDopiszVatStawka.DisplayMember = "StawkaVat";
            comboBoxDopiszVatStawka.ValueMember = "Id";

            richTextBoxDopiszUwagi.Text = "";

            comboBoxDopiszDostarczanie.DataSource = wyswietl.Dostarczanie();
            comboBoxDopiszDostarczanie.DisplayMember = "Sposob";
            comboBoxDopiszDostarczanie.ValueMember = "Id";

            comboBoxDopiszKierownik.DataSource = wyswietl.ComboBoxDopiszKierownik();
            comboBoxDopiszKierownik.DisplayMember = "NazwiskoKierownika"; // jak wyświetlić imię i nazwisko ? "Imiekierownika+" "+"NazwiskoKierownika" nie idzie!!
            comboBoxDopiszKierownik.ValueMember = "Id";

            comboBoxDopiszNabywca.DataSource = wyswietl.ComboBoxDopiszNabywca();
            comboBoxDopiszNabywca.DisplayMember = "NazwaNabywcy"; 
            comboBoxDopiszNabywca.ValueMember = "Id";

            comboBoxDopiszPlatnosc.DataSource = wyswietl.ComboBoxDopiszPlatnosc();
            comboBoxDopiszPlatnosc.DisplayMember = "Rodzaj";
            comboBoxDopiszPlatnosc.ValueMember = "Id";

            comboBoxDopiszStatus.DataSource = wyswietl.ComboBoxDopiszStatus();
            comboBoxDopiszStatus.DisplayMember = "Status";
            comboBoxDopiszStatus.ValueMember = "Id";

            comboBoxDopiszTermin.DataSource = wyswietl.ComboBoxDopiszTermin();
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

            tabSprzedaz.IdVat = ( (VatViewModel)comboBoxDopiszVatStawka.SelectedItem ).Id;

            tabSprzedaz.Uwagi = richTextBoxDopiszUwagi.Text;

            tabSprzedaz.IdDostarczanie= ((DostarczanieViewModel)comboBoxDopiszDostarczanie.SelectedItem).Id;

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

        //------------------------------------------------------------
        //do przeniesienia do TabelePoboczne.
        // |
        // v

        private void buttonTabelePoboczne_Click(object sender, EventArgs e)
        {
            tabControlTabelePoboczne.Visible = true;
            groupBoxTabelePoboczneDostarczanieDopisz.Visible = false;
            groupBoxTabelePoboczneDostarczanieEdytuj.Visible = false;

            //TabelePoboczne tabelePoboczne = new TabelePoboczne();
            //tabelePoboczne.ListBox1();

            listBoxTabelePoboczneDostarczanie.DataSource= wyswietl.Dostarczanie();
            listBoxTabelePoboczneDostarczanie.DisplayMember = "Sposob";
            listBoxTabelePoboczneDostarczanie.ValueMember = "Id";
                  
        }



        private void buttonDostarczanieKasuj_Click(object sender, EventArgs e)
        {
            DostarczanieViewModel dostarczanieViewModel = (DostarczanieViewModel)listBoxTabelePoboczneDostarczanie.SelectedItem;
            if (MessageBox.Show("Skasować pole "+dostarczanieViewModel.Sposob+" ?", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabDostarczanie doSkasowania = dbContext.DostarczanieC.Where(a => (a.Id ==dostarczanieViewModel.Id)).First();
                    dbContext.DostarczanieC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePoboczneDostarczanie.DataSource= wyswietl.Dostarczanie();
                }
            }
        }

        private void buttonDostarczanieDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneDostarczanieDopisz.Visible = true;
        }

        private void buttonTabelePoboczneDostarczanieDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneDostarczanieDopisz.Text!="")
            {
               TabDostarczanie tabDostarczanie = new TabDostarczanie { Sposob = textBoxTabelePoboczneDostarczanieDopisz.Text };
               obsluga.WpiszTabDostarczanie(tabDostarczanie);
               listBoxTabelePoboczneDostarczanie.DataSource = wyswietl.Dostarczanie();
               groupBoxTabelePoboczneDostarczanieDopisz.Visible = false; 
            }
        }

        private void buttonTabelePoboczneDopiszPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneDostarczanieDopisz.Text = "";
            groupBoxTabelePoboczneDostarczanieDopisz.Visible = false;
        }

        private void buttonDostarczanieEdytuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneDostarczanieEdytuj.Visible = true;
            DostarczanieViewModel dostarczanieViewModel = (DostarczanieViewModel)listBoxTabelePoboczneDostarczanie.SelectedItem;
            textBoxTabelePoboczneDostarczanieEdytuj.Text = dostarczanieViewModel.Sposob;
        }

        private void buttonTabelePoboczneDostarczanieEdytujOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneDostarczanieEdytuj.Text != "")
            {
                DostarczanieViewModel dostarczanieViewModel = (DostarczanieViewModel)listBoxTabelePoboczneDostarczanie.SelectedItem;
                using (var dbContext = new ApplicationDbContext())
                {
                    TabDostarczanie doEdycji = dbContext.DostarczanieC.Where(a => (a.Id == dostarczanieViewModel.Id)).First();
                    doEdycji.Sposob = textBoxTabelePoboczneDostarczanieEdytuj.Text;
                    dbContext.SaveChanges();
                }
                listBoxTabelePoboczneDostarczanie.DataSource = wyswietl.Dostarczanie();
                groupBoxTabelePoboczneDostarczanieEdytuj.Visible = false;
            }
        }

        private void buttonTabelePoboczneDostarczanieEdytujPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneDostarczanieEdytuj.Text = "";
            groupBoxTabelePoboczneDostarczanieEdytuj.Visible = false;
        }
    }



}