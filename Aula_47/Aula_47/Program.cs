using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_47
{
    static void Main(string[] args)
    {
        
        int[] n = new int[15];

        Calcular calcular= new Calcular();

        var res = calcular.Soma(46,8);
        Console.WriteLine(res);
        Console.ReadLine();
    }
}

class Calcular
{
    
    public double Soma(params double[]n)
    {
        double r = 0;
        for (int i = 0; i < n.Length; i++)
        {
            r += n[i];
        }
        return r;
    }
    public int Soma(params int[] n)
    {
        int r = 0;
        for (int i = 0; i < n.Length; i++)
        {
            r += n[i];
        }
        return r;
    }
}