using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
class Carro_Base
{
    public int Velocidade_Maxima_Carro, rodas;
    private bool Ligado;
    public string nome, cor, tipo_veiculo, carteira;

    public void ligar()
    {
        Ligado = true;
    }
    public void Numero_rodas_e_vmax()
    {
        if (tipo_veiculo == "moto" || tipo_veiculo == "Moto") { this.rodas = 2; this.Velocidade_Maxima_Carro = 280; this.carteira = "A"; }
        else if (tipo_veiculo == "carro" || tipo_veiculo == "Carro") { this.rodas = 4; this.Velocidade_Maxima_Carro = 240; this.carteira = "B"; }
        else { this.rodas = 0; this.tipo_veiculo = "inválido"; this.Velocidade_Maxima_Carro = 0; this.carteira = null; }

    }
    public void Desligar()
    {
        Ligado = false;
    }
    public String getLigado()
    {
        if (Ligado) { return "sim"; }
        else { return "não"; }
    }
}

class Carro : Carro_Base
{

    public Carro(string nome,string tipo_veiculo, string cor)
    {
        this.nome = nome;
        this.tipo_veiculo = tipo_veiculo;
        this.cor = cor;
        Desligar();
        Numero_rodas_e_vmax();
    }
}

class Aula_35
{
    static void Main()
    {
        Console.Write("Nome veiculo:\t");
        string x = Console.ReadLine();
        Console.Write("tipo veiculo:\t");
        string v = Console.ReadLine();
        Console.Write("Cor:\t");
        string c = Console.ReadLine();



        Carro c1 = new Carro(x, v, c);

        Console.WriteLine(c1.nome);
        Console.WriteLine(c1.cor);
        Console.WriteLine(c1.Velocidade_Maxima_Carro);
        Console.WriteLine(c1.rodas);
        Console.WriteLine(c1.getLigado());


        Console.ReadLine();
    }
}
