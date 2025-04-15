using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 ;
            Console.WriteLine("Ingrese valor de n1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor de n2: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1<n2)
            {
                Console.WriteLine(n1+"-"+n2);
            }
            if (n2 < n1)
            {
                Console.WriteLine(n1+"-"+n2);
            }
            
        }
    }
}
