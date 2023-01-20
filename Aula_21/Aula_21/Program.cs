using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 6167, senhauser, tentativas = 0;
            do
            {
                Console.Clear();
                tentativas++;
                Console.WriteLine("Insira sua senha");
                senhauser = int.Parse(Console.ReadLine()); 
                
            }while( senha != senhauser && tentativas != 2 );

            if (senha == senhauser)
            {
                Console.WriteLine("Acesso permitido");
                Console.ReadLine();
            }
            if (tentativas == 2)
            {
                Console.WriteLine("Acesso negado");
                Console.ReadLine();
            }
            

        }
    }
}
