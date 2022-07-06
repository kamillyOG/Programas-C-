using System;

namespace Atividade8
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo1,angulo2, medida;
            Console.WriteLine("Digite o primeiro angulo:");
            angulo1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo angulo:");
            angulo2= double.Parse(Console.ReadLine());
            medida= 180- (angulo1+ angulo2) ;
            Console.WriteLine("{0} é a medida do angulo 3", medida);
        }
    }
}
