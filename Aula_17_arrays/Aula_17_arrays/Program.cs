using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_17_arrays
{
    internal class Program
    {
        static void Main()
        {
            inicio:

            string[] a= new string[7];
            a[0] = "Domingo";
            a[1] = "Segunda";
            a[2] = "Terça";
            a[3] = "Quarta";
            a[4] = "Quinta";
            a[5] = "Sexta";
            a[6] = "Sabado";

            Console.WriteLine("Informe o dia da semana que você deseja saber o nome: \t");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                case 0:
                    Console.WriteLine(a[0]);
                    break;
                case 2:
                    Console.WriteLine(a[1]);
                    break;
                case 3:
                    Console.WriteLine(a[2]);
                    break;
                case 4:
                    Console.WriteLine(a[3]);
                    break;
                case 5:
                    Console.WriteLine(a[4]);
                    break;
                case 6:
                    Console.WriteLine(a[5]);
                    break;
                case 7:
                    Console.WriteLine(a[6]);
                    break;
                default:
                    Console.WriteLine("erro");
                    goto inicio;
                    break;
            }
            Console.WriteLine("tentar novamente? [s/n]\n→\t");
            char ver = char.Parse(Console.ReadLine());
            if( ver == 's' || ver == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.ReadLine();
            }



        }
    }
}
