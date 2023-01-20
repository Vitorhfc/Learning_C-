using System;
class Aula12_13
{
    static void Main()
    {
        Random rd = new Random();
        int x = rd.Next(0, 200);

        if (x >= 100)
        {
            Console.WriteLine("O valor é maior ou igual a que 100. \n O valor é " + x);
        }
        else
        {
            Console.WriteLine("O valor é menor do que 100. \n O valor é " + x);
        }
    }
}