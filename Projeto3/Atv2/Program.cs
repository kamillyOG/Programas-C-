using System;

namespace Atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Digite um número:");
            num= double.Parse(Console.ReadLine());
            if (num>0){
                Console.WriteLine("Esse número é positivo");
            } else if (num<0){
                Console.WriteLine("Esse número é negativo");
            } else if (num==0){
                Console.WriteLine("Esse número é nulo");
            }
        }
    }
}
