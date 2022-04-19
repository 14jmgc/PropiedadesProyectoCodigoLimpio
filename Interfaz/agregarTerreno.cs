using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPropiedadesCodigoLimpio;

namespace Interfaz
{
    public partial class agregarTerreno : Form
    {
        public agregarTerreno()
        {
            InitializeComponent();
        }

        private void btnCancelarAgregarTerreno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            Terreno nuevoTerreno = new Terreno();
            nuevoTerreno.Direccion = txtDireccionTerreno.Text;
            nuevoTerreno.Dueno = txtDueñoTerreno.Text;
            nuevoTerreno.Nombre = txtNombreTerreno.Text;
            nuevoTerreno.Precio = txtPrecioTerreno.Text;
            nuevoTerreno.Estado = txtEstadoTerreno.Text;
            nuevoTerreno.Metraje = txtMetrajeTerreno.Text;

        }
    }
}
