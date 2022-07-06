using System;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariomin, salario, x;
            Console.WriteLine("Digite o valor do salario minimo:");
            salariomin= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do salario:");
            salario= double.Parse(Console.ReadLine());
            x= salario/salariomin;
            Console.WriteLine("{0} é a quantidade de salario minimo recebido por este funcionario", x);
        }
    }
}
