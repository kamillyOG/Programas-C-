using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, mediap;
            Console.WriteLine("Digite a primeira nota:");
            nota1=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2=double.Parse(Console.ReadLine());
            mediap= (nota1*2 + nota2*3)/(2+3);
            Console.WriteLine(" A média ponderada das notas é {0}", mediap);


        }
    }
}
