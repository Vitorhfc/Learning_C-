using System;

namespace Aula_15
{
    internal class Program
    {
        static void Main()
        {
            int verificador = 0;
            Console.WriteLine("Calculadora Simples");
            Console.Write("Primeiro valor: \t");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo valor: \t");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual a operação desejada\n" +
                "Para soma: '1'\t Para subração: '2'\n" +
                "Para multiplicação: '3'\t Para divisão: '4'\n" +
                "Escolha:\t");
            int op = int.Parse(Console.ReadLine());
            double res;
            switch (op) {
                case 1:
                    res = v1 + v2;
                    break;
                case 2:
                    res = v1 - v2;
                    break;
                case 3:
                    res = v1 * v2;
                    break;
                case 4:
                    res = v1 / v2;
                    break;
                default:
                    res = 0;
                    verificador = 1;
                    break;
            }
            if (verificador == 1)
            {
                Console.WriteLine("valor invalido para operação");
            }
            if (verificador == 0)
            {
                Console.WriteLine("O resultado é " + res);
            }

            Console.ReadKey();
        }
    }
}
