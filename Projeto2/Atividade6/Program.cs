using System;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto1,cateto2,hipotenusa, x;
            Console.WriteLine("Digite o valor de um cateto:");
            cateto1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do outro cateto:");
            cateto2= double.Parse(Console.ReadLine());
            x= (cateto1*cateto1) + (cateto2*cateto2);
            hipotenusa=Math.Sqrt(x);
            Console.WriteLine("{0} é o valor da hipotenusa", hipotenusa);
        }
    }
}
