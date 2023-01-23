using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_42
{
    static void Main(string[] args)
    {
    incio:
        Carro car = new Carro();

        for (int i = 0; i < car.contagem(); i++)
        {
            Console.Write("informe o velocidade:\t");
            car[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < car.contagem(); i++)
        {
            Console.Write("informe o velocidade:\t");
            Console.WriteLine("velocidade do Carro: \t" + car[i]);
            Console.WriteLine("Estado do carro: \t" + car.estado_do_carro);
        }
    tentar_novamente:
        Console.WriteLine("\n Deseja tentar novamente: [s] [n]");
        string resposta = Convert.ToString(Console.ReadLine());
        if (resposta == "s" || resposta == "S") { goto incio; }
        else if (resposta == "n" || resposta == "N") { }
        else { Console.WriteLine("Valor incorreto para a pergunta "); goto tentar_novamente; }

    }
}

class Carro
{
    private int[] velMax = new int[5];
    public int contagem()
    {
        int tama_array = velMax.Length;
        return tama_array;
    }

    public string estado_do_carro;
    public int this[int i]
    {
        get { return velMax[i]; }
        set
        {
            if (value < 0)
            {
                velMax[i] = 0;
                estado_do_carro = "Desligado";
            }
            else if (value > 300)
            {
                velMax[i] = 300;
                estado_do_carro = "ligado";
            }
            else
            {
                velMax[i] = value;
                estado_do_carro = "ligado";
            }
        }
    }
}
