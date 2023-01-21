using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_31
{

    static public class Jogador
    {
        static public string classe;
        static public string nome;
        static public int nex;
        static public int pv_total;
        static public int pe_total;
        static public int pe_atual;
        static public int pv_atual;
        static public bool vivo;
        static public bool morrendo;


        static public void iniciar(string n, int p_v, int p_e, string cls)
        {
            classe      = cls;
            nex         = 50;
            pv_total    = 50;
            pe_total    = 80;
            pe_atual    = p_e;
            pv_atual    = p_v;
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
            nome = n;
        }

        static public void info()
        {
            Console.WriteLine("Ficha do jogador \n" +
            "nome:\t {0} \n" +
            "nex: \t{1} \n" +
            "Pontos de vida:\t {2}/{3}\n" +
            "Pontos de esforço:\t {4}/{5}\n" +
            "Estado : Vivo : {6} → Morrendo : {7}", nome, nex, pv_atual, pv_total, pe_atual, pv_total, vivo, morrendo);
        }
    }



    internal class hub
    {
        static void Main()
        {
            Console.WriteLine("Sistema de gerenciamento de pontos rpg \n Sistema : Ordem Paranormal");
            Jogador.iniciar("Walace", 80, 20, "Combatente");
            Jogador.info();
            Console.ReadLine();
        }
    }
}

