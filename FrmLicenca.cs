﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmLicenca : Form
    {
        public FrmLicenca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Process.Start("https://www.pudim.com.br/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa registrdo");
        }
    }
}
