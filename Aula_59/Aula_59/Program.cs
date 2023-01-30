using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Cyan;

            Queue<string> queue = new Queue<string>(); //criação queue

            //Colocando valores na queue
            queue.Enqueue("Azul"); queue.Enqueue("Vermelho"); queue.Enqueue("Preto"); queue.Enqueue("Branco"); queue.Enqueue("Cinza");

            //verificando a existencia de um valor na queue
            //Contains retorna verdadeiro caso exista o elemento na queue, e , falso caso nao exista;
            if (queue.Contains("Preto")) { Console.WriteLine("Elemento existente na queue \n\n"); }
            else { Console.WriteLine("Veiculo não existente\n\n"); }

            //Zera a queue
            //queue.Clear();
            Console.WriteLine("QUANTIDADE DE ELEMENTOS NA QUEUE: {0} \n\n",queue.Count); //contagem de elemtno queue

            //Dequeue Retorna o primeiro elemento da fila e depois o elimina
            Console.WriteLine("Primeiro elemento:\t" + queue.Dequeue() +"\n\n");

            Console.WriteLine("QUANTIDADE DE ELEMENTOS NA QUEUE: {0} \n\n", queue.Count);//contagem de elemtno queue

            //Dequeue Retorna o primeiro elemento da fila porem não o elimina
            Console.WriteLine("Primeiro elemento:\t" + queue.Peek() + "\n\n");



            Console.WriteLine("QUANTIDADE DE ELEMENTOS NA QUEUE: {0} \n\n", queue.Count);//contagem de elemtno queue

            //Zerando porem mostrando todos os elementos da QUEUE
            while (queue.Count > 0) { Console.WriteLine("Elemento : "+ queue.Dequeue()); }

            Console.WriteLine("QUANTIDADE DE ELEMENTOS NA QUEUE: {0} \n\n", queue.Count);//contagem de elemtno queue



            Console.ReadLine();
        }
    }
}
