using System;

namespace Atv7
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0, X=0, i=0; 
            do{
                Console.WriteLine("informe um numero:");
                X= int.Parse (Console.ReadLine());
                soma = soma + X;
                i++;
            } while (i<10);
               
            Console.WriteLine(soma);


        }
    }
}
