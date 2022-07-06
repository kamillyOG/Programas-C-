using System;

namespace Atv9
{
    class Program
    {
        static void Main(string[] args)
        {
             double raio, area, pi;
        Console.WriteLine("Digite o raio da circuferencia:");
        raio= double.Parse(Console.ReadLine());
         pi=3.14159;
        area= pi* Math.Pow(raio,2);
        Console.WriteLine("A={0}", area);
            }
        }
    }
}
