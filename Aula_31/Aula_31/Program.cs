using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31
{

    class Jogador
    {
        public string classe;
        public int nex;
        public int pv_total;
        public int pe_total;
        public int pe_atual;
        public int pv_atual;
        public bool vivo;
        public bool morrendo;
        public string nome;

        public Jogador(string nom, int x)
        {
            classe = "Combatente";
            nex = 20;
            pv_total = 40;
            pe_total = 10;
            pe_atual = 10;
            pv_atual = x;
            if (pv_atual < (pv_atual + (pv_total * 100)))
            {
                morrendo = true;
                if (pv_atual <= 0)
                {
                    vivo = false;
                }
                else
                {
                    vivo = true;
                }
            }
            else if (pv_atual > (pv_atual + (pv_total * 100)))
            {
                vivo = true;
                morrendo = false;
            }
            nome = nom;
        }

        public Jogador(string nom, int x, int pe)
        {
            classe = "ocultista";
            nex = 50;
            pv_total = 50;
            pe_total = 80;
            pe_atual = pe;
            pv_atual = x;
            if (pv_atual < (pv_atual + (pv_total * 100)))
            {
                morrendo = true;
                if (pv_atual <= 0)
                {
                    vivo = false;
                }
                else
                {
                    vivo = true;
                }
            }
            else if (pv_atual > (pv_atual + (pv_total * 100)))
            {
                vivo = true;
                morrendo = false;
            }
            nome = nom;
        }
        ~Jogador() { Console.WriteLine("Metodo Destruidor"); Retorno(); }

        public void Retorno()
        {
            Console.Write("Bom jogo");
            Console.ReadLine();
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de gerenciamento de pontos rpg \n Sistema : Ordem Paranormal");
            string n = "Walace";
            Jogador j1 = new Jogador(n, 30);
            Console.WriteLine("Ficha do jogador \n" +
                "nome:\t {0} \n" +
                "nex: \t{1} \n" +
                "Pontos de vida:\t {2}/{3}\n" +
                "Pontos de esforço:\t {4}/{5}\n" +
                "Estado : Vivo : {6} → Morrendo : {7}", j1.nome, j1.nex, j1.pv_atual, j1.pv_total, j1.pe_atual, j1.pv_total, j1.vivo, j1.morrendo);

            Jogador j2 = new Jogador("Garry", 1, 40);
            Console.WriteLine("Ficha do jogador \n" +
                "nome:\t {0} \n" +
                "nex: \t{1} \n" +
                "Pontos de vida:\t {2}/{3}\n" +
                "Pontos de esforço:\t {4}/{5}\n" +
                "Estado : Vivo : {6} → Morrendo : {7}", j2.nome, j2.nex, j2.pv_atual, j2.pv_total, j2.pe_atual, j2.pv_total, j2.vivo, j2.morrendo);
            Console.ReadLine();

        }
    }
}
