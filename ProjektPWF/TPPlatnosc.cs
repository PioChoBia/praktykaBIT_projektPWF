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
        //kod Platnosc z TabelePoboczne

        private void buttonTabelePobocznePlatnoscKasuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePobocznePlatnoscEdytuj.Visible = false;
            groupBoxTabelePobocznePlatnoscDopisz.Visible = false;
            PlatnoscViewModel platnoscViewModel = (PlatnoscViewModel)listBoxTabelePobocznePlatnosc.SelectedItem;
            if (MessageBox.Show("Skasować pole " + platnoscViewModel.Rodzaj + " ?", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabPlatnosc doSkasowania = dbContext.PlatnoscC.Where(a => (a.Id == platnoscViewModel.Id)).First();
                    dbContext.PlatnoscC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePobocznePlatnosc.DataSource = wyswietl.Platnosc();
                }
            }
        }


        private void buttonTabelePobocznePlatnoscDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePobocznePlatnoscEdytuj.Visible = false;
            groupBoxTabelePobocznePlatnoscDopisz.Visible = true;
        }

        private void buttonTabelePobocznePlatnoscDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePobocznePlatnoscDopisz.Text != "")
            {
                TabPlatnosc tabPlatnosc = new TabPlatnosc { Rodzaj = textBoxTabelePobocznePlatnoscDopisz.Text };
                obsluga.WpiszTabPlatnosc(tabPlatnosc);
                listBoxTabelePobocznePlatnosc.DataSource = wyswietl.Platnosc();
                textBoxTabelePobocznePlatnoscDopisz.Text = "";
                groupBoxTabelePobocznePlatnoscDopisz.Visible = false;
            }
        }

        private void buttonTabelePobocznePlatnoscDopiszPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePobocznePlatnoscDopisz.Text = "";
            groupBoxTabelePobocznePlatnoscDopisz.Visible = false;
        }


        private void buttonTabelePobocznePlatnoscEdytuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePobocznePlatnoscDopisz.Visible = false;
            groupBoxTabelePobocznePlatnoscEdytuj.Visible = true;
            PlatnoscViewModel platnoscViewModel = (PlatnoscViewModel)listBoxTabelePobocznePlatnosc.SelectedItem;
            textBoxTabelePobocznePlatnoscEdytuj.Text = platnoscViewModel.Rodzaj;
        }

        private void buttonTabelePobocznePlatnoscEdytujOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePobocznePlatnoscEdytuj.Text != "")
            {
                PlatnoscViewModel platnoscViewModel = (PlatnoscViewModel)listBoxTabelePobocznePlatnosc.SelectedItem;
                using (var dbContext = new ApplicationDbContext())
                {
                    TabPlatnosc doEdycji = dbContext.PlatnoscC.Where(a => (a.Id == platnoscViewModel.Id)).First();
                    doEdycji.Rodzaj = textBoxTabelePobocznePlatnoscEdytuj.Text;
                    dbContext.SaveChanges();
                }
                listBoxTabelePobocznePlatnosc.DataSource = wyswietl.Platnosc();
                groupBoxTabelePobocznePlatnoscEdytuj.Visible = false;
            }
        }

        private void buttonTabelePobocznePlatnoscEdytujPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePobocznePlatnoscEdytuj.Text = "";
            groupBoxTabelePobocznePlatnoscEdytuj.Visible = false;
        }














    }
}
