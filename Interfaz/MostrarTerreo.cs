﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MostrarTerreo : Form
    {
        public MostrarTerreo()
        {
            InitializeComponent();

        }
        public MostrarTerreo(String textDirecion, String textDueño)
        {
            InitializeComponent();
            labelDirec.Text = textDirecion;
            labelDue.Text = textDueño;
            labelNom.Text = text;
            labelPre.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}