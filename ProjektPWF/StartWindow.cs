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

        //tabela Sprzedaz
            dataGridViewSprzedaz.DataSource = wyswietl.BezFiltru();


            //wstawia wartości startowe/zerowe/ do dopisz sprzedaż
            DopiszStartowe();

         //tabele poboczne
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
            //Nabywca
            groupBoxTabelePoboczneNabywcaDopisz.Visible = false;
            groupBoxTabelePoboczneNabywcaEdytuj.Visible = false;
            listBoxTabelePoboczneNabywca.DataSource = wyswietl.Nabywca();
            listBoxTabelePoboczneNabywca.DisplayMember = "NazwaNabywcy";
            listBoxTabelePoboczneNabywca.ValueMember = "Id";
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

        private void StartWindow_Load(object sender, EventArgs e)
        {
            
        }


        private void buttonDopisz_Click(object sender, EventArgs e)
        {
       


        }




    }



}