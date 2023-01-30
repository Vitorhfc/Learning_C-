using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> Nova_Lista = new List<string>();  //cria List 1
            List<string> Nova_Lista2 = new List<string>();  //cria List 2

/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Gerando lista");
            Nova_Lista.Add("Azul");         //Adiciona valor
            Nova_Lista.Add("Roxo"); Nova_Lista.Add("Preto");Nova_Lista.Add("Cinza");Nova_Lista.Add("Branco");
            Nova_Lista.Add("Rosa");Nova_Lista.Add("Vermelho");Nova_Lista.Add("Verde");Nova_Lista.Add("Ciano");        
            Nova_Lista.Add("Laranja");Nova_Lista.Add("Amarelo");
            foreach (string x in Nova_Lista) { Console.WriteLine(x); } //exibe conteudo de Nova_Lista

            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Passando de uma lista para outra o conteudo");
            Nova_Lista2.AddRange(Nova_Lista); //Passa para Nova_Lista2, todo o conteudo da lista 1
            Console.WriteLine("Conteudo da lista 2 recebido da lista 1");
            foreach (string x in Nova_Lista2) { Console.WriteLine(x); } //exibe conteudo de Nova_Lista2
            
            Nova_Lista2.Clear();    //Limpa a lista inteira
            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Consultando a existencia de um elemento");
            Console.Write("Entre com uma cor:\t");string cor = Convert.ToString(Console.ReadLine());
            if (Nova_Lista.Contains(cor))
            /*Verifica a existencia do elemento em na lista e retorna veradeiro caso exista, e falso caso não exista*/
            {
                Console.WriteLine("A cor escolhida consta na lista");
            }
            else 
            {
                erro_de_entrada:
                Console.WriteLine("A cor escolhida nao consta na lista, \n deseja adicionala ? [s/n]");
                string op2 = Convert.ToString(Console.ReadLine());
                if (op2 == "")
                {
                    goto final;
                }
                else if (op2 == "s" || op2 == "S")
                {
                    Nova_Lista.Add(cor); //adiciona elemento na lista
                    Console.WriteLine("Cor adicionada");
                }
                else if (op2 == "n" || op2 == "N")
                {
                    Console.WriteLine("Cor não adicionada");
                }
                else { Console.WriteLine("Entrada inválida"); goto erro_de_entrada; }
            }

            foreach (string x in Nova_Lista) { Console.WriteLine(x); } //exibe conteudo de Nova_Lista
            final:
            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Passando uma lista para um array");
            string[] Nova_Lista3 = new string[Nova_Lista.Count()];
            Nova_Lista.CopyTo(Nova_Lista3); //Passando para um array o conteudo
            Console.WriteLine("Recebendo em um array");
            foreach (string x in Nova_Lista3) { Console.WriteLine(x); } //exibe conteudo de Nova_Lista


            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("retornando o valor do indice");
            reentrada:
            Console.Clear();
            Console.Write("Entre com uma cor para verificar a posição dela:\t"); cor = Console.ReadLine();
            int posição = Nova_Lista.IndexOf(cor);  //retorna a primeira posição em que o elemento aparece
            if(posição == -1) { Console.WriteLine("Entrada de nome inválida, cor não consta na lista"); }
            else
            {
                Console.WriteLine(posição);
            }

            Console.WriteLine("Verificar outra ? [s/n]");
            string op = Convert.ToString(Console.ReadLine());
            if (op == "")
            {
                goto final;
            }
            else if (op == "s" || op == "S")
            {
                goto reentrada;
            }
            else if (op == "n" || op == "N")
            { Console.Clear();
            }
        }
    }
}
