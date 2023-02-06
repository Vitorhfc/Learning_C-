using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Academia
{
    internal class Globais
    {
        public static string VersaoPrograma = "1.0";
        public static Boolean logado = false;
        public static int nivel = 1;

        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "Banco.db";
        public static string CaminhoBanco = caminho + @"\banco\";

        //Nivel  1 = base ; 2 = gerente; 3 = Master;
    }
}
