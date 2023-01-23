using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_44
{
    static void Main(string[] args)
    {
        carro c1= new carro("Forde", "Fiesta", "Dourado");


        carro c2;

        c2.marca    = "Wolks";
        c2.modelo   = "Golf";
        c2.cor      = "Rosa";


        Console.WriteLine(c1.marca);
        Console.WriteLine(c1.modelo);
        Console.WriteLine(c1.cor);
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine(c2.marca);
        Console.WriteLine(c2.modelo);
        Console.WriteLine(c2.cor);

        Console.ReadLine();
    }
}

struct carro
{
    public string marca, modelo, cor;

    public carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}
