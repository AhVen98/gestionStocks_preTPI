﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using locationMateriel;

namespace locationMateriel
{
    public partial class locMateriel : Form
    {
        public locMateriel()
        {
            InitializeComponent();
        }

        private void locMateriel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("add");
        }
    }
}
