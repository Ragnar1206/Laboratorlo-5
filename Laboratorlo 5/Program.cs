using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorlo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 8");
            Console.WriteLine("Menu");
            Console.WriteLine("1.Sumatoria ");
            Console.WriteLine("2.Mostrar tablas de multiplicar");
            Console.WriteLine("3.numero perfecto");
            Console.WriteLine("Escriba su opcion");
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Ingrese un numero");
                        int numero = int.Parse(Console.ReadLine());
                        int suma;
                        suma = 0;
                        for (int c = 0; c <= numero; c++)
                            suma += c;

                        Console.WriteLine("el resultado es " + suma);

                    } while (true);

                case 2:


                    int r;
                    Console.WriteLine("Ingrese un numero");
                    int n2 = int.Parse(Console.ReadLine());

                    for (int x = 1; x <= 10; x++)
                    {
                        r = n2 * x;
                        Console.WriteLine(n2 + " * " + x + " = " + r);
                    }
                    Console.ReadLine();
                    break;

                case 3:

                    int ab = 0;
                    Console.WriteLine("Ingrese un numero mayor a cero");
                    int n3 = int.Parse(Console.ReadLine());
                    int i = n3 - 1;
                    while (i > 0)
                    {
                        int r2 = n3 % i;
                        if (r2 == 0)
                        {
                            ab = ab + i;
                        }
                        i = i - 1;
                    }
                    if (n3 == ab)
                    {
                        Console.WriteLine("Es un numero perfecto");
                    }
                    else
                    {
                        Console.WriteLine("Es un numero imperfecto");
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }
}
     