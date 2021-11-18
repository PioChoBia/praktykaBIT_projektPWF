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
        //kod  Kierownik z TabelePoboczne

        private void buttonTabelePoboczneKierownikKasuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneKierownikDopisz.Visible = false;
            groupBoxTabelePoboczneKierownikEdytuj.Visible = false;
            KierownikViewModel kierownikViewModel = (KierownikViewModel)listBoxTabelePoboczneKierownik.SelectedItem;
            if (MessageBox.Show(
                "Skasować pole " + kierownikViewModel.NazwiskoKierownika + " ?",
                "Poerdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabKierownik doSkasowania = dbContext.KierownikC.Where(a => (a.Id == kierownikViewModel.Id)).First();
                    dbContext.KierownikC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePoboczneKierownik.DataSource = wyswietl.Kierownik();
                }
            }
        }


        private void buttonTabelePoboczneKierownikDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneKierownikDopisz.Visible = true;
            groupBoxTabelePoboczneKierownikEdytuj.Visible = false;
        }

        private void buttonTabelePoboczneKierownikDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneKierownikDopiszImie.Text != "" & textBoxTabelePoboczneKierownikDopiszNazwisko.Text !="")
            {
                TabKierownik tabKierownik = new TabKierownik { ImieKierownika = textBoxTabelePoboczneKierownikDopiszImie.Text, NazwiskoKierownika=textBoxTabelePoboczneKierownikDopiszNazwisko.Text };
                obsluga.WpiszTabKierownik(tabKierownik);
                listBoxTabelePoboczneKierownik.DataSource = wyswietl.Kierownik();
                textBoxTabelePoboczneKierownikDopiszImie.Text = "";
                textBoxTabelePoboczneKierownikDopiszNazwisko.Text = "";
                groupBoxTabelePoboczneKierownikDopisz.Visible = false;
            }
        }

        private void buttonTabelepoboczneKierownikDopiszPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneKierownikDopiszImie.Text = "";
            textBoxTabelePoboczneKierownikDopiszNazwisko.Text = "";
            groupBoxTabelePoboczneKierownikDopisz.Visible = false;
        }

        private void buttonTabelePoboczneKierownikEdytuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneKierownikDopisz.Visible = false;
            groupBoxTabelePoboczneKierownikEdytuj.Visible = true;
            KierownikViewModel kierownikViewModel = (KierownikViewModel)listBoxTabelePoboczneKierownik.SelectedItem;
            using (var dbContext = new ApplicationDbContext())
            {
                TabKierownik doEdycji = dbContext.KierownikC.Where(a => (a.Id == kierownikViewModel.Id)).First();
                textBoxTabelePoboczneKierownikEdytujImie.Text = doEdycji.ImieKierownika;
                textBoxTabelePoboczneKierownikEdytujNazwisko.Text = doEdycji.NazwiskoKierownika;
            }
        }

 
        private void buttonTabelePoboczneKierownikEdytujOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneKierownikEdytujImie.Text != "" & textBoxTabelePoboczneKierownikEdytujNazwisko.Text != "")
            {
                KierownikViewModel kierownikViewModel = (KierownikViewModel)listBoxTabelePoboczneKierownik.SelectedItem;
                using (var dbContext = new ApplicationDbContext())
                {
                    TabKierownik doEdycji = dbContext.KierownikC.Where(a => (a.Id == kierownikViewModel.Id)).First();
                    doEdycji.ImieKierownika = textBoxTabelePoboczneKierownikEdytujImie.Text;
                    doEdycji.NazwiskoKierownika = textBoxTabelePoboczneKierownikEdytujNazwisko.Text;
                    dbContext.SaveChanges();
                }
                listBoxTabelePoboczneKierownik.DataSource = wyswietl.Kierownik();
                textBoxTabelePoboczneKierownikEdytujImie.Text = "";
                textBoxTabelePoboczneKierownikEdytujNazwisko.Text = "";
                groupBoxTabelePoboczneKierownikEdytuj.Visible = false;
            }
        }

        private void buttonTabelePoboczneKierownikEdytujPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneKierownikEdytujImie.Text = "";
            textBoxTabelePoboczneKierownikEdytujNazwisko.Text = "";
            groupBoxTabelePoboczneKierownikEdytuj.Visible = false;
        }



    }
}
