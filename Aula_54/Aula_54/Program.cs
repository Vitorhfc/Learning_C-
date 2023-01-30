using Aula_54;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_1
{
    internal class area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0) { throw new Exception("Os valores da base ou da altura não podem ser zero"); };
            return bas * alt;
        }
    }
}

namespace Aula_54
{
    public class principal
    {
        
        static void Main()
        {
            inicio:
            Console.Clear();
            float perimetro=0 ,area = 0;
            Console.Write("informe valor 1:\t");
            var val_1 = float.Parse(Console.ReadLine());
            Console.Write("informe valor 2:\t");
            var val_2 = float.Parse(Console.ReadLine());
            try
            {
                area = projeto_1.area.Quad(val_1, val_2);
                perimetro = projeto_2.area.Quad(val_1, val_2);
                Console.WriteLine("area do quadrado:\t " + area);
                Console.WriteLine("perimetro do quadrado:\t " + perimetro);
            }
            catch (Exception e) 
            {
                Console.WriteLine("ERRO:\t" + e.Message);
            }
            finally { Console.WriteLine("Fim do processo"); Console.ReadLine(); }
            tentar_novamente:
            Console.Clear();
            Console.WriteLine("Tentar novamente?");
            var op = Convert.ToString(Console.ReadLine());
            if (op == "s" || op == "S") { goto inicio; }
            else if(op == "n" || op == "N") {  }
            else { Console.WriteLine("ERRO");goto tentar_novamente; }
        }
    }
}

namespace projeto_2
{
    internal class area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0) { throw new Exception("Os valores da base ou da altura não podem ser zero"); };
            return (bas*2)+(alt*2);
        }
    }
}