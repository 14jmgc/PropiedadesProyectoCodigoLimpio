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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarTerreno_Click(object sender, EventArgs e)
        {
            listaTerrenos.Add(new Terreno0())
            Terreno nuevoTerreno = new Terreno();
            nuevoTerreno.Direccion = txtDireccionTerreno
            MostrarTerreno mt = new MostrarTerreo(direccion);
            mt.Show();
        }

        private void buttonDue_Click(object sender, EventArgs e)
        {

        }
    }
}
