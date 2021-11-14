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
        //kod Nabywca Tabele Poboczne

        private void buttonTabelePoboczneNabywcaKasuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneNabywcaEdytuj.Visible = false;
            groupBoxTabelePoboczneNabywcaDopisz.Visible = false;
            NabywcaViewModel nabywcaViewModel = (NabywcaViewModel)listBoxTabelePoboczneNabywca.SelectedItem;
            if (MessageBox.Show("Skasować pole " + nabywcaViewModel.NazwaNabywcy + " ?", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabNabywca doSkasowania = dbContext.NabywcaC.Where(a => (a.Id == nabywcaViewModel.Id)).First();
                    dbContext.NabywcaC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePoboczneNabywca.DataSource = wyswietl.Nabywca();
                }
            }
        }


        private void buttonTabelePoboczneNabywcaDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneNabywcaEdytuj.Visible = false;
            groupBoxTabelePoboczneNabywcaDopisz.Visible = true;
        }

        private void textBoxTabelePoboczneNabywcaDopiszNip_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(textBoxTabelePoboczneNabywcaDopiszNip.Text, out _))
            {
                string s1 = textBoxTabelePoboczneNabywcaDopiszNip.Text;
                if (s1.Length > 1)
                {
                    textBoxTabelePoboczneNabywcaDopiszNip.Text = s1.Substring(0, s1.Length - 1);
                }
                else
                {
                    textBoxTabelePoboczneNabywcaDopiszNip.Text ="";
                }
            }
        }

        private void buttonTabelePoboczneNabywcaDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneNabywcaDopiszAdres.Text != "" & textBoxTabelePoboczneNabywcaDopiszNazwa.Text != "" &
              textBoxTabelePoboczneNabywcaDopiszNip.Text != "")
            {
                TabNabywca tabNabywca = new TabNabywca
                {
                    NazwaNabywcy = textBoxTabelePoboczneNabywcaDopiszNazwa.Text,
                    AdresNabywcy = textBoxTabelePoboczneNabywcaDopiszAdres.Text,
                    NIP = textBoxTabelePoboczneNabywcaDopiszNip.Text
                };
                obsluga.WpiszTabNabywca(tabNabywca);
                listBoxTabelePoboczneNabywca.DataSource = wyswietl.Nabywca();
                textBoxTabelePoboczneNabywcaDopiszNazwa.Text = "";
                textBoxTabelePoboczneNabywcaDopiszAdres.Text = "";
                textBoxTabelePoboczneNabywcaDopiszNip.Text = "";
                groupBoxTabelePoboczneNabywcaDopisz.Visible = false;
            }
        }

        private void buttonTabelePoboczneNabywcaDopiszPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneNabywcaDopiszNazwa.Text = "";
            textBoxTabelePoboczneNabywcaDopiszAdres.Text = "";
            textBoxTabelePoboczneNabywcaDopiszNip.Text = "";
            groupBoxTabelePoboczneNabywcaDopisz.Visible = false;
        }


        private void buttonTabelePoboczneNabywcaEdytuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneNabywcaEdytuj.Visible = true;
            groupBoxTabelePoboczneNabywcaDopisz.Visible = false;
            NabywcaViewModel nabywcaViewModel = (NabywcaViewModel)listBoxTabelePoboczneNabywca.SelectedItem;
            using(var dbContext=new ApplicationDbContext())
            {
                TabNabywca doEdycji = dbContext.NabywcaC.Where(a => (a.Id == nabywcaViewModel.Id)).First();
                textBoxTabelePoboczneNabywcaEdytujNazwa.Text = doEdycji.NazwaNabywcy;
                textBoxTabelePoboczneNabywcaEdytujAdres.Text = doEdycji.AdresNabywcy;
                textBoxTabelePoboczneNabywcaEdytujNip.Text = doEdycji.NIP;
            }
        }

        private void textBoxTabelePoboczneNabywcaEdytujNip_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(textBoxTabelePoboczneNabywcaEdytujNip.Text, out _))
            {
                string s1 = textBoxTabelePoboczneNabywcaEdytujNip.Text;
                if (s1.Length > 1)
                {
                    textBoxTabelePoboczneNabywcaEdytujNip.Text = s1.Substring(0, s1.Length - 1);
                }
                else
                {
                    textBoxTabelePoboczneNabywcaEdytujNip.Text = "";
                }
            }
        }


        private void buttonTabelePoboczneNabywcaEdytujOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneNabywcaEdytujAdres.Text != "" & textBoxTabelePoboczneNabywcaEdytujNazwa.Text != "" &
              textBoxTabelePoboczneNabywcaEdytujNip.Text != "")
            {
                NabywcaViewModel nabywcaViewModel = (NabywcaViewModel)listBoxTabelePoboczneNabywca.SelectedItem;
                using (var dbContext = new ApplicationDbContext())
                {
                    TabNabywca doEdycji = dbContext.NabywcaC.Where(a => (a.Id == nabywcaViewModel.Id)).First();
                    doEdycji.NazwaNabywcy = textBoxTabelePoboczneNabywcaEdytujNazwa.Text;
                    doEdycji.AdresNabywcy=textBoxTabelePoboczneNabywcaEdytujAdres.Text;
                    doEdycji.NIP = textBoxTabelePoboczneNabywcaEdytujNip.Text;
                    dbContext.SaveChanges();
                }
                listBoxTabelePoboczneNabywca.DataSource = wyswietl.Nabywca();
                textBoxTabelePoboczneNabywcaEdytujNazwa.Text = "";
                textBoxTabelePoboczneNabywcaEdytujAdres.Text = "";
                textBoxTabelePoboczneNabywcaEdytujNip.Text = "";
                groupBoxTabelePoboczneNabywcaEdytuj.Visible = false;
            }
        }

        private void buttonTabelePoboczneNabywcaEdytujPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneNabywcaEdytujNazwa.Text = "";
            textBoxTabelePoboczneNabywcaEdytujAdres.Text = "";
            textBoxTabelePoboczneNabywcaEdytujNip.Text = "";
            groupBoxTabelePoboczneNabywcaEdytuj.Visible = false;
        }
    }
}
