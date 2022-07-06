using System;

namespace Atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1,num2;
            Console.WriteLine("Digite um número");
            num1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            num2= double.Parse(Console.ReadLine());
            if (num1>num2) {
                    Console.WriteLine("{0} é o maior número", num1);
            } else {
                    Console.WriteLine("{0} é o maior número", num2);
            }
        }
    }
}
