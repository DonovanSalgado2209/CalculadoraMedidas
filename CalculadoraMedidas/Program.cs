using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Char opcion;
            String continuar;

            do
            {
                Console.WriteLine("1.- Metros a millas");
                Console.WriteLine("2.- Metro a kilometro");
                Console.WriteLine("3.- Metro a decimetros");
                Console.WriteLine("4.- Metro a pies");
                Console.WriteLine("5.- Metro a yardas");
                Console.WriteLine("6.- Metro a pulgadas");
                Console.WriteLine("7.- Metro a millas nauticas");
                Console.WriteLine("0.-Salir");
                Console.Write("\n");
                Console.Write("Dime una opción: ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '7');



                switch (opcion)
                {
                    case '0':
                        {
                            Environment.Exit(0);
                        }
                        break;

                    case '1':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese los metros que quiera convertir: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Operaciones op = new Operaciones(numeroX);

                            Console.WriteLine("El resultado es: " + op.MetroToMi().ToString());

                        }
                        break;
                    case '2':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese los metros que quiera convertir: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Operaciones op = new Operaciones(numeroX);

                            Console.WriteLine("El resultado es: " + op.MetroToKm().ToString());

                        }
                        break;
                    case '3':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese los metros que quiera convertir: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Operaciones op = new Operaciones(numeroX);

                            Console.WriteLine("El resultado es: " + op.MetroToDm().ToString());
                        }
                        break;
                    case '4':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese los metros que quiera convertir: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Operaciones op = new Operaciones(numeroX);

                            Console.WriteLine("El resultado es: " + op.MetroToFt().ToString());

                        }
                        break;
                    case '5':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese los metros que quiera convertir: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Operaciones op = new Operaciones(numeroX);

                            Console.WriteLine("El resultado es: " + op.MetroToYd().ToString());

                        }
                        break;
                    case '6':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese los metros que quiera convertir: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Operaciones op = new Operaciones(numeroX);

                            Console.WriteLine("El resultado es: " + op.MetroToIn().ToString());

                        }
                        break;
                    case '7':
                        {
                            Console.Write("{0}\n", opcion);
                            Console.WriteLine("-------------------------------");

                            Console.Write("Ingrese los metros que quiera convertir: ");
                            double numeroX = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Operaciones op = new Operaciones(numeroX);

                            Console.WriteLine("El resultado es: " + op.MetroToNkt().ToString());

                        }
                        break;
                }

                Console.WriteLine("-------------------------------");
                Console.Write("¿Deseas continuar? y/n: ");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");
        }
    }
}
