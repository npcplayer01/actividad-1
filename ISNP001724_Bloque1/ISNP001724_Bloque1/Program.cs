using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP001724_Bloque1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecciona una opción: ");
            Console.WriteLine("1: COMPARACION DE POSITIVOS O NEGATIVOS ");
            Console.WriteLine("2: TABLAS DE MULTIPLICAR ");
            Console.WriteLine("3: SUMA DE POSITIVOS ");
            Console.WriteLine("4: DETERMINACION DE NUMEROS PRIMOS ");
            Console.WriteLine("5: PROMEDIO DE NUMEROS ");
            Console.WriteLine("0: SALIR ");
            Console.WriteLine("Opcion: ");
            Console.ReadLine();
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(opcion)
            {
                case 1:
                    Comparacion();
                    break;
                case 2:
                    Tablas();
                    break;
                case 3:
                    Suma();
                    break;
                case 4:
                    Primos();
                    break;
                case 5:
                    Promedio();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}

