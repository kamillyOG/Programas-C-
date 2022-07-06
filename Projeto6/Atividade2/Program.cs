using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, num=1;
            double soma=0;
            while (num !=0) {
                Console.WriteLine("Digite um numero:");
                num= int.Parse(Console.ReadLine());
                soma+=num;
                i++;
            }
                Console.WriteLine("A soma é: {0}", soma);
                Console.WriteLine("Quantidade que foi rodado: {0}", i);
        }
    }
}
