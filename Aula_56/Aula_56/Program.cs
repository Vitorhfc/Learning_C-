using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_56
{
    internal class Lista
    {
        static void Main(string[] args)
        {
            LinkedList<string> Lista_de_compra = new LinkedList<string>();




            Lista_de_compra.AddLast("Feijão");
            Lista_de_compra.AddLast("Leite");
            Lista_de_compra.AddLast("Bacon");
            Lista_de_compra.AddLast("Presunto");
            Lista_de_compra.AddLast("Queijo");

            LinkedListNode<string> nó;
            nó = Lista_de_compra.Find("Leite");
            Lista_de_compra.AddFirst("Arroz");                  //adiciona primeiro
            Lista_de_compra.AddLast("Maça");                    //adiciona por último
            Lista_de_compra.AddAfter(nó,"Café");                //adiciona por depois do nó criado
            Lista_de_compra.AddBefore(nó, "Refrigerante");      //adiciona antes do elemento criado


            foreach(string t in Lista_de_compra) { Console.WriteLine(t); }

            Console.ReadLine();
            if (Lista_de_compra.Find("Macarrão") == null) { Console.WriteLine("Macarrão não está na lista de compra"); }
            else { Console.WriteLine("Macarrão está na lista de compra"); }
            foreach (string t in Lista_de_compra) { Console.WriteLine(t); }

            Console.ReadLine();
            Console.Clear(); 
            foreach (string t in Lista_de_compra) { Console.WriteLine(t); }
            Console.WriteLine("\n \t removendo elementos....\n");
            Lista_de_compra.RemoveFirst();
            Lista_de_compra.RemoveLast();
            Lista_de_compra.Remove("café");

            foreach (string t in Lista_de_compra) { Console.WriteLine(t); }
            Console.ReadLine();
            Lista_de_compra.Clear();
            Console.ReadLine();

        }
    }
}
