using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_24
{
    static void Main()
    {
        int i = 0,a=1,r;
        while (i < 10)
        {
            r = Metodo1(i, a);
            
            Console.WriteLine(Metodo1(i, a));
            i = r;
        }
        Console.ReadLine();
    }
    static int Metodo1(int a, int b)
    {
        int[] n = new int[2] {a,b};

        int r= n[0] + n[1];
        
        return r;
        
        
    }
}
