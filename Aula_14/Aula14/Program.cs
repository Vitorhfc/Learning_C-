using System;
class aula14
{
    static void Main()
    {
        double n1, n2, n3, n4, n5 = 0;
        int Ma = 1;
        int Ne1, Ne2, Ne3;
        Console.WriteLine("informe as 5 notas do aluno:");
        Console.Write("nota 1→\t");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nota 2→\t");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nota 3→\t");
        n3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nota 4→\t");
        n4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nota 5→\t");
        n5 = Convert.ToDouble(Console.ReadLine());


        //Ne1 =< Ma → aprovado
        //Ne3 > Ma → APROVADISSIMO
        //Ne1 > Ma && Ne2 =< Ma → recuperação
        //Ne2 > Ma → Reprovado


        Console.WriteLine("Qual a nota minima para aprovação?");
        Ne1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a nota minima para recuperação?");
        Ne2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a nota minima para aprovação com louvor?");
        Ne3 = int.Parse(Console.ReadLine());

        Ma = (int)(n1 + n2 + n3 + n4 + n5) / 5;

        if (Ma >= Ne1)
        {
            if (Ma >= Ne3)
            {
                Console.WriteLine("Aluno aprovado com louvor, Nota:\t" + Ma);
            }
            else
            {
                Console.WriteLine("Aluno aprovado, Nota:\t" + Ma);
            }
        }
        if (Ma < Ne1 && Ma >= Ne2)
        {
            Console.WriteLine("Aluno em recuperação, Nota:\t" + Ma);
        }
        if (Ma < Ne2)
        {
            Console.WriteLine("Aluno reprovado, Nota:\t" + Ma);
        }
    }
}