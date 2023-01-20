 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabela de gasto refeições semanal");
            int[,] a = new int[3,6];

            //Segunda
            a[0,0] = 10;
            a[1,0] = 25;
            a[2, 0] = 35;

            //Terça
            a[0, 1] = 8;
            a[1, 1] = 21;
            a[2, 1] = 10;

            //Quarta
            a[0, 2] = 20;
            a[1, 2] = 50;
            a[2, 2] = 0;

            //quinta
            a[0, 3] = 10;
            a[1, 3] = 25;
            a[2, 3] = 10;

            //Sexta
            a[0, 4] = 8;
            a[1, 4] = 25;
            a[2, 4] = 12;

            //total
            a[0, 5] = a[0, 0] + a[0, 1] + a[0, 2] + a[0, 3] + a[0, 4];
            a[1, 5] = a[1, 0] + a[1, 1] + a[1, 2] + a[1, 3] + a[1, 4];
            a[2, 5] = a[2, 0] + a[2, 1] + a[2, 2] + a[2, 3] + a[2, 4];

            Console.WriteLine("Matrizes dos gastos semanais:\n" + "Segunda-feira  -  Terça-feira  -  Quarta-feira  -  Quinta-feira  -  Sexta-feira  -  Total\n" + +a[0, 0] + "\t" + a[0, 1] + "\t" + a[0, 2] + "\t" + a[0, 3] + "\t" + a[0, 4] + "\t" + a[0, 5] + "\n" + +a[1, 0] + "\t" + a[1, 1] + "\t" + a[1, 2] + "\t" + a[1, 3] + "\t" + a[1, 4] + "\t" + a[1, 5] + "\n" + +a[2, 0] + "\t" + a[2, 1] + "\t" + a[2, 2] + "\t" + a[2, 3] + "\t" + a[2, 4] + "\t" + a[2, 5]);
            Console.ReadLine();
        }
    }
}
