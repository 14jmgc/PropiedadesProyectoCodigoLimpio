﻿namespace ProyectoPropiedadesCodigoLimpio
{
    internal class SalonDeEventos:Terreno
    {
        private int _baños;

        public int Baños { get => _baños; set => _baños = value; }
        public SalonDeEventos() : base()
        {
            _baños = 2;

        }
    public SalonDeEventos(string direccion, string dueño, string nombre, long precio, string estado, int metraje, int baños)
        {
            _baños = baños;

        }

    }

}