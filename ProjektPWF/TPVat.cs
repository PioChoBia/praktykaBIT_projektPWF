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
        //kod do Vat z TabelePoboczne

        private void buttonTabelePoboczneVatKasuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneVatDopisz.Visible = false;
            groupBoxTabelePoboczneVatEdytuj.Visible = false;
            VatViewModel vatViewModel = (VatViewModel)listBoxTabelePoboczneVat.SelectedItem;
            if (MessageBox.Show("Skasować pole " + vatViewModel.StawkaVat + " ?", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabVat doSkasowania = dbContext.VatC.Where(a => (a.Id == vatViewModel.Id)).First();
                    dbContext.VatC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePoboczneVat.DataSource = wyswietl.Vat();
                }
            }
        }


        private void buttonTabelePoboczneVatDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneVatDopisz.Visible = true;
            groupBoxTabelePoboczneVatEdytuj.Visible = false;
        }

        private void buttonTabelePoboczneVatDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneVatDopisz.Text != "")
            {
                TabVat tabVat = new TabVat { StawkaVat = textBoxTabelePoboczneVatDopisz.Text };
                obsluga.WpiszTabVat(tabVat);
                listBoxTabelePoboczneVat.DataSource = wyswietl.Vat();
                textBoxTabelePoboczneVatDopisz.Text = "";
                groupBoxTabelePoboczneVatDopisz.Visible = false;
            }
        }

        private void buttonTabelePoboczneVatDopiszPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneVatDopisz.Text = "";
            groupBoxTabelePoboczneVatDopisz.Visible = false;
        }

        private void buttonTabelePoboczneVatEdytuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneVatDopisz.Visible = false;
            groupBoxTabelePoboczneVatEdytuj.Visible = true;
            VatViewModel vatViewModel = (VatViewModel)listBoxTabelePoboczneVat.SelectedItem;
            textBoxTabelePoboczneVatEdytuj.Text = vatViewModel.StawkaVat;
        }

        private void buttonTabelePoboczneVatEdytujOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneVatEdytuj.Text != "")
            {
                VatViewModel vatViewModel = (VatViewModel)listBoxTabelePoboczneVat.SelectedItem;
                using (var dbContext = new ApplicationDbContext())
                {
                    TabVat doEdycji = dbContext.VatC.Where(a => (a.Id == vatViewModel.Id)).First();
                    doEdycji.StawkaVat = textBoxTabelePoboczneVatEdytuj.Text;
                    dbContext.SaveChanges();
                }
                listBoxTabelePoboczneVat.DataSource = wyswietl.Vat();
                groupBoxTabelePoboczneVatEdytuj.Visible = false;
            }
        }

        private void buttonTabelePoboczneVatEdytujPomin_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneVatEdytuj.Visible = false;
        }
    }
}
