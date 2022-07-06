using System;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, comprimento,area,volume;
            Console.WriteLine("Digite o raio da esfera:");
            raio= double.Parse(Console.ReadLine());

            comprimento= 2* Math.PI* raio;
            area= Math.PI * Math.Pow(raio,2);
            volume=(4/3)* Math.PI * Math.Pow(area, 3);
            
            Console.WriteLine("{0} é o volume da esfera", volume);
            Console.WriteLine("{0} é a area da esfera", area);
            Console.WriteLine("{0} é o comprimento da esfera", comprimento);
        }
    }
}
