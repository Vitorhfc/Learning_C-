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
            Console.ForegroundColor= ConsoleColor.Yellow;
            List <string> Nova_Lista = new List<string>();  //cria List 1
            List<string> Nova_Lista2 = new List<string>();  //cria List 2

/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Gerando lista");
            Nova_Lista.Add("Azul");         //Adiciona valor
            Nova_Lista.Add("Roxo"); Nova_Lista.Add("Preto");Nova_Lista.Add("Cinza");Nova_Lista.Add("Branco");
            Nova_Lista.Add("Rosa");Nova_Lista.Add("Vermelho");Nova_Lista.Add("Verde");Nova_Lista.Add("Ciano");        
            Nova_Lista.Add("Laranja");Nova_Lista.Add("Amarelo");

/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Inserindo elemento na lista em posição determinada");
            Console.Write("A lista tem atualmente " + Nova_Lista.Count() + ", qual posição vai inserir? : "); int p = int.Parse(Console.ReadLine());
            Console.Write("Qual cor vai inserir: "); string el = Convert.ToString(Console.ReadLine());

            Nova_Lista.Insert(p, el); //inserindo elemento em posição pré determinada pelos seletor p e el
            foreach (string x in Nova_Lista) { Console.WriteLine(x); } //exibe conteudo de Nova_Lista

            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Retornando o ultimo posição de elemento pesquisado");
            Nova_Lista.Add("Azul"); Nova_Lista.Add("Roxo"); Nova_Lista.Add("Preto"); Nova_Lista.Add("Cinza"); Nova_Lista.Add("Branco"); Nova_Lista.Add("Rosa"); Nova_Lista.Add("Vermelho"); Nova_Lista.Add("Verde"); Nova_Lista.Add("Ciano"); Nova_Lista.Add("Laranja"); Nova_Lista.Add("Amarelo");


            Console.Write("Informe um elemento: ");string el2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("A ultima posição: " + Nova_Lista.LastIndexOf(el2));//retorna a ultima posição em que o elemento aparece


            Nova_Lista.Clear(); Nova_Lista.Add("Azul"); Nova_Lista.Add("Roxo"); Nova_Lista.Add("Preto"); Nova_Lista.Add("Cinza"); Nova_Lista.Add("Branco"); Nova_Lista.Add("Rosa"); Nova_Lista.Add("Vermelho"); Nova_Lista.Add("Verde"); Nova_Lista.Add("Ciano"); Nova_Lista.Add("Laranja"); Nova_Lista.Add("Amarelo");
            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Removendo um elemento através do nome");
            Console.Write("Informe um elemento da lista: "); string el3 = Convert.ToString(Console.ReadLine());
            if (Nova_Lista.Contains(el3)) { Console.WriteLine("Elemento " + el3 + " removido;\n\n"); Nova_Lista.Remove(el3); } //removendo elemento
            else { Console.WriteLine("Elemento não existe"); }
            foreach (string x in Nova_Lista) { Console.WriteLine(x); } //exibe conteudo de Nova_Lista

            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Removendo um elemento através do indice");
            Console.Write("Informe um indice de um elemento da lista: "); int v1 = int.Parse(Console.ReadLine());
            if (v1 <= Nova_Lista.Count() && v1 >= 0) { Console.WriteLine("Elemento " + v1 + " removido;\n\n"); Nova_Lista.RemoveAt(v1); } //removendo elemento
            else { Console.WriteLine("Elemento não existe"); }
            foreach (string v in Nova_Lista) { Console.WriteLine(v); } //exibe conteudo de Nova_Lista
            Console.ReadLine();Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Lista normal:");  foreach (string v in Nova_Lista) { Console.WriteLine(v); } //exibe conteudo de Nova_Lista

            Console.ReadLine(); Console.Clear();

            Nova_Lista.Reverse(); //inverte a ordem da lista
            Console.WriteLine("Lista Invertida:"); foreach (string v in Nova_Lista) { Console.WriteLine(v); } //exibe conteudo de Nova_Lista

            Console.ReadLine(); Console.Clear();

            Nova_Lista.Sort(); //Deixa a ordem da lista em ordem alfabetica
            Console.WriteLine("Lista Invertida:"); foreach (string v in Nova_Lista) { Console.WriteLine(v); } //exibe conteudo de Nova_Lista

            Console.ReadLine(); Console.Clear();
/*-------------------------------------------------------------------------------------------------------------------------*/
            int Tamanho = Nova_Lista.Count();
            int capacidade = Nova_Lista.Capacity;

            Console.WriteLine("Tamanho lista:\t" + Tamanho);
            Console.WriteLine("Tamanho lista:\t" + capacidade);



            Console.ReadLine(); Console.Clear();
        }
    }
}
