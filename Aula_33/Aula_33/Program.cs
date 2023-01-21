using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_33
{
    class Banco
    {
        private int Senha_do_banco = 4875320;
        private string email_do_banco = "Rodolfo_Pariz@gmail.com";

        private object[,] user = new object[,] { { 123512313, 213512341, 12331231 } , { "rodolfo_01@gmail.com", "rf_rodolfão@gmail.com", "Rg_pariz@gmail.com" } };

        public int verificação(int senha_us, string email_us)
        {
            int resposta = 0;
            Console.WriteLine("");
            if (senha_us == Senha_do_banco && email_us == email_do_banco) { resposta = 1; }
            else if(senha_us == Senha_do_banco || email_us == email_do_banco) { resposta = 2; }
            else { resposta = 3; }
            return resposta;
        }

        public void retorna()
        {
            Console.WriteLine(user[1,0] +" - " + user[0,0]);
            Console.WriteLine(user[1, 1] + " - " + user[0, 1]);
            Console.WriteLine(user[1, 2] + " - " + user[0, 2]);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bem vindo ao sistema de gerenciamento de suas senhas\n\n");
            inicio:
            Console.Write("Informe seu email:\t"); string email = Convert.ToString(Console.ReadLine());
            Console.Write("Informe a senha do email:\t"); int senha = int.Parse(Console.ReadLine());
            Banco banco = new Banco();
            int resposta = banco.verificação(senha, email);

            if(resposta == 3) { Console.Clear(); Console.Write("valores errados\n\n\n");  goto inicio; }
            else if(resposta == 2) { Console.Clear(); Console.Write("Senha ou email incorretos\n\n\n"); goto inicio;}
            else if (resposta == 1) { banco.retorna(); }


            Console.ReadLine();
        }
    }
}
