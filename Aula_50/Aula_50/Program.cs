using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_50
{
    static void Main(string[] args)
    {
        int soma, mult, dobro;
        OP del_1 = new OP(math.soma);
        soma = del_1(1,2);
        Console.WriteLine("soma: "+soma);

        Console.ReadLine();
        Console.Clear();


        del_1 = new OP(math.mult);
        mult = del_1(10, 20);
        Console.WriteLine("mult: " + soma);


        Console.ReadLine();
    }
}

delegate int OP(int v1, int v2) ;

class math
{
    public static int soma(int v1, int v2) { return v1+v2; }
    public static int mult(int v1, int v2) { return v1*v2; }
}
