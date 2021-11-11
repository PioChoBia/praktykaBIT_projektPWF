﻿using ProjektPWF.Models;
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
        //kod do Dostarczanie z TabelePoboczne

        private void buttonTabelePoboczne_Click(object sender, EventArgs e)
        {
            tabControlTabelePoboczne.Visible = true;
            groupBoxTabelePoboczneDostarczanieDopisz.Visible = false;
            groupBoxTabelePoboczneDostarczanieEdytuj.Visible = false;

            //TabelePoboczne tabelePoboczne = new TabelePoboczne();
            //tabelePoboczne.ListBox1();

            listBoxTabelePoboczneDostarczanie.DataSource = wyswietl.Dostarczanie();
            listBoxTabelePoboczneDostarczanie.DisplayMember = "Sposob";
            listBoxTabelePoboczneDostarczanie.ValueMember = "Id";

        }



        private void buttonDostarczanieKasuj_Click(object sender, EventArgs e)
        {

            DostarczanieViewModel dostarczanieViewModel = (DostarczanieViewModel)listBoxTabelePoboczneDostarczanie.SelectedItem;
            if (MessageBox.Show("Skasować pole " + dostarczanieViewModel.Sposob + " ?", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabDostarczanie doSkasowania = dbContext.DostarczanieC.Where(a => (a.Id == dostarczanieViewModel.Id)).First();
                    dbContext.DostarczanieC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePoboczneDostarczanie.DataSource = wyswietl.Dostarczanie();
                }
            }
        }

        private void buttonDostarczanieDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneDostarczanieDopisz.Visible = true;
        }

        private void buttonTabelePoboczneDostarczanieDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneDostarczanieDopisz.Text != "")
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
