using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula_41
{
    static void Main(string[] args)
    {
    incio:
        Carro car = new Carro();
        Console.Write("informe o velocidade:\t");
        car.vm = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("velocidade do Carro: \t" + car.vm);
        Console.WriteLine("Estado do carro: \t" + car.estado_do_carro);
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
    private int velMax;

    /*
  public int vm3
  {
      get { return velMax; }
  }

  public int vm2
  {
      set
      {
          if (value < 0)
          {
              velMax = 0;
          }
          else if (value > 300)
          {
              velMax = 300;
          }
          else
          {
              velMax = value;
          }
      }
  }
  */
    public string estado_do_carro;
    public int vm
    {
        get { return velMax; }
        set
        {
            if (value < 0)
            {
                velMax = 0;
                estado_do_carro = "Desligado";
            }
            else if (value > 300)
            {
                velMax = 300;
                estado_do_carro = "ligado";
            }
            else
            {
                velMax = value;
                estado_do_carro = "ligado";
            }
        }
    }
}
