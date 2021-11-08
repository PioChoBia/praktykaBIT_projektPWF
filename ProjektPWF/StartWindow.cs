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

            comboBoxDopiszDostarczanie.DataSource = wyswietl.ComboBoxDopiszDostarczanie();
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

        private void buttonTabelePoboczne_Click(object sender, EventArgs e)
        {
            tabControlTabelePoboczne.Visible = true;
            TabelePoboczne tabelePoboczne = new TabelePoboczne();


            dataGridViewTabelePoboczneDostarczanie.Columns.Clear();
            
            DataGridViewColumn id = new DataGridViewTextBoxColumn();
            id.Name = "Id";
            id.HeaderText = "id";
            id.DataPropertyName = "Id";
            id.Width = 30;
            dataGridViewTabelePoboczneDostarczanie.Columns.Insert(0, id);
            
            DataGridViewColumn sposob = new DataGridViewTextBoxColumn();
            sposob.Name = "Sposob";
            sposob.HeaderText = "sposób";
            sposob.DataPropertyName = "Sposob";
            sposob.Width = 100;
            dataGridViewTabelePoboczneDostarczanie.Columns.Insert(1, sposob);

            DataGridViewButtonColumn kasuj = new DataGridViewButtonColumn();
            kasuj.Name = "kasuj";
            kasuj.HeaderText = "";
            kasuj.Text = "kasuj";
            kasuj.UseColumnTextForButtonValue = true;
            kasuj.Width = 50;
            dataGridViewTabelePoboczneDostarczanie.Columns.Insert(2, kasuj);


            dataGridViewTabelePoboczneDostarczanie.DataSource = tabelePoboczne.WyswietlDostarczanie();


        }

        private void dataGridViewTabelePoboczneDostarczanie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {

                DataGridViewRow row = dataGridViewTabelePoboczneDostarczanie.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Skasować pole o id : {0}?", row.Cells["Id"].Value), "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var dbContext = new ApplicationDbContext())
                    {
                        var doSkasowania = dbContext.DostarczanieC.Where(
                            a =>( a.Id == int.Parse( row.Cells["Id"].Value.ToString() )                            
                             )                                         
                        
                        ).First();

                        dbContext.DostarczanieC.Remove(doSkasowania);
                        dbContext.SaveChanges();
                    }








                }   
            }
        }
    }
}