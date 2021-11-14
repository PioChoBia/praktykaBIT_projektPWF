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
        //kod Status z TabelePoboczne

        private void buttonTabelePoboczneStatusKasuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneStatusEdytuj.Visible = false;
            groupBoxTabelePoboczneTerminDopisz.Visible = false;
            StatusViewModel statusViewModel = (StatusViewModel)listBoxTabelePoboczneStatus.SelectedItem;        
            if (MessageBox.Show("Skasować pole " + statusViewModel.Status + " ?", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var dbContext = new ApplicationDbContext())
                {
                    TabStatus doSkasowania = dbContext.StatusC.Where(a => (a.Id == statusViewModel.Id)).First();
                    dbContext.StatusC.Remove(doSkasowania);
                    dbContext.SaveChanges();
                    listBoxTabelePoboczneStatus.DataSource = wyswietl.Status();
                }
            }
        }


        private void buttonTabelePoboczneStatusDopisz_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneStatusEdytuj.Visible = false;
            groupBoxTabelePoboczneTerminDopisz.Visible = true;
        }

        private void buttonTabelePoboczneStatusDopiszOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneStatusDopisz.Text != "")
            {
                TabStatus tabStatus = new TabStatus { Status = textBoxTabelePoboczneStatusDopisz.Text };
                obsluga.WpiszTabStatus(tabStatus);
                listBoxTabelePoboczneStatus.DataSource = wyswietl.Status();
                textBoxTabelePoboczneStatusDopisz.Text = "";
                groupBoxTabelePoboczneStatusDopisz.Visible = false;
            }
        }

        private void buttonTabelePoboczneStatusDopiszPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneStatusDopisz.Text = "";
            groupBoxTabelePoboczneStatusDopisz.Visible = false;
        }



        private void buttonTabelePoboczneStatusEdytuj_Click(object sender, EventArgs e)
        {
            groupBoxTabelePoboczneStatusDopisz.Visible = false;
            groupBoxTabelePoboczneStatusEdytuj.Visible = true;
            StatusViewModel statusViewModel = (StatusViewModel)listBoxTabelePoboczneStatus.SelectedItem;
            textBoxTabelePoboczneStatusEdytuj.Text = statusViewModel.Status;
        }

        private void buttonTabelePoboczneStatusEdytujOK_Click(object sender, EventArgs e)
        {
            if (textBoxTabelePoboczneStatusEdytuj.Text != "")
            {
                StatusViewModel statusViewModel = (StatusViewModel)listBoxTabelePoboczneStatus.SelectedItem;
                using (var dbContext = new ApplicationDbContext())
                {
                    TabStatus doEdycji = dbContext.StatusC.Where(a => (a.Id == statusViewModel.Id)).First();
                    doEdycji.Status = textBoxTabelePoboczneStatusEdytuj.Text;
                    dbContext.SaveChanges();
                }
                listBoxTabelePoboczneStatus.DataSource = wyswietl.Status();
                groupBoxTabelePoboczneStatusEdytuj.Visible = false;
            }
        }

        private void buttonTabelePoboczneStatusEdytujPomin_Click(object sender, EventArgs e)
        {
            textBoxTabelePoboczneStatusEdytuj.Text = "";
            groupBoxTabelePoboczneStatusEdytuj.Visible = false;
        }

    }
}
