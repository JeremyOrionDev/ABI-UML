﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIenCouche
{
    public partial class frmContrat : Form
    {
        public frmContrat()
        {
            InitializeComponent();
        
            cBxTypeContrat.Items.AddRange(new String[] { "CDI", "CDD", "stage", "interim" });
        }
    }
}
