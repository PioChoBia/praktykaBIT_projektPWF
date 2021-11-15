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
        public void DopiszStartowe()
        {   
            //wstawia wartości startowe do dopisz
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

            DopiszStartowe();

            dataGridViewSprzedaz.DataSource = wyswietl.BezFiltru();

        }


        private void buttonDopiszPomin_Click(object sender, EventArgs e)
        {
            DopiszStartowe();
        }



        private void textBoxDopiszNrZlecenia_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDopiszNrZlecenia.Text, out _))
            {
                textBoxDopiszNrZlecenia.Text = "";
            }
        }

        private void textBoxDopiszNrUmowy_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDopiszNrUmowy.Text, out _))
            {
                textBoxDopiszNrUmowy.Text = "";
            }
        }

        private void textBoxDopiszNetto_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxDopiszNetto.Text, out _))
            {
                textBoxDopiszNetto.Text = "";
            }
        }


    }
}
