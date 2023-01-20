using System;
class Aula09
{
    static void Main()
    {
        Console.Write("Informe o valor inteiro que deseja trabalhar:\t");
        int val = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor inteiro que deseja usar como divisor ou multiplicador:\t");
        int val_2 = int.Parse(Console.ReadLine());
        Console.Write("Qual operação deseja seguir\n opção A ) >>  →  Divisor\t opção B ) <<  →  Multiplicador\n");
        string operador = Convert.ToString(Console.ReadLine());
        if (operador == "A" ||operador == "a")
        {
            val = val >> val_2;
            Console.WriteLine("");
            Console.Write("o valor é:\t" + val);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        if (operador == "b" || operador == "B")
        {
            val = val << val_2;
            Console.WriteLine("");
            Console.Write("o valor é:\t" + val);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        if (operador != "a" && operador != "A" && operador != "b" && operador != "B")
        {
            Console.WriteLine("Valor Inválido");
        }


        //var a = 100;
        //double b = a >> 5;
        //Console.WriteLine(b);
    }
}