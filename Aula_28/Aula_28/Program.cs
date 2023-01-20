using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28
{

    class Jogador
    {
        public int nex = 50;
        public int pv_total = 20;
        public int pe_total = 100;
        public bool vivo = true;
        public bool morrendo = false;
        public int pe_atual = 80;
        public int pv_atual = 18;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();           
            
 
            Console.Write("Ficha do jogador \n" +
                "nome:\t Walace \n" +
                "nex: \t{1}" +
                "Pontos de vida:\t {2}/{3}\n" +
                "Pontos de esforço:\t {4}/{5}", j1.nex, j1.pv_atual, j1.pv_total, j1.pe_atual, j1.pv_total);
            Console.ReadLine();

        }
    }
}
