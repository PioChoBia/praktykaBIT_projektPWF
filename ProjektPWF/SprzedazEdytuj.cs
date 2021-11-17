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


        private void buttonSprzedazEdytujZatwierdz_Click(object sender, EventArgs e)
        {
            int selectedId = (int)dataGridViewSprzedaz.CurrentRow.Cells[0].Value;
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

                doEdycji.IdTermin = ((TerminViewModel)comboBoxDopiszTermin.SelectedItem).Id;

                dbContext.SaveChanges();

                dataGridViewSprzedaz.DataSource = wyswietl.BezFiltru();
            }
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