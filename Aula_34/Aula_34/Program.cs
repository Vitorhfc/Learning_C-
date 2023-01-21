using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34
{
    class global_1
    {
        public void Main2()
        {
            string v = "deu certo";
            Console.WriteLine(v);
        }
    }

    internal class Program
    {
        public void Main()
        {
            
            global_1 z = new global_1();
            z.Main2();
        

        }
    }
}
