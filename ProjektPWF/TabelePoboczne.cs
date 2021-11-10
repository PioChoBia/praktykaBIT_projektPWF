using ProjektPWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjektPWF
{
    public partial class TabelePoboczne : Form
    {
        
        public void ListBox1()
        {
            ListBox l1=new ListBox();
            l1.FormattingEnabled = true;
        
            l1.Location = new System.Drawing.Point(500, 19);
            l1.Name = "listBoxTabelePoboczneDostarczanie1";
            l1.Size = new System.Drawing.Size(120, 160);
            l1.TabIndex = 10;
            l1.Visible = true;

        }

    }
}
