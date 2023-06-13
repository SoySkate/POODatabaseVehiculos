using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODatabaseVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            do {
                Console.WriteLine("\n---MenuOptions---Introduzca una opcion---");
                Console.WriteLine("1.Crear Vehicuo:");
                Console.WriteLine("2.Recoger lista Vehiculos:");
                Console.WriteLine("3.Editar Vehiculo:");
                Console.WriteLine("4.Eliminar Vehiculo:");
                Console.WriteLine("5.Salir\n");
                int option;
                try { 
                 option = int.Parse(Console.ReadLine());
                }
                catch { option = default; }

                switch (option) {
                    case 1:
                        Console.WriteLine("Aqui se debe Crear el vehiculo:");
                        break;
                    case 2:
                        Console.WriteLine("Aqui se debe ver la Lista de vehiculos:");
                        break;
                    case 3:
                        Console.WriteLine("Aqui se debe Editar el vehiculo selected:");
                        break;
                    case 4:
                        Console.WriteLine("Aqui se debe crear el vehiculo:");
                        break;
                        case 5:
                        Console.WriteLine("Saliendo...");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Porfavor seleccione una opcion válida:");
                        break;
                }

            } while (menu==true);

            Console.ReadKey();

        }
    }
}
