using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje1_semana3_FunAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int suma;

            //Console.ReadLine es igual a leer en Pseint
            Console.WriteLine("ingrese n1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese n2: ");
            n2 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            Console.WriteLine("La suma es: " + suma);

            Console.ReadKey();
        }
    }
}
