using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double id_produto,valor_produto, valor_venda, lucro;
            int contador = 5,y = 1; //numero de notas;
            double[,] resultados = new double[y, 4];

            Console.WriteLine("Sistema de venda");
            Console.WriteLine("Emissão de nota");
            Console.WriteLine();

            while (contador != y)
            {

                Console.Write("Informe o nome do produto:\t");
                id_produto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor do produto:\t");
                valor_produto = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o valor do lucro desejado:\t");
                lucro = Convert.ToDouble(Console.ReadLine());

                valor_venda = (valor_produto * lucro)+ valor_produto;

                resultados[y, 0] = id_produto;
                resultados[y, 1] = valor_produto;
                resultados[y, 2] = lucro;
                resultados[y, 3] = valor_venda;

                y++;
                Console.Write("Deseja adicionar outro produto? S/N");
                string a = Convert.ToString(Console.Read());
                if (a == "s" || a == "S")
                {
                    contador = 4;
                }
                if (a == "n" || a == "N")
                {
                    contador = 2;
                }

            }
            Console.ReadLine();
        }
    }
}
