using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_48
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fatorial");
        int v;
        v = 8;

        int x = fatorial(v);

        Console.WriteLine(x);
        Console.ReadLine();
    }

    static int fatorial(int a)
    {
        if ( a <= 1 ) { return 1; }
        else if (a > 1) { return a * fatorial(a - 1); }
        else { return 0; }
    }
}
