using ProjektPWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPWF
{
    public partial class StartWindow : Form
    {
        public void SprzedazEdytujWyczyscPola()
        {
            labelSprzedazEdytujId.Text = "Id ?";

            dateTimePickerSprzedazEdytujDataSprzedazy.CustomFormat = "d MMMM yyyy";
            dateTimePickerSprzedazEdytujDataSprzedazy.Format = DateTimePickerFormat.Custom;
            dateTimePickerSprzedazEdytujDataSprzedazy.Value = DateTime.Today;

            dateTimePickerSprzedazEdytujDataWystawienia.CustomFormat = "d MMMM yyyy";
            dateTimePickerSprzedazEdytujDataWystawienia.Format = DateTimePickerFormat.Custom;
            dateTimePickerSprzedazEdytujDataWystawienia.Value = DateTime.Today;

            textBoxSprzedazEdytujNrZlecenia.Text = "0";
            textBoxSprzedazEdytujNrUmowy.Text = "0";
            richTextBoxSprzedazEdytujTresc.Text = "";
            textBoxSprzedazEdytujNetto.Text = "0";

            comboBoxSprzedazEdytujVat.DataSource = wyswietl.Vat();
            comboBoxSprzedazEdytujVat.DisplayMember = "StawkaVat";
            comboBoxSprzedazEdytujVat.ValueMember = "Id";

            richTextBoxSprzedazEdytujUwagi.Text = "";

            comboBoxSprzedazEdytujDostarczenie.DataSource = wyswietl.Dostarczanie();
            comboBoxSprzedazEdytujDostarczenie.DisplayMember = "Sposob";
            comboBoxSprzedazEdytujDostarczenie.ValueMember = "Id";

            comboBoxSprzedazEdytujKierownik.DataSource = wyswietl.Kierownik();
            comboBoxSprzedazEdytujKierownik.DisplayMember = "NazwiskoKierownika";//wyświetli łacznie imię i nazwisko
            comboBoxSprzedazEdytujKierownik.ValueMember = "Id";

            comboBoxSprzedazEdytujNabywca.DataSource = wyswietl.Nabywca();
            comboBoxSprzedazEdytujNabywca.DisplayMember = "NazwaNabywcy";
            comboBoxSprzedazEdytujNabywca.ValueMember = "Id";

            comboBoxSprzedazEdytujPlatnosc.DataSource = wyswietl.Platnosc();
            comboBoxSprzedazEdytujPlatnosc.DisplayMember = "Rodzaj";
            comboBoxSprzedazEdytujPlatnosc.ValueMember = "Id";

            comboBoxSprzedazEdytujStatus.DataSource = wyswietl.Status();
            comboBoxSprzedazEdytujStatus.DisplayMember = "Status";
            comboBoxSprzedazEdytujStatus.ValueMember = "Id";

            comboBoxSprzedazEdytujTermin.DataSource = wyswietl.Termin();
            comboBoxSprzedazEdytujTermin.DisplayMember = "Termin";
            comboBoxSprzedazEdytujTermin.ValueMember = "Id";
        }


        private void SprzedazEdytujWpiszWartosciSelectedIteam()
        {
           
            int selectedId = (int)dataGridViewSprzedaz.CurrentRow.Cells[0].Value;                               
            using (var dbContext = new ApplicationDbContext())
            {
                TabSprzedaz doEdycji = dbContext.SprzedazC.Where(a => (
                a.IdSprzedaz == selectedId)).First();

                labelSprzedazEdytujId.Text = "Id " + selectedId.ToString();

                DateTimePicker d = new DateTimePicker();
                
                dateTimePickerSprzedazEdytujDataSprzedazy.CustomFormat= "d MMMM yyyy";
                dateTimePickerSprzedazEdytujDataSprzedazy.Format = DateTimePickerFormat.Custom;
                dateTimePickerSprzedazEdytujDataSprzedazy.Value= doEdycji.DataSprzedazy;

                dateTimePickerSprzedazEdytujDataWystawienia.CustomFormat= "d MMMM yyyy";
                dateTimePickerSprzedazEdytujDataWystawienia.Format = DateTimePickerFormat.Custom;
                dateTimePickerSprzedazEdytujDataWystawienia.Value = doEdycji.DataWystawienia;

                textBoxSprzedazEdytujNrZlecenia.Text = doEdycji.NrZlecenia.ToString();
                textBoxSprzedazEdytujNrUmowy.Text = doEdycji.NrUmowy.ToString();
                richTextBoxSprzedazEdytujTresc.Text = doEdycji.Tresc;
                textBoxSprzedazEdytujNetto.Text = doEdycji.Netto.ToString();

                comboBoxSprzedazEdytujVat.DataSource = wyswietl.Vat();
                comboBoxSprzedazEdytujVat.DisplayMember = "StawkaVat";
                comboBoxSprzedazEdytujVat.ValueMember = "Id";
                comboBoxSprzedazEdytujVat.SelectedValue= doEdycji.IdVat;

                richTextBoxSprzedazEdytujUwagi.Text = doEdycji.Uwagi;

                comboBoxSprzedazEdytujDostarczenie.DataSource = wyswietl.Dostarczanie();
                comboBoxSprzedazEdytujDostarczenie.DisplayMember = "Sposob";
                comboBoxSprzedazEdytujDostarczenie.ValueMember = "Id";
                comboBoxSprzedazEdytujDostarczenie.SelectedValue = doEdycji.IdDostarczanie;

                comboBoxSprzedazEdytujKierownik.DataSource = wyswietl.Kierownik();
                comboBoxSprzedazEdytujKierownik.DisplayMember = "NazwiskoKierownika";
                comboBoxSprzedazEdytujKierownik.ValueMember = "Id";
                comboBoxSprzedazEdytujKierownik.SelectedValue = doEdycji.IdKierownik;

                comboBoxSprzedazEdytujNabywca.DataSource = wyswietl.Nabywca();
                comboBoxSprzedazEdytujNabywca.DisplayMember = "NazwaNabywcy";
                comboBoxSprzedazEdytujNabywca.ValueMember = "Id";
                comboBoxSprzedazEdytujNabywca.SelectedValue = doEdycji.IdNabywca;

                comboBoxSprzedazEdytujPlatnosc.DataSource = wyswietl.Platnosc();
                comboBoxSprzedazEdytujPlatnosc.DisplayMember = "Rodzaj";
                comboBoxSprzedazEdytujPlatnosc.ValueMember = "Id";
                comboBoxSprzedazEdytujPlatnosc.SelectedValue = doEdycji.IdPlatnosc;

                comboBoxSprzedazEdytujStatus.DataSource = wyswietl.Status();
                comboBoxSprzedazEdytujStatus.DisplayMember = "Status";
                comboBoxSprzedazEdytujStatus.ValueMember = "Id";
                comboBoxSprzedazEdytujStatus.SelectedValue = doEdycji.IdStatus;

                comboBoxSprzedazEdytujTermin.DataSource = wyswietl.Termin();
                comboBoxSprzedazEdytujTermin.DisplayMember = "Termin";
                comboBoxSprzedazEdytujTermin.ValueMember = "Id";
                comboBoxSprzedazEdytujTermin.SelectedValue = doEdycji.IdTermin;
            }
        }

        private void buttonSprzedazEdytujWyczysc_Click(object sender, EventArgs e)
        {
            //czyści pola/wczytuje zerowe i datą obecną  np pod dopisz
            SprzedazEdytujWyczyscPola();
        }

        private void buttonSprzedazEdytujDopisz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Utworzyć nowy rekord w tabeli Sprzedaz ?",
            "Poerdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TabSprzedaz tabSprzedaz = new TabSprzedaz();

                tabSprzedaz.DataSprzedazy = dateTimePickerSprzedazEdytujDataSprzedazy.Value;
                tabSprzedaz.DataWystawienia = dateTimePickerSprzedazEdytujDataWystawienia.Value;

                tabSprzedaz.NrZlecenia = int.Parse(textBoxSprzedazEdytujNrZlecenia.Text);
                tabSprzedaz.NrUmowy = int.Parse(textBoxSprzedazEdytujNrUmowy.Text);
                tabSprzedaz.Tresc = richTextBoxSprzedazEdytujTresc.Text;

                tabSprzedaz.Netto = double.Parse(textBoxSprzedazEdytujNetto.Text);

                tabSprzedaz.IdVat = ((VatViewModel)comboBoxSprzedazEdytujVat.SelectedItem).Id;

                tabSprzedaz.Uwagi = richTextBoxSprzedazEdytujUwagi.Text;

                tabSprzedaz.IdDostarczanie = ((DostarczanieViewModel)comboBoxSprzedazEdytujDostarczenie.SelectedItem).Id;

                tabSprzedaz.IdKierownik = ((KierownikViewModel)comboBoxSprzedazEdytujKierownik.SelectedItem).Id;

                tabSprzedaz.IdNabywca = ((NabywcaViewModel)comboBoxSprzedazEdytujNabywca.SelectedItem).Id;

                tabSprzedaz.IdPlatnosc = ((PlatnoscViewModel)comboBoxSprzedazEdytujPlatnosc.SelectedItem).Id;

                tabSprzedaz.IdStatus = ((StatusViewModel)comboBoxSprzedazEdytujStatus.SelectedItem).Id;

                tabSprzedaz.IdTermin = ((TerminViewModel)comboBoxSprzedazEdytujTermin.SelectedItem).Id;

                obsluga.WpiszTabSprzedaz(tabSprzedaz);

                dataGridViewSprzedaz.DataSource = wyswietl.BezFiltru();
                SprzedazEdytujWpiszWartosciSelectedIteam();
            }
         }

        private void buttonSprzedazEdytujZatwierdz_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dataGridViewSprzedaz.CurrentRow.Cells[0].Value;
            
            if (MessageBox.Show(
            "Zatwierdzić zmiany rekordu tabeli Sprzedaz o Id " + selectedId + " ?",
            "Poerdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabSprzedaz doEdycji = dbContext.SprzedazC.Where(a => (
                    a.IdSprzedaz == selectedId)).First();

                    doEdycji.DataSprzedazy = dateTimePickerSprzedazEdytujDataSprzedazy.Value;
                    doEdycji.DataWystawienia = dateTimePickerSprzedazEdytujDataWystawienia.Value;

                    doEdycji.NrZlecenia = int.Parse(textBoxSprzedazEdytujNrZlecenia.Text);
                    doEdycji.NrUmowy = int.Parse(textBoxSprzedazEdytujNrUmowy.Text);
                    doEdycji.Tresc = richTextBoxSprzedazEdytujTresc.Text;

                    doEdycji.Netto = double.Parse(textBoxSprzedazEdytujNetto.Text);

                    doEdycji.IdVat = ((VatViewModel)comboBoxSprzedazEdytujVat.SelectedItem).Id;

                    doEdycji.Uwagi = richTextBoxSprzedazEdytujUwagi.Text;

                    doEdycji.IdDostarczanie = ((DostarczanieViewModel)comboBoxSprzedazEdytujDostarczenie.SelectedItem).Id;

                    doEdycji.IdKierownik = ((KierownikViewModel)comboBoxSprzedazEdytujKierownik.SelectedItem).Id;

                    doEdycji.IdNabywca = ((NabywcaViewModel)comboBoxSprzedazEdytujNabywca.SelectedItem).Id;

                    doEdycji.IdPlatnosc = ((PlatnoscViewModel)comboBoxSprzedazEdytujPlatnosc.SelectedItem).Id;

                    doEdycji.IdStatus = ((StatusViewModel)comboBoxSprzedazEdytujStatus.SelectedItem).Id;

                    doEdycji.IdTermin = ((TerminViewModel)comboBoxSprzedazEdytujTermin.SelectedItem).Id;

                    dbContext.SaveChanges();

                    dataGridViewSprzedaz.DataSource = wyswietl.BezFiltru();
                    SprzedazEdytujWpiszWartosciSelectedIteam();
                }
            }
        }

        private void buttonSprzedazEdytujPomin_Click(object sender, EventArgs e)
        {
            SprzedazEdytujWpiszWartosciSelectedIteam();
        }



        private void buttonSprzedazEdytujKasuj_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dataGridViewSprzedaz.CurrentRow.Cells[0].Value;
            if (MessageBox.Show(
                "Skasować rekord tabeli Sprzedaz o Id " + selectedId + " ?",
                "Poerdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabSprzedaz doEdycji = dbContext.SprzedazC.Where(a => (
                    a.IdSprzedaz == selectedId)).First();

                    dbContext.SprzedazC.Remove(doEdycji);
                    dbContext.SaveChanges();
                    dataGridViewSprzedaz.DataSource = wyswietl.BezFiltru();
                    SprzedazEdytujWpiszWartosciSelectedIteam();
                }
            }
        }

        private void textBoxSprzedazEdytujNetto_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxSprzedazEdytujNetto.Text, out _))
            {
                textBoxSprzedazEdytujNetto.Text = "";
            }
        }

        private void textBoxSprzedazEdytujNrZlecenia_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSprzedazEdytujNrZlecenia.Text, out _))
            {
                textBoxSprzedazEdytujNrZlecenia.Text = "";
            }
        }

        private void textBoxSprzedazEdytujNrUmowy_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSprzedazEdytujNrUmowy.Text, out _))
            {
                textBoxSprzedazEdytujNrUmowy.Text = "";
            }
        }




    }
}