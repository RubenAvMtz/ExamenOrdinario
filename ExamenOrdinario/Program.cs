namespace ExamenOrdinario
{
    internal class Program
    {
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
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
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
    }
}