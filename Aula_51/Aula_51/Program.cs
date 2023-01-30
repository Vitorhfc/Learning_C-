using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_51
{
    static void Main(string[] args)
    {
        int a, b, c;
        a = b = c = 0;
        a = 10;
        b = 0;

        try
        {
            c = a / b;
            Console.Write(c);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Source);
            Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.GetType());
            Console.Write("ERRO!!!!!!!!!!");
        }




        Console.ReadLine();
    }

}
