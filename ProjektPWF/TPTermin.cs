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
        //kod Termin z TabelePoboczne

        private void buttonTabelePoboczneTerminKasuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneTerminEdytuj.Visible = false;
            groupBoxTabelePoboczneTerminDopisz.Visible = false;
            TerminViewModel terminViewModel = (TerminViewModel)listBoxTabelePoboczneTermin.SelectedItem;
            if (MessageBox.Show("Skasować pole " + terminViewModel.Termin + " ?", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabTermin doSkasowania = dbContext.TerminC.Where(a => (a.Id == terminViewModel.Id)).First();
                    dbContext.TerminC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePoboczneTermin.DataSource = wyswietl.Termin();
                }
            }
        }


        private void buttonTabelePoboczneTerminDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneTerminDopisz.Visible = true;
            groupBoxTabelePoboczneTerminEdytuj.Visible = false;
        }
        private void buttonTabelePoboczneTerminDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneTerminDopisz.Text != "")
            {
                int x = int.Parse(textBoxTabelePoboczneTerminDopisz.Text);
                TabTermin tabTermin = new TabTermin { Termin =  x};
                obsluga.WpiszTabTermin(tabTermin);
                listBoxTabelePoboczneTermin.DataSource = wyswietl.Termin();
                textBoxTabelePoboczneTerminDopisz.Text = "";
                groupBoxTabelePoboczneTerminDopisz.Visible = false;
            }
        }

        private void buttonTabelePoboczneTerminDopiszPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneTerminDopisz.Text = "";
            groupBoxTabelePoboczneTerminDopisz.Visible = false;
        }



        private void buttonTabelePoboczneTerminEdytuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneTerminDopisz.Visible = false;
            groupBoxTabelePoboczneTerminEdytuj.Visible = true;
            TerminViewModel terminViewModel = (TerminViewModel)listBoxTabelePoboczneTermin.SelectedItem;
            textBoxTabelePoboczneTerminEdytuj.Text = terminViewModel.Termin.ToString();
        }

        private void buttonTabelePoboczneTerminEdytujOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneTerminEdytuj.Text != "")
            {
                TerminViewModel terminViewModel = (TerminViewModel)listBoxTabelePoboczneTermin.SelectedItem;
                using (var dbContext = new ApplicationDbContext())
                {
                    TabTermin doEdycji = dbContext.TerminC.Where(a => (a.Id == terminViewModel.Id)).First();
                    int x = int.Parse(textBoxTabelePoboczneTerminEdytuj.Text);
                    doEdycji.Termin = x;                    
                    dbContext.SaveChanges();
                }
                listBoxTabelePoboczneTermin.DataSource = wyswietl.Termin();
                groupBoxTabelePoboczneTerminEdytuj.Visible = false;
            }
        }

        private void buttonTabelePoboczneTerminEdytujPomin_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneTerminEdytuj.Visible = false;
        }

        private void textBoxTabelePoboczneTerminDopisz_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTabelePoboczneTerminDopisz.Text, out _))
            {
                textBoxTabelePoboczneTerminDopisz.Text = "0";
            }
        }

        private void textBoxTabelePoboczneTerminEdytuj_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTabelePoboczneTerminEdytuj.Text, out _))
            {
                textBoxTabelePoboczneTerminEdytuj.Text = "0";
            }
        }
    }
}
