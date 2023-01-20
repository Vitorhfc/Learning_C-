using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:

            Console.WriteLine("escolha qual calculadora:");
            Console.WriteLine("→ \t Calculadora fatorial =[1]");
            Console.WriteLine("→ \t Gerador de tabuada   =[2]");
            int direcionador = int.Parse(Console.ReadLine());

            if(direcionador == 1)
            {
                goto Calculadora_Fatorial;
            }
            if(direcionador == 2)
            {
                goto Gerador_de_tabuada;
            }

            Calculadora_Fatorial:
            int num,x;int a = 0;
            Console.Write("\tCalculando fatorial\n Informe o valor desejado:\t ");
            num = int.Parse(Console.ReadLine());
            for (x = num; x != 0; x--) {
                a++;
                num = num * (num - 1);
                Console.WriteLine("Posição " + a + " →\t" + num);
                }
            goto fim;

            Gerador_de_tabuada:
                int[] var = new int[10];
                Console.WriteLine("Qual valor deseja trabalhar?");
                int valor = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("tabuada do "+valor);
                Console.WriteLine();
                for (int i = 0; i < 10; i++){
                        var[i] = (i+1)*valor;
                        Console.WriteLine(var[i]); 
                     }
                goto fim;


            fim:
                Console.WriteLine("Deseja voltar ao inicio ou sair do programa? [1 = inicio || 2 = Sair]");
                direcionador = int.Parse(Console.ReadLine());
                if (direcionador != 1 && direcionador != 2)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção válida");
                    goto fim;
                }
                if (direcionador == 1)
                {
                    Console.Clear();
                    goto Inicio;
                }
                if (direcionador == 2)
                {
                    Console.ReadLine();
                }
        }
    }
}
