using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Ingrsee el valor de a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b: ");
            b = int.Parse(Console.ReadLine());

            if (a > b) 
            {
                c = a;
                a = b;
                b = c;

            }
            Console.WriteLine("Valor de a: " + a);
            Console.WriteLine("Valor de b: " + b);
            Console.ReadKey();

        }


    }
}
