using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22
{
    internal class Program
    {
        static void Main(string[] args){
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for( int i =  0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //    Console.ReadLine();
            //}

            foreach (int i in a)
            {
                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
    }
}
