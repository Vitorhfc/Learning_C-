using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d_Ataques= new Dictionary<int, string>();

            d_Ataques.Add(1 ,"Espadada");
            d_Ataques.Add(2, "Fire_ball");
            d_Ataques.Add(3, "Raio de ácido");
            d_Ataques.Add(4, "Raio de fogo");
            d_Ataques.Add(5, "Raio de frio");
            d_Ataques.Add(6, "Mãos flamejantes");

            // d_Ataques.Clear(); limpar
            
            Console.WriteLine(d_Ataques.Count());

            int chave = 6;
            if (d_Ataques.ContainsKey(chave)) { Console.WriteLine("chave existe"); }
            else { Console.WriteLine("Chave n existe"); }

            string chave_2 = "Mãos flamejantes";
            if (d_Ataques.ContainsValue(chave_2)) { Console.WriteLine("elemento existe"); }
            else { Console.WriteLine("elemento n existe"); }

            foreach (KeyValuePair<int, string> v in d_Ataques) { Console.WriteLine(v.Key +"\t"+ v.Value); }

            for(int i = d_Ataques.Count(); i > 0; i--)
            {
                foreach (KeyValuePair<int, string> v in d_Ataques) { Console.WriteLine(v.Key + "\t" + v.Value); }
                d_Ataques.Remove(i);
            }


            




        }
    }
}
