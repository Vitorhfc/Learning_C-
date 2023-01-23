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

    virtual public void info() { Console.WriteLine("base"); }
}
class Derivada1 : Base
{
    override public void info() { Console.WriteLine("derivada 1"); }
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe derivada 1");
    }
}
class Derivada2 : Derivada1
{
    override public void info() { Console.WriteLine("derivada 2"); }
    public Derivada2()
    {
        Console.WriteLine("Construtor da classe derivada 2");
    }
}
class Aula_38
{
    static void Main(string[] args)
    {
        Base Ref;
        Derivada2 derivada1 = new Derivada2();
        Derivada2 derivada2 = new Derivada2();
        Console.ReadLine();
        Ref = derivada2;
        Ref.info();
        Console.ReadLine();
    }
}
