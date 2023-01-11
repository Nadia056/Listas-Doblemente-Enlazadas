using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_Enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Lista lista = new Lista();
            while (opcion != 9) 
            {
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("-------------------");
                Console.WriteLine("1: Vaciar lista");
                Console.WriteLine("2: Mostrar lista de primero a ultimo");
                Console.WriteLine("3: Mostrar lista de ultimo a primero");
                Console.WriteLine("4: Insertar palabra");
                Console.WriteLine("5: Modificar palabra");
                Console.WriteLine("6: Eliminar palabra");
                Console.WriteLine("7: Creditos");
                Console.WriteLine("8: Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        lista.vaciarLista();
                        Console.Clear();
                        break;
                    case 2:
                        lista.desplegarListaPrimero();
                        Console.Clear();
                        break;
                    case 3:
                        lista.desplegarListaUltimo();
                        Console.Clear();
                        break;
                    case 4:
                        lista.Insertar();
                        Console.Clear();
                        break;
                    case 5:
                        lista.modificarPalabra();
                        Console.Clear();
                        break;
                    case 6:
                        lista.eliminarPalabra();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Nadia Salzar");
                        Console.WriteLine("Juan Carlos Duron ");
                        Console.WriteLine("4A");
                        Console.WriteLine("TIDSM");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
