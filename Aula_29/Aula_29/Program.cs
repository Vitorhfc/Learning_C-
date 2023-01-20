using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_29
{

    class Jogador
    {
        public int nex;
        public int pv_total;
        public int pe_total ;
        public int pe_atual;
        public int pv_atual;
        public bool vivo;
        public bool morrendo;
        public string nome;

        public Jogador(string nom) {
            nex= 50;
            pv_total = 50;
            pe_total = 80;
            pe_atual = 65;
            pv_atual = 10;
            vivo = true;
            morrendo = false;
            nome = nom;
        }
        ~Jogador() { Console.WriteLine("Descontrutor"); }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            string n = "Walace";
            Jogador j1 = new Jogador(n);
            Console.Write("Ficha do jogador \n" +
                "nome:\t {0} \n" +
                "nex: \t{1} \n" +
                "Pontos de vida:\t {2}/{3}\n" +
                "Pontos de esforço:\t {4}/{5}", j1.nome,j1.nex, j1.pv_atual, j1.pv_total, j1.pe_atual, j1.pv_total);
            

        }
    }
}
