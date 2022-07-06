using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o primeiro numero:");
           int num1= int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o segundo numero:");
           int num2= int.Parse(Console.ReadLine());

           do{
               Console.WriteLine(num1);
               num1= num1+1;
           } while (num1<=num2);
        
        }
    }
}
