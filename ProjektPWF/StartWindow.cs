﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace ProjektPWF
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();

            using (var dbContext = new ApplicationDbContext())
            {

            }
        }
    }
}