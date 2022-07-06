using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o primeiro numero:");
           int X= int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o segundo numero:");
           int Y= int.Parse(Console.ReadLine());

            int maior, menor;
            if(X>Y){
                maior= X;
                menor= Y;
            } else {
                maior= Y;
                menor= X;
            }

           do{
               if (menor%3==0)
                    Console.WriteLine(menor);

                menor++;
           } while (menor<=maior);
        
        }
    }
}