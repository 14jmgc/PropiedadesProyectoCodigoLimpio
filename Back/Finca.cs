using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPropiedadesCodigoLimpio
{
    public class Finca:Casa
    {
        private int _piscina;
        private int _tobogan;
        private int _turco;
        private int _cancha;
        private int _capacidad;

        public int Piscina { get => _piscina; set => _piscina = value; }
        public int Tobogan { get => _tobogan; set => _tobogan = value; }
        public int Turco { get => _turco; set => _turco = value; }
        public int Cancha { get => _cancha; set => _cancha = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }

        public Finca() : base()
        {
            _piscina = 0;
            _tobogan = 0;
            _turco = 0;
            _cancha = 0;
            _capacidad = 0;
        }

        public Finca(string direccion, string dueno, string nombre, long precio, string estado, int metraje, int pisos, int habitaciones, int baños, int garaje, int piscina, int tobogan, int turco, int cancha, int capacidad) : base(direccion, dueno, nombre, precio, estado, metraje, pisos, habitaciones, baños, garaje)
        {
            _piscina = piscina;
            _tobogan = tobogan;
            _turco = turco;
            _cancha = cancha;
            _capacidad = capacidad;
        }
    }
}
