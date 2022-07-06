using System;

namespace Atv6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1,num2,num3;
            Console.WriteLine("Digite o primeiro número:");
            num1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            num3= double.Parse(Console.ReadLine());
            if (num1>num2 && num1>num3){
                Console.WriteLine("{0} é o maior número",num1);
                } else  if(num2>num1 && num2>num3){
                    Console.WriteLine("{0} é o maior número",num2);
                } else {
                    Console.WriteLine("{0} é o maior número",num3);
                }

            if (num1<num2 && num1<num3){
                Console.WriteLine("{0} é o menor número",num1);
                } else  if(num2<num1 && num2<num3){
                    Console.WriteLine("{0} é o menor número",num2);
                } else {
                    Console.WriteLine("{0} é o menor número",num3);
                }
        
                


        }
    }
}
