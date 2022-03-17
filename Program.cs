using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPropiedadesCodigoLimpio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;


            List<Terreno> listaTerrenos = new List<Terreno>();
            List<Casa> listaCasas = new List<Casa>();
            List<Finca> listaFincas = new List<Finca>();

            while (!salir)
            {
                try
                {



                    Console.WriteLine("Menu: ");
                    Console.WriteLine("1. Propiedades.");
                    Console.WriteLine("2. Citas");
                    Console.WriteLine("3. Salir\n");
                    Console.WriteLine("Digite la opcion seleccionada: ");
                    int menu = Convert.ToInt16(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:

                            bool propiedad = false;
                            while (!propiedad)
                            {
                                try
                                {


                                    Console.WriteLine("Has elegido la opción Propiedad.\n");

                                    Console.WriteLine("1. Agregar una propiedad. ");
                                    Console.WriteLine("2. Editar una propiedad. ");
                                    Console.WriteLine("3. Eliminar una propiedad. ");
                                    Console.WriteLine("4. Mostrar propiedades.");
                                    Console.WriteLine("0. Devolverse al menu anterior. \n");

                                    Console.WriteLine("Ingrese una opcion:  ");
                                    int menuPropiedades = Convert.ToInt16(Console.ReadLine());

                                    switch (menuPropiedades)
                                    {
                                        case 0:
                                            Console.WriteLine("Has elegido devolverter al menu anterior.");
                                            propiedad = true;
                                            Console.ReadKey();
                                            break;

                                        case 1:
                                            
                                                Console.WriteLine("¿Que tipo de propiedad desea agregar?");
                                                Console.WriteLine("1. Terreno");
                                                Console.WriteLine("2. Casa/Apartamento");
                                                Console.WriteLine("3. Finca");
                                                Console.WriteLine("4. Salon de eventos");
                                                Console.WriteLine("0. Devolverse al menú anterior.\n");
                                                Console.WriteLine("Digite la opcion seleccionada: ");
                                                int tipoPropiedad = Convert.ToInt16(Console.ReadLine());


                                                switch (tipoPropiedad)
                                                {

                                                    case 0:

                                                        break;


                                                    case 1:

                                                        Console.WriteLine("Ingrese la dirección:  ");
                                                        string direccionTerreno = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el dueño:  ");
                                                        string dueñoTerreno = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el nombre:  ");
                                                        string nombreTerreno = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el precio:  ");
                                                        long precioTerreno = Convert.ToInt64(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el estado:  ");
                                                        string estadoTerreno = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el metraje:  ");
                                                        long metrajeTerreno = Convert.ToInt64(Console.ReadLine());


                                                        listaTerrenos.Add(new Terreno()
                                                        {
                                                            Direccion = direccionTerreno,
                                                            Dueño = dueñoTerreno,
                                                            Nombre = nombreTerreno,
                                                            Precio = precioTerreno,
                                                            Estado = estadoTerreno,
                                                            Metraje = metrajeTerreno,
                                                        });

                                                        Console.WriteLine("Terreno agregado.");
                                                        Console.ReadKey();

                                                        break;

                                                    case 2:

                                                        Console.WriteLine("Ingrese la dirección:  ");
                                                        string direccionCasa = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el dueño:  ");
                                                        string dueñoCasa = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el nombre:  ");
                                                        string nombreCasa = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el precio:  ");
                                                        long precioCasa = Convert.ToInt64(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el estado:  ");
                                                        string estadoCasa = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el metraje:  ");
                                                        long metrajeCasa = Convert.ToInt64(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de pisos:  ");
                                                        int pisosCasa = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de habitaciones:  ");
                                                        int habitacionesCasa = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de baños:  ");
                                                        int bañosCasa = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de garajes:  ");
                                                        int garajeCasa = Convert.ToInt16(Console.ReadLine());

                                                        listaCasas.Add(new Casa()
                                                        {
                                                            Direccion = direccionCasa,
                                                            Dueño = dueñoCasa,
                                                            Nombre = nombreCasa,
                                                            Precio = precioCasa,
                                                            Estado = estadoCasa,
                                                            Metraje = metrajeCasa,
                                                            Pisos = pisosCasa,
                                                            Habitaciones = habitacionesCasa,
                                                            Baños = bañosCasa,
                                                            Garaje = garajeCasa
                                                        });

                                                        Console.WriteLine("Casa/Apartamento agregado.");
                                                        Console.ReadKey();

                                                        break;

                                                    case 3:

                                                        Console.WriteLine("Ingrese la dirección:  ");
                                                        string direccionFinca = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el dueño:  ");
                                                        string dueñoFinca = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el nombre:  ");
                                                        string nombreFinca = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el precio:  ");
                                                        long precioFinca = Convert.ToInt64(Console.ReadLine());
                                                        Console.WriteLine("Ingrese el estado:  ");
                                                        string estadoFinca = (Console.ReadLine());
                                                        Console.WriteLine("Ingrese el metraje:  ");
                                                        long metrajeFinca = Convert.ToInt64(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de pisos:  ");
                                                        int pisosFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de habitaciones:  ");
                                                        int habitacionesFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de baños:  ");
                                                        int bañosFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de garajes:  ");
                                                        int garajeFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de piscinas:  ");
                                                        int piscinaFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de toboganes:  ");
                                                        int toboganFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de turcos:  ");
                                                        int turcoFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la cantidad de canchas:  ");
                                                        int canchaFinca = Convert.ToInt16(Console.ReadLine());
                                                        Console.WriteLine("Ingrese la capacidad de la finca:  ");
                                                        int capacidadFinca = Convert.ToInt16(Console.ReadLine());

                                                        listaFincas.Add(new Finca()
                                                        {
                                                            Direccion = direccionFinca,
                                                            Dueño = dueñoFinca,
                                                            Nombre = nombreFinca,
                                                            Precio = precioFinca,
                                                            Estado = estadoFinca,
                                                            Metraje = metrajeFinca,
                                                            Pisos = pisosFinca,
                                                            Habitaciones = habitacionesFinca,
                                                            Baños = bañosFinca,
                                                            Garaje = garajeFinca,
                                                            Piscina = piscinaFinca,
                                                            Tobogan = toboganFinca,
                                                            Turco = turcoFinca,
                                                            Cancha = canchaFinca,
                                                            Capacidad = capacidadFinca
                                                        });

                                                        Console.WriteLine("Finca agregada.");
                                                        Console.ReadKey();

                                                        break;
                                                    case 4:

                                                        break;

                                                }
                                            
                                        break;
                                           

                                        case 2:

                                            break;

                                        case 3:

                                            break;

                                        case 4:

                                            Console.WriteLine("¿Que propiedades desea mostrar?");
                                            Console.WriteLine("1. Terreno");
                                            Console.WriteLine("2. Casa/Apartamento");
                                            Console.WriteLine("3. Finca");
                                            Console.WriteLine("4. Salon de eventos");
                                            Console.WriteLine("0. Devolverse al menú anterior.\n");
                                            Console.WriteLine("Digite la opcion seleccionada: ");
                                            int mostrarPropiedad = Convert.ToInt16(Console.ReadLine());

                                            switch (mostrarPropiedad)
                                            {
                                                case 0:
                                                    Console.WriteLine("Has elegido devolverter al menu anterior.");
                                                    Console.ReadKey();
                                                    break;

                                                case 1:

                                                    Console.WriteLine("Los terrenos disponibles son: ");

                                                    for (int i = 0; i < listaTerrenos.Count; i++)
                                                    {
                                                        Console.WriteLine(
                                                            "Direccion: " + listaTerrenos[i].Direccion +
                                                            " Dueño: " + listaTerrenos[i].Dueño +
                                                            " Nombre de la propiedad: " + listaTerrenos[i].Nombre +
                                                            " Precio: " + listaTerrenos[i].Precio +
                                                            " Estado: " + listaTerrenos[i].Estado +
                                                            " Metraje: " + listaTerrenos[i].Metraje);
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                case 2:

                                                    Console.WriteLine("Las casas/apartamentos disponibles son: ");

                                                    for (int i = 0; i < listaCasas.Count; i++)
                                                    {
                                                        Console.WriteLine(
                                                            "Direccion: " + listaCasas[i].Direccion +
                                                            " Dueño: " + listaCasas[i].Dueño +
                                                            " Nombre de la propiedad: " + listaCasas[i].Nombre +
                                                            " Precio: " + listaCasas[i].Precio +
                                                            " Estado: " + listaCasas[i].Estado +
                                                            " Metraje: " + listaCasas[i].Metraje +
                                                            " #ro de pisos: " + listaCasas[i].Pisos +
                                                            " Habitaciones: " + listaCasas[i].Habitaciones +
                                                            " Baños: " + listaCasas[i].Baños +
                                                            " Garajes: " + listaCasas[i].Garaje);
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    for (int i = 0; i < listaFincas.Count; i++)
                                                    {
                                                        Console.WriteLine(
                                                            "Direccion: " + listaFincas[i].Direccion +
                                                            " Dueño: " + listaFincas[i].Dueño +
                                                            " Nombre de la propiedad: " + listaFincas[i].Nombre +
                                                            " Precio: "
                                                            + listaFincas[i].Precio +
                                                            " Estado: " + listaFincas[i].Estado +
                                                            " Metraje: " + listaFincas[i].Metraje +
                                                            " #ro de pisos: " + listaFincas[i].Pisos +
                                                            " Habitaciones: " + listaFincas[i].Habitaciones +
                                                            " Baños: " + listaFincas[i].Baños +
                                                            " Garajes: " + listaFincas[i].Garaje +
                                                            " Piscinas: " + listaFincas[i].Piscina +
                                                            " Toboganes: " + listaFincas[i].Tobogan +
                                                            " Turco: " + listaFincas[i].Turco +
                                                            " Capacidad: " + listaFincas[i].Baños);
                                                    }
                                                    Console.ReadKey();

                                                    break;
                                                case 4:

                                                    break;
                                            }

                                            break;

                                    }
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine("Por favor verifique el formato de los datos que está ingresando", e);
                                }
                                Console.ReadKey();

                            }

                            Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("Has elegido la opción Citas");
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 3.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException e)
                {                   
                    Console.WriteLine("Por favor verifique el formato de los datos que está ingresando", e);
                }
                Console.ReadKey();


            }
                        
            Console.WriteLine("El programa ha finalizado.");
            Console.ReadKey();
        }
    }
}
