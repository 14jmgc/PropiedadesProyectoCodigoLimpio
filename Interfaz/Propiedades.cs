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
    public partial class Propiedades : Form
    {
        public Propiedades()
        {
            InitializeComponent();
        }

        private void btnTerrenos_Click(object sender, EventArgs e)
        {
            Terreno t = new Terreno();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Casas c = new Casas();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fincas f = new Fincas();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalonDeEventos s = new SalonDeEventos();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblInmobiliaria_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
