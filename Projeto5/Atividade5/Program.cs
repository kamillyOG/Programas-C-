using System;

namespace Atv5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero:");
            int X=int.Parse (Console.ReadLine());


            do{
               if (X%2==1)
                    Console.WriteLine(X);
                X--;
           } while (X>=0);

        }
    }
}
