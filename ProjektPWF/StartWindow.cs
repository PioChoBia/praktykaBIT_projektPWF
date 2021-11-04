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





        public StartWindow()
        {
            InitializeComponent();
            Obsluga obsluga = new Obsluga();
            Wyswietl wyswietl = new Wyswietl();

            //obsluga.WpiszStartoweDoTabel();

            dataGridView1.DataSource= wyswietl.BezFiltru();








        }

        private void StartWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonDopisz_Click(object sender, EventArgs e)
        {
            //groupBoxDopisz.Visible = true;            
            
            dateTimePickerDopiszDataSprzedazy.CustomFormat = "d MMMM yyyy";
            dateTimePickerDopiszDataSprzedazy.Format = DateTimePickerFormat.Custom;
            dateTimePickerDopiszDataWystawienia.CustomFormat = "d MMMM yyyy";
            dateTimePickerDopiszDataWystawienia.Format = DateTimePickerFormat.Custom;

            textBoxDopiszNrZlecenia.Text = "0";
            textBoxDopiszNrUmowy.Text = "0";
            richTextBoxDopiszTrescUmowy.Text = "wpisz treść umowy";



        }

        private void buttonDopiszZatwierdz_Click(object sender, EventArgs e)
        {
            TabSprzedaz tabSprzedaz = new TabSprzedaz();  
            Obsluga obsluga1= new Obsluga();
            
            tabSprzedaz.DataSprzedazy = dateTimePickerDopiszDataSprzedazy.Value;
            tabSprzedaz.DataWystawienia = dateTimePickerDopiszDataWystawienia.Value;

            tabSprzedaz.NrZlecenia = int.Parse( textBoxDopiszNrZlecenia.Text );
            tabSprzedaz.NrUmowy = int.Parse( textBoxDopiszNrUmowy.Text );


            //groupBoxDopisz.Visible = false;
        }

        private void textBoxDopiszNrZlecenia_TextChanged(object sender, EventArgs e)
        {
            int parseValue;
            if (int.TryParse(textBoxDopiszNrZlecenia.Text, out parseValue)) 
            {
                textBoxDopiszNrZlecenia.Text = parseValue.ToString();
            }
            else 
            {
                textBoxDopiszNrZlecenia.Text = "0";          
            }

        }

        private void textBoxDopiszNrUmowy_TextChanged(object sender, EventArgs e)
        {
            int parseValue;
            if ( int.TryParse(textBoxDopiszNrUmowy.Text,  out parseValue )) 
            {
                textBoxDopiszNrUmowy.Text = parseValue.ToString();
            }
            else
            {
                textBoxDopiszNrUmowy.Text = "0";
            }
        }
    }
}