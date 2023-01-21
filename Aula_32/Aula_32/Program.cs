using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aula_32
{
    class Calcular
    {
        double valor_1, valor_2,res;
        int op;
        public void programa_principal()
        {
            Console.WriteLine("informe qual operação deseja realizar");
            Console.WriteLine("[+ = 1] [- = 2] [x = 3] [÷ = 4]");
            Console.Write("→\t");
            this.op = int.Parse(Console.ReadLine());

            Console.Write("Informe o primeiro valor:\t ");
            this.valor_1= double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor:\t ");
            this.valor_2= double.Parse(Console.ReadLine());

            direcionador();

        }
        public void direcionador()
        {
            if (this.op == 1) { adição(); }
            else if (this.op == 2) { subtração(); }
            else if (this.op == 3) { multiplicação(); }
            else if (this.op == 4) { Divisão(); }
            else
            {
                Console.WriteLine("Valor inválido");
                programa_principal();
            }
        }
        public void adição()
        {
            this.res = this.valor_1 + this.valor_2;
            exibição();
        }
        public void subtração()
        {
            this.res = this.valor_1 - this.valor_2;
            exibição();
        }
        public void multiplicação()
        {
            this.res = this.valor_1 * this.valor_2;
            exibição();
        }
        public void Divisão()

        {
            this.res = this.valor_1 / this.valor_2;
            exibição();
        }

        public void exibição()
        {
            Console.Write("O resultado da operação foi:\t" + this.res);
            Console.ReadLine();
        }
    }
    class Programa_incial
    {
        static public void Main()
        {
            Calcular c = new Calcular();
            c.programa_principal();

        }
    }
}
