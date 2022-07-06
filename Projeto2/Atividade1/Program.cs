using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, sub;

            Console.WriteLine("Digite o primeiro número:");
            num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2=double.Parse(Console.ReadLine());
            sub = num1- num2;

            Console.WriteLine("A subtração dos números é igual a {0}", sub);


        }
    }
}