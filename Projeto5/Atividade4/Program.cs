using System;

namespace At4
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Digite um numero inteiro e positivo");
           int X= int.Parse(Console.ReadLine());

            int Y=X;
           do{
               if (X%Y==0)
                    Console.WriteLine(Y);
                Y--;
           } while (Y>=0);
        }
    }
}
