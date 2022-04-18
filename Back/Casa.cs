using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPropiedadesCodigoLimpio
{
    internal class Casa:Terreno
    {
        
        private int _pisos;
        private int _habitaciones;
        private int _baños;
        private int _garaje;

        public int Pisos { get => _pisos; set => _pisos = value; }
        public int Habitaciones { get => _habitaciones; set => _habitaciones = value; }
        public int Baños { get => _baños; set => _baños = value; }
        public int Garaje { get => _garaje; set => _garaje = value; }
        
        public Casa() : base()
        {
            _pisos = 1;
            _habitaciones = 1;
            _baños = 1;
            _garaje = 0;
        }

        public Casa(string direccion, string dueno, string nombre, long precio, string estado, int metraje, int pisos, int habitaciones, int baños, int garaje) : base(direccion, dueno, nombre, precio, estado, metraje)
        {
            _pisos = pisos;
            _habitaciones = habitaciones;
            _baños = baños;
            _garaje = garaje;
        }
    }
}
