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
                comboBoxSprzedazEdytujVat.SelectedItem = doEdycji.Vat;






            }

        }


        private void buttonSprzedazEdytujZatwierdz_Click(object sender, EventArgs e)
        {

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