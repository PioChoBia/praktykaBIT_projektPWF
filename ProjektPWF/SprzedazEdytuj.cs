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

        private void SprzedazEdytujWpiszWartosciSelectedIteam()
        {
           
            int selectedId = (int)dataGridViewSprzedaz.CurrentRow.Cells[0].Value;                               
            using (var dbContext = new ApplicationDbContext())
            {
                TabSprzedaz doEdycji = dbContext.SprzedazC.Where(a => (
                a.IdSprzedaz == selectedId)).First();

                DateTimePicker d = new DateTimePicker();
                
                dateTimePickerSprzedazEdytujDataSprzedazy.CustomFormat= "d MMMM yyyy";
                dateTimePickerSprzedazEdytujDataSprzedazy.Format = DateTimePickerFormat.Custom;
                dateTimePickerSprzedazEdytujDataSprzedazy.Value= doEdycji.DataSprzedazy;

                dateTimePickerSprzedazEdytujDataWystawienia.CustomFormat= "d MMMM yyyy";
                dateTimePickerSprzedazEdytujDataWystawienia.Format = DateTimePickerFormat.Custom;
                dateTimePickerSprzedazEdytujDataWystawienia.Value = doEdycji.DataWystawienia;

                textBoxSprzedazEdytujNrZlecenia.Text = doEdycji.NrZlecenia.ToString();
                textBoxSprzedazEdytujNrUmowy.Text = doEdycji.NrUmowy.ToString();
                richTextBoxSprzedazEdytujTrescUmowy.Text = doEdycji.Tresc;
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


        private void buttonSprzedazEdytujZatwierdz_Click(object sender, EventArgs e)
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

            dataGridViewSprzedaz.DataSource = wyswietl.BezFiltru();
        }

        private void buttonSprzedazEdytujPomin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSprzedazEdytujNetto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSprzedazEdytujNrZlecenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSprzedazEdytujNrUmowy_TextChanged(object sender, EventArgs e)
        {

        }




    }
}