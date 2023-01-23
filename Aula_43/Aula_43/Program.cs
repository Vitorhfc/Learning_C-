using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_42
{
  static void Main()
    {
        combates player = new combates();
        Console.WriteLine("Simulador rpg");
        Console.Write("Inform a vida total:\t");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Informe o pe total:\t");
        int e = int.Parse(Console.ReadLine());
        Console.Write("Informe a sua classe:\t");
        string c = Convert.ToString(Console.ReadLine());

    }
}

class combates:persongaem
{
    public P_vidas() { }
    public P_Esforço() { }
    public Estado() { }
    public classe();
}
public interface persongaem
{
    public P_Vidas();
    public P_Esforço();
    public Estado();
    public classe();
}