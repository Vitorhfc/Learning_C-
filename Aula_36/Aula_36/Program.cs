using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_36
{
    class Veiculo
    {
        public int velAtual;
        private int velMax;
        protected bool Ligado;
        public string nome;


        public Veiculo(string nome, int velMax)
        {
            velAtual = 0;
            this.velMax= velMax;
            Ligado = false;
            this.nome = nome;
        }
        public int getVelMax()
        {
            return velMax;
        }
    }
    internal class Carro:Veiculo
    {
        public Carro(string nome, int velMax) : base(nome,velMax)
        {
            Ligado = true;

        }
        public bool getLigado()
        {
            return Ligado;
        }


    }
    class Aula36
    {
        static void Main()
        {
            Carro carro = new Carro("bonitão", 120);
            Console.WriteLine("Nome.................: " + carro.nome);
            Console.WriteLine("Velocidade maxima....: " + carro.nome);
        }
        
    }
}
