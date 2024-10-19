using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP001724_Bloque1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("\n" + "Selecciona una opción: ");
                Console.WriteLine("1: COMPARACION DE POSITIVOS O NEGATIVOS ");
                Console.WriteLine("2: TABLAS DE MULTIPLICAR ");
                Console.WriteLine("3: SUMA DE POSITIVOS ");
                Console.WriteLine("4: DETERMINACION DE NUMEROS PRIMOS ");
                Console.WriteLine("5: PROMEDIO DE NUMEROS ");
                Console.WriteLine("0: SALIR ");
                Console.WriteLine("Ingrese una opcion: ");

                string input = Console.ReadLine();
                int opcion;
                if (int.TryParse(input, out opcion))
                {
                    Console.Clear();
                    if (opcion >= 0 && opcion <= 5)
                    {
                        switch (opcion)
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
                                continuar = "n";
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida, intente de nuevo");
                    }
                }
            }
        }
        static void Comparacion()
        {
            while (true)
            {
                Console.WriteLine("Ingrese un numero para saber si es positivo o negativo: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    Console.WriteLine("El numero es positivo");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El numero es negativo");
                }
                else if (numero == 0)
                {
                    Console.WriteLine("El numero es cero, el programa se detendrá");
                    break;
                }
            }
        }
        static void Tablas()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero * i);
            }
        }
        static void Suma()
        {
            int suma = 0;
            while (true)
            {
                Console.WriteLine("\n" + "Ingrese un numero positivo, recuerde que los numeros negativos finalizan el programa o bien puede detenerse usando 0: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero;
                    Console.WriteLine("La suma hasta el momento es: " + suma);
                }
                else if (numero == 0)
                {
                    Console.WriteLine("\n" + "La suma de los numeros positivos es: " + suma);
                    break;
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El numero es negativo, no se sumara");
                    Console.WriteLine("La suma de los numeros positivos es: " + suma);
                    break;
                }
            }
        }
       static void Primos()
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }
       static void Promedio()
        {
            int suma = 0;
            int contador = 0;
            int numero = 0;

            Console.WriteLine("Ingrese números para calcular el promedio. Para finalizar, ingrese 0: ");
            while (int.TryParse(Console.ReadLine(), out numero) && numero != 0)
            {
                suma += numero;
                contador++;
            }

            double promedio = (double)suma / contador;
            Console.WriteLine("El promedio de los números es: " + promedio);
        }


    }
}
