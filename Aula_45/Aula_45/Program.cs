using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_45
{
    static void Main(string[] args)
    {
        /*
        carro c1 = new carro("Fiesta", "Dourado");

        carro c2;

        c2.modelo = "Golf";
        c2.cor = "Rosa";
        */
        carro[,] c3 = new carro [2,2] ;
        c3[0, 0].modelo = "fiesta";
        c3[0, 1].cor = "verde";
        c3[1, 0].modelo = "Golf";
        c3[1, 1].cor = "Rosa";


        /*
        Console.WriteLine(c1.modelo);
        Console.WriteLine(c1.cor);
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(c2.modelo);
        Console.WriteLine(c2.cor);
        Console.Clear();  */
        for (int x = 0; x < 2; x++) { for (int y = 0; y < 2; y++) { Console.WriteLine(c3[x, y]); } }
        Console.ReadLine();
    }
}

struct carro
{
    public string modelo, cor;

    public carro(string modelo, string cor)
    {
        this.modelo = modelo;
        this.cor = cor;
    }
}
