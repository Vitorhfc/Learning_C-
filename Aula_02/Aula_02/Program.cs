using System;

namespace Projeto_01
{    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrando argumentos de um array");

            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }
            else
            {
                Console.WriteLine("Array vazio.");
            }
        }
    }
}