using System;
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
    public partial class Terreno : Form
    {
        public Terreno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonDic_Click(object sender, EventArgs e)
        {
            String direccion = textDirecion.Text;
            MostrarTerreo mt = new MostrarTerreo(direccion);
            mt.Show();
        }

        private void buttonDue_Click(object sender, EventArgs e)
        {

        }
    }
}
