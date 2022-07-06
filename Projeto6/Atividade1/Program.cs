using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            double soma=0;
            while (num !=0) {
                Console.WriteLine("Digite um numero:");
                num= int.Parse(Console.ReadLine());
                soma+=num; 
            }
                Console.WriteLine("A soma é: {0}", soma);
              
        }
    }
}
