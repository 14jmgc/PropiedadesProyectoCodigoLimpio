using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPropiedadesCodigoLimpio
{
    internal class Terreno
    {
        #region Atributos

        private string _direccion;
        private string _nombre;
        private string _dueño;
        private long _precio;
        private string _estado;
        private long _metraje;

        #endregion

        #region Propiedades

        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Dueño { get => _dueño; set => _dueño = value; }
        public long Precio { get => _precio; set => _precio = value; }

        public string Estado { get => _estado; set => _estado = value; }
        public long Metraje { get => _metraje; set => _metraje = value; }


        #endregion

        #region Constructor
        public Terreno()
        {
            _direccion = "Desconocida";
            _dueño = "No tiene";
            _nombre = "No tiene";
            _precio = 0;
            _estado = "¿?";
            _metraje = 0;
        }

        public Terreno(string direccion, string dueño, string nombre, long precio, string estado, long metraje)
        {
            _direccion = direccion;
            _dueño = dueño;
            _nombre = nombre;
            _precio = precio;
            _estado = estado;
            _metraje = metraje;
        }

    }
    #endregion
}
