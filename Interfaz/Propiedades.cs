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

        private void btnRegresarPropiedades_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarTerreno_Click(object sender, EventArgs e)
        {
            agregarTerreno nuevoTerreno = new agregarTerreno();
            nuevoTerreno.Show();

        }
    }
}
