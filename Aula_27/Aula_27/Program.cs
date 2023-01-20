using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27
{
    internal class Program
    {
        static void Main()
        {
            int[] matriz = new int[]{ 1, 2, 3, 4, 5, 6};
            soma(matriz);
        }

        static void soma(params int[]n)
        {   
            int a = 0;
            if (n.Length < 1) {Console.WriteLine("a matriz chegou vazia");}
            else if(n.Length < 2) { Console.WriteLine("Só há um valor: " + n[1]); }
            else
            {                
                
                for (int v = 0; v<n.Length; v++)
                {

                    a += n[v];
                }

                Console.WriteLine(a);



            }
            Console.ReadLine();


        }
    }
}
