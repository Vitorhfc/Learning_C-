using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25
{
    internal class Program
    {
        static void Main()
        {
            int a = 5, b = 4; 
            b = a + b;
            dobrar(ref a);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }

        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}
