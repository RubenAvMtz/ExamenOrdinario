using ExamenOrdinario.Clases;
using ExamenOrdinario.Interfaces;

namespace ExamenOrdinario
{
    internal class Program
    {
        static List<IPersona> listaPersonas = new List<IPersona>();
        static void Main(string[] args)
        {
            bool continuarPrograma = true;
            while (continuarPrograma)
            {
                Console.WriteLine("MENU PRINCIPAL");
                Console.WriteLine("1 - Administración del centro");
                Console.WriteLine("2 - Administración de adopciones");
                Console.WriteLine("3 - Administración de bienestar animal");
                Console.WriteLine("4 - Simulación de interacciones");
                Console.WriteLine("5 - Finalizar programa");
                int opcionSeleccionadaMP = int.Parse(Console.ReadLine()); // MP = Menu Principal
                switch(opcionSeleccionadaMP)
                {
                    case 1:
                        MenuAdministacionCentro();
                        break;
                    case 2:
                        MenuAdministracionAdopciones();
                        break;
                    case 3:
                        MenuAdministracionBienestarAnimal();
                        break;
                    case 4:
                        SimulacionInteracciones();
                        break;
                    case 5:
                        continuarPrograma = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }

        static void MenuAdministacionCentro()
        {
            bool continuarMAC = true; // MAC =  Menu Administracion Centro
            while (continuarMAC)
            {
                Console.WriteLine("1 - Administración de personas");
                Console.WriteLine("2 - Administración de mascotas");
                Console.WriteLine("3 - Regresar al menú anterior");
                int opcionSeleccionadaMAC = int.Parse(Console.ReadLine());
                switch(opcionSeleccionadaMAC)
                {
                    case 1:
                        MenuCentroAdministracionPersonas();
                        break;
                    case 2:
                        MenuCentroAdministracionMascotas();
                        break;
                    case 3:
                        continuarMAC = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }

        static void MenuCentroAdministracionPersonas()
        {
            bool continuarMCAP = true; // MCAP = Menu Centro Administracion Personas
            while (continuarMCAP)
            {
                Console.WriteLine("1 - Mostrar las personas registradas");
                Console.WriteLine("2 - Registrar persona nueva");
                Console.WriteLine("3 - Buscar personas por nombre");
                Console.WriteLine("4 - Examinar Persona");
                Console.WriteLine("5 - Regresar al menu anterior");
                int opcionSeleccionadaMCAP = int.Parse(Console.ReadLine());
                switch (opcionSeleccionadaMCAP)
                {
                    case 1:
                        if(listaPersonas.Count == 0)
                        {
                            Console.WriteLine("No hay personas registradas.");
                        }
                        else
                        {
                            foreach(var persona in listaPersonas)
                            {
                                Console.WriteLine($"{persona.ID} - {persona.Nombre}");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingresa el nombre de la persona:");
                        string nuevoNombre = Console.ReadLine();
                        listaPersonas.Add(new Persona(nuevoNombre));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nombre del usuario:");
                        string nombreIngresado = Console.ReadLine();
                        foreach(var persona in listaPersonas)
                        {
                            if(persona.Nombre == nombreIngresado)
                            {
                                Console.WriteLine($"{persona.ID} - {persona.Nombre}");
                            }
                        }
                        break;
                    case 4:

                        break;
                    case 5:
                        continuarMCAP = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }

        static void MenuCentroAdministracionMascotas()
        {
            bool continuarMCAM = true; // MCAM = Menu Centro Administracion Mascotas
            while (continuarMCAM)
            {
                Console.WriteLine("1 - Mostrar todas las mascotas registradas");
                Console.WriteLine("2 - Registrar mascota nueva");
                Console.WriteLine("3 - Buscar mascotas por especie");
                Console.WriteLine("4 - Buscar mascotas por nombre");
                Console.WriteLine("5 - Examinar mascota");
                Console.WriteLine("6 - Regresar al menu anterior");
                int opcionSeleccionadaMCAM = int.Parse(Console.ReadLine());
                switch (opcionSeleccionadaMCAM)
                {
                    case 1:
                        SimulacionInteracciones();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        continuarMCAM = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }

        static void MenuAdministracionAdopciones()
        {
            bool continuarMAA = true; // MAA = Menu Adminsitración Adopciones
            while (continuarMAA)
            {
                Console.WriteLine("1 - Ver mascotas disponibles para adoptar");
                Console.WriteLine("2 - Adoptar mascota");
                Console.WriteLine("3 - Regresar al menú anterior");
                int opcionSeleccionadaMAA = int.Parse(Console.ReadLine());
                switch(opcionSeleccionadaMAA)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        continuarMAA = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            
        }

        static void MenuAdministracionBienestarAnimal()
        {
            bool continuarMABA = true; // MABA = Menu Administración Bienestar Animal
            while (continuarMABA)
            {
                Console.WriteLine("1 - Servicio de spa");
                Console.WriteLine("2 - Corte de pelo");
                Console.WriteLine("3 - Regresar al menú anterior");
                int opcionSeleccionadaMABA = int.Parse(Console.ReadLine());
                switch (opcionSeleccionadaMABA)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        continuarMABA = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }

        }

        static void SimulacionInteracciones()
        {
            foreach(var persona in listaPersonas)
            {
                //Terminar
            }
        }
    }
}