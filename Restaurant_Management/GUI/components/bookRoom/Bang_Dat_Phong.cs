﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Bang_Dat_Phong : Form
    {
        private DataGridViewRow currentPH;
        private DataGridViewRow currentNH;

        public Bang_Dat_Phong(DataGridViewRow currentPH, DataGridViewRow currentNH)
        {
            this.currentPH = currentPH;
            this.currentNH = currentNH;

            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
