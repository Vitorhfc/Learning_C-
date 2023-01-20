using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5] { 3,4,5,6,7};
            int[] c = new int[5];
            int[] d = new int[5];
            int[,] matriz = new int[2, 5] { { 00, 11, 22, 44, 55 }, { 66, 77, 88, 99, 00 } };
            
                Random random = new Random(); //gerador de valor aleatorio
                for (int i = 0; i < a.Length; i++) { a[i] = random.Next(10, 5000)/*retorno de valor aleatorio entre 10 e 5000*/; }

                Console.WriteLine("Valores gerados aleatorios\n→\tElementos do vetor: ");
                foreach (int i in a) { Console.WriteLine("Valor vetor : " + i); }

                Console.WriteLine(); Console.WriteLine("------------------------------------------------"); Console.WriteLine();

                Console.WriteLine("Comando BinarySearch Modelo 1\n→\tVetor a");
                int val_procurado = a[2];
                int pos_do_valor = Array.BinarySearch(a, val_procurado);
                Console.WriteLine("A posição do valor {0} é:\t {1}", val_procurado, pos_do_valor);

                Console.WriteLine(); Console.WriteLine("------------------------------------------------"); Console.WriteLine();

                Console.WriteLine("Comando BinarySearch Modelo 2\n→\tVetor b");
                int pos_do_valor2 = Array.BinarySearch(b, 6);
                Console.WriteLine("A posição do valor 6 é:\t {0}", pos_do_valor);
                Console.WriteLine("Elementos do vetor: ");
                foreach (int i in b) { Console.WriteLine("Valor vetor : " + i); }

                Console.WriteLine(); Console.WriteLine("------------------------------------------------"); Console.WriteLine();

                Console.WriteLine("Comando Copy \n→\tVetor c");
                Array.Copy(b, c, c.Length);
                foreach (int i in c) { Console.WriteLine(i); } //Ele prenche o vazio com zero.

                Console.WriteLine(); Console.WriteLine("------------------------------------------------"); Console.WriteLine();

                Console.WriteLine("Comando CopyTo\n→\tVetor d");
                c.CopyTo(d, 0);
                foreach (int i in d) { Console.WriteLine(i); }
                Console.ReadLine();

                Console.WriteLine(); Console.WriteLine("------------------------------------------------"); Console.WriteLine();

            

            int menor_indice_vetor = a.GetLowerBound(0);
            int menor_indice_matriz= matriz.GetLowerBound(1);
            {
                Console.Clear();
                Console.WriteLine("Menor indice do vetor A");
                Console.WriteLine(menor_indice_vetor);
                Console.WriteLine();
                Console.WriteLine("Menor indice da Matriz");
                Console.WriteLine(menor_indice_matriz);
                Console.ReadLine();

                Console.WriteLine(); Console.WriteLine("------------------------------------------------"); Console.WriteLine();

            }











        }
    }
}
