using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_49
{
    static void Main(string[] args)
    {
        double v_pi= math.pi;
        int v = 10;
        Console.WriteLine("v1: " + v);
        v = math.dobro(v);
        Console.WriteLine(v);
        Console.WriteLine(math.dobro(v_pi));
        Console.Read();
        
    }
}
class math
{
    public static double pi = 3.14;

    public static int dobro(int n) { return n * 2; }
    public static double dobro(double n) { return n * 2; }
}