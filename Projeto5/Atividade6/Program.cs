using System;

namespace Atv6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int X=  int.Parse(Console.ReadLine());
            
            int fatorial= 1;
           do{
               fatorial= fatorial *X;
               X--;
           } while (X>1);

           Console.WriteLine(fatorial);
        
        }
    }
}
