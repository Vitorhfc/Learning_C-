using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor da classe BASE");
    }
}
class Derivada1:Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe derivada 1");
    }
}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe derivada 2");
    }
}
class Aula_37
{
    static void Main(string[] args)
    {
        Derivada2 derivada2 = new Derivada2();
        Console.ReadLine();
    }
}
