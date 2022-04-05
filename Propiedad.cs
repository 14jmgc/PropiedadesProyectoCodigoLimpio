using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPropiedadesCodigoLimpio
{
    internal class Propiedad
    {
        static void Main(string[] args)
        {
            bool salir = false;

            #region Atributos
            List<Terreno> listaTerrenos = new List<Terreno>();
            List<Casa> listaCasas = new List<Casa>();
            List<Finca> listaFincas = new List<Finca>();
            List<SalonDeEventos> listaSalones = new List<SalonDeEventos>();
            #endregion
            while (!salir)
            {
                try
                {
                    Console.WriteLine("Menu: ");
                    Console.WriteLine("1. Propiedades.");
                    Console.WriteLine("2. Salir\n");
                    Console.WriteLine("Digite la opcion seleccionada: ");
                    int menu = Convert.ToInt16(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            #region Propiedades
                            bool propiedad = false;
                            while (!propiedad)

                            {
                                try
                                {


                                    Console.WriteLine("Has elegido la opción Propiedad.\n");

                                    Console.WriteLine("1. Agregar una propiedad. ");
                                    Console.WriteLine("2. Mostrar propiedades. ");
                                    Console.WriteLine("3. Editar estado de una propiedad. ");
                                    Console.WriteLine("4. Eliminar una propiedad. ");


                                    Console.WriteLine("0. Devolverse al menu anterior. \n");

                                    Console.WriteLine("Ingrese una opcion:  ");
                                    int menuPropiedades = Convert.ToInt16(Console.ReadLine());

                                    switch (menuPropiedades)
                                    {
                                        case 0:
                                            #region Devolverse
                                            Console.WriteLine("Has elegido devolverter al menu anterior.");
                                            propiedad = true;
                                            Console.ReadKey();
                                            break;
                                        #endregion

                                        case 1:
                                            #region Agregar propiedad
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
                                                    #region Terreno
                                                    Console.WriteLine("Ingrese la dirección:  ");
                                                    string direccionTerreno = (Console.ReadLine());
                                                    Console.WriteLine("Ingrese el dueño:  ");
                                                    string duenoTerreno = (Console.ReadLine());
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
                                                        Dueno = duenoTerreno,
                                                        Nombre = nombreTerreno,
                                                        Precio = precioTerreno,
                                                        Estado = estadoTerreno,
                                                        Metraje = metrajeTerreno,
                                                    });

                                                    Console.WriteLine("Terreno agregado.");
                                                    Console.ReadKey();

                                                    break;
                                                #endregion
                                                case 2:
                                                    #region Casa/Apartamento
                                                    Console.WriteLine("Ingrese la dirección:  ");
                                                    string direccionCasa = (Console.ReadLine());
                                                    Console.WriteLine("Ingrese el dueño:  ");
                                                    string duenoCasa = (Console.ReadLine());
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
                                                        Dueno = duenoCasa,
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
                                                #endregion
                                                case 3:
                                                    #region Finca
                                                    Console.WriteLine("Ingrese la dirección:  ");
                                                    string direccionFinca = (Console.ReadLine());
                                                    Console.WriteLine("Ingrese el dueño:  ");
                                                    string duenoFinca = (Console.ReadLine());
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
                                                        Dueno = duenoFinca,
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
                                                #endregion
                                                case 4:
                                                    #region Salon de eventos
                                                    Console.WriteLine("Ingrese la dirección:  ");
                                                    string direccionSalonDeEventos = (Console.ReadLine());
                                                    Console.WriteLine("Ingrese el dueño:  ");
                                                    string duenoSalonDeEventos = (Console.ReadLine());
                                                    Console.WriteLine("Ingrese el nombre:  ");
                                                    string nombreSalonDeEventos = (Console.ReadLine());
                                                    Console.WriteLine("Ingrese el precio:  ");
                                                    long precioSalonDeEventos = Convert.ToInt64(Console.ReadLine());
                                                    Console.WriteLine("Ingrese el estado:  ");
                                                    string estadoSalonDeEventos = (Console.ReadLine());
                                                    Console.WriteLine("Ingrese el metraje:  ");
                                                    long metrajeSalonDeEventos = Convert.ToInt64(Console.ReadLine());
                                                    Console.WriteLine("Ingrese la cantidad de baños:  ");
                                                    int bañosSalonDeEventos = Convert.ToInt16(Console.ReadLine());
                                                    listaSalones.Add(new SalonDeEventos()

                                                    {
                                                        Direccion = direccionSalonDeEventos,
                                                        Dueno = duenoSalonDeEventos,
                                                        Nombre = nombreSalonDeEventos,
                                                        Precio = precioSalonDeEventos,
                                                        Estado = estadoSalonDeEventos,
                                                        Metraje = metrajeSalonDeEventos,
                                                        Baños = bañosSalonDeEventos
                                                    });

                                                    Console.WriteLine("Salon De Eventos agregado.");
                                                    Console.ReadKey();

                                                    break;
                                                    #endregion
                                            }

                                            break;
                                        #endregion

                                        case 2:
                                            #region Mostrar

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
                                                    #region Terrenos

                                                    Console.WriteLine("Los terrenos disponibles son: ");

                                                    for (int i = 0; i < listaTerrenos.Count; i++)
                                                    {
                                                        Console.WriteLine(
                                                            "Direccion: " + listaTerrenos[i].Direccion +
                                                            " Dueño: " + listaTerrenos[i].Dueno +
                                                            " Nombre de la propiedad: " + listaTerrenos[i].Nombre +
                                                            " Precio: " + listaTerrenos[i].Precio +
                                                            " Estado: " + listaTerrenos[i].Estado +
                                                            " Metraje: " + listaTerrenos[i].Metraje);
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                #endregion
                                                case 2:
                                                    #region Casas/Apartamentos
                                                    Console.WriteLine("Las casas/apartamentos disponibles son: ");

                                                    for (int i = 0; i < listaCasas.Count; i++)
                                                    {
                                                        Console.WriteLine(
                                                            "Direccion: " + listaCasas[i].Direccion +
                                                            " Dueño: " + listaCasas[i].Dueno +
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
                                                #endregion
                                                case 3:
                                                    #region Fincas
                                                    Console.WriteLine("Las fincas disponibles son: ");

                                                    for (int i = 0; i < listaFincas.Count; i++)
                                                    {
                                                        Console.WriteLine(
                                                            "Direccion: " + listaFincas[i].Direccion +
                                                            " Dueño: " + listaFincas[i].Dueno +
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
                                                #endregion
                                                case 4:
                                                    #region Salones
                                                    Console.WriteLine("Los salones disponibles son: ");


                                                    for (int i = 0; i < listaSalones.Count; i++)
                                                    {
                                                        Console.WriteLine(
                                                            "Direccion: " + listaSalones[i].Direccion +
                                                            " Dueño: " + listaSalones[i].Dueno +
                                                            " Nombre de la propiedad: " + listaSalones[i].Nombre +
                                                            " Precio: "
                                                            + listaSalones[i].Precio +
                                                            " Estado: " + listaSalones[i].Estado +
                                                            " Metraje: " + listaSalones[i].Metraje +
                                                            " Baños: " + listaSalones[i].Baños);
                                                    }

                                                    Console.ReadKey();
                                                    break;
                                                    #endregion

                                            }

                                            break;
                                            #endregion
                                                                                  
                                        case 3:
                                            #region Editar estado de una propiedad

                                            Console.WriteLine("¿Que propiedad desea editar?");

                                            Console.WriteLine("1. Terreno");
                                            Console.WriteLine("2. Casa/Apartamento");
                                            Console.WriteLine("3. Finca");
                                            Console.WriteLine("4. Salon de eventos");
                                            Console.WriteLine("0. Devolverse al menú anterior.\n");

                                            Console.WriteLine("Digite la opcion seleccionada: ");
                                            int editarPropiedad = Convert.ToInt16(Console.ReadLine());

                                            Console.WriteLine("\n Cual es la direccion de la propiedad que desea editar: ");
                                            string direccionEditar = Console.ReadLine();
                                            Console.WriteLine("Digite el nuevo estado de la propiedad: ");
                                            string nuevoEstado = Console.ReadLine();

                                            switch (editarPropiedad)
                                            {
                                                case 0:
                                                    Console.WriteLine("Has elegido devolverter al menu anterior.");
                                                    Console.ReadKey();
                                                    break;

                                                case 1:
                                                    #region Terrenos

                                                    for (int i = 0; i < listaTerrenos.Count; i++)
                                                    {
                                                        if (listaTerrenos[i].Direccion == direccionEditar)
                                                        {

                                                            listaTerrenos[i].Estado = nuevoEstado;
                                                            Console.WriteLine("Se ha editado con exito.");
                                                            break;
                                                        }
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                #endregion
                                                case 2:
                                                    #region Casas/Apartamentos
                                                    Console.WriteLine("Las casas/apartamentos disponibles son: ");

                                                    for (int i = 0; i < listaCasas.Count; i++)
                                                    {
                                                        if (listaCasas[i].Direccion == direccionEditar)
                                                        {
                                                            listaCasas[i].Estado = nuevoEstado;
                                                            Console.WriteLine("Se ha editado con exito.");
                                                        }
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                #endregion
                                                case 3:
                                                    #region Fincas
                                                    Console.WriteLine("Las fincas disponibles son: ");

                                                    for (int i = 0; i < listaFincas.Count; i++)
                                                    {
                                                        if (listaFincas[i].Direccion == direccionEditar)
                                                        {
                                                            listaFincas[i].Estado = nuevoEstado;
                                                            Console.WriteLine("Se ha editado con exito.");
                                                            break;
                                                        }
                                                    }
                                                    Console.ReadKey();

                                                    break;
                                                #endregion
                                                case 4:
                                                    #region Salones
                                                    Console.WriteLine("Los salones disponibles son: ");


                                                    for (int i = 0; i < listaSalones.Count; i++)
                                                    {
                                                        if (listaSalones[i].Direccion == direccionEditar)
                                                        {
                                                            listaSalones[i].Estado = nuevoEstado;
                                                            Console.WriteLine("Se ha editado con exito.");
                                                            break;
                                                        }
                                                    }

                                                    Console.ReadKey();
                                                    break;
                                                    #endregion

                                            }



                                            break;
                                        #endregion


                                        case 4:
                                            #region Eliminar Propiedad
                                            Console.WriteLine("\n Eliminar una propiedad.");
                                            Console.WriteLine("¿Que propiedad desea eliminar?");

                                            Console.WriteLine("1. Terreno");
                                            Console.WriteLine("2. Casa/Apartamento");
                                            Console.WriteLine("3. Finca");
                                            Console.WriteLine("4. Salon de eventos");
                                            Console.WriteLine("0. Devolverse al menú anterior.\n");

                                            Console.WriteLine("Digite la opcion seleccionada: ");
                                            int eliminarPropiedad = Convert.ToInt16(Console.ReadLine());

                                            Console.WriteLine("\n Cual es la direccion de la propiedad que desea eliminar: ");
                                            string direccionEliminar = Console.ReadLine();

                                            switch (eliminarPropiedad)
                                            {
                                                case 0:
                                                    Console.WriteLine("Has elegido devolverter al menu anterior.");
                                                    Console.ReadKey();
                                                    break;

                                                case 1:
                                                    #region Terrenos

                                                    for (int i = 0; i < listaTerrenos.Count; i++)
                                                    {
                                                        if (listaTerrenos[i].Direccion == direccionEliminar)
                                                        {

                                                            listaTerrenos.RemoveAt(i);
                                                            Console.WriteLine("Se ha eliminado con exito.");
                                                            break;
                                                        }
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                #endregion
                                                case 2:
                                                    #region Casas/Apartamentos
                                                    Console.WriteLine("Las casas/apartamentos disponibles son: ");

                                                    for (int i = 0; i < listaCasas.Count; i++)
                                                    {
                                                        if (listaCasas[i].Direccion == direccionEliminar)
                                                        {
                                                            listaTerrenos.RemoveAt(i);
                                                            Console.WriteLine("Se ha eliminado con exito.");
                                                            break;
                                                        }
                                                    }
                                                    Console.ReadKey();
                                                    break;
                                                #endregion
                                                case 3:
                                                    #region Fincas
                                                    Console.WriteLine("Las fincas disponibles son: ");

                                                    for (int i = 0; i < listaFincas.Count; i++)
                                                    {
                                                        if (listaCasas[i].Direccion == direccionEliminar)
                                                        {
                                                            listaCasas.RemoveAt(i);
                                                            Console.WriteLine("Se ha eliminado con exito.");
                                                            break;
                                                        }
                                                    }
                                                    Console.ReadKey();

                                                    break;
                                                #endregion
                                                case 4:
                                                    #region Salones
                                                    Console.WriteLine("Los salones disponibles son: ");


                                                    for (int i = 0; i < listaSalones.Count; i++)
                                                    {
                                                        if (listaSalones[i].Direccion == direccionEliminar)
                                                        {
                                                            listaSalones.RemoveAt(i);
                                                            Console.WriteLine("Se ha eliminado con exito.");
                                                            break;
                                                        }
                                                    }

                                                    Console.ReadKey();
                                                    break;
                                                    #endregion

                                            }
                                            break;


                                            #endregion                                           

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
                        #endregion

                        case 2:
                            #region Salir
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            Console.ReadKey();
                            break;
                        #endregion
                        default:
                            Console.WriteLine("Elige una opcion valida.");
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