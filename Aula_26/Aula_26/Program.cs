using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26
{
    internal class Program
    {
        static void Main()
        {
            int operador;
            int[] Valores = new int[2]; 
            Console.WriteLine("informe o valor 1");
            Console.Write("→\t");
            Valores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o valor 1");
            Console.Write("→\t");
            Valores[1] = int.Parse(Console.ReadLine());
            Console.Write('\n');
            erro:
            Console.WriteLine("Informe o operador:");
            Console.Write(" 1 / 2 / 3 →\t");
            operador = int.Parse(Console.ReadLine());
            if (operador != 1 && operador != 2 && operador != 3)
            {
                Console.WriteLine("erro");
                goto erro;
            }
            if (operador == 1)
            {

            }
            if (operador == 2)
            {
                Multiplicação_3(ref Valores[0], Valores[1]);
                Console.WriteLine("Resposta é: " + Val_1);
            }
            if (operador == 3)
            {

                int res = Multiplicação_2(Valores);
                Console.WriteLine("Resposta é: " + res);
            }
            Console.ReadLine();
        }
        static void Multiplicação_1(int a, int b)
        {

        }
        static void Multiplicação_2(ref int a, int b)
        {
            a = a * b;
        }
        static int Multiplicação_3(int a, int b)
        {
            int res=0;
            res = a * b;
            return res;
        }
    }
}
