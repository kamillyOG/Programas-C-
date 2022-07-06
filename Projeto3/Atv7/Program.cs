using System;

namespace Atv7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1,num2,num3,soma;
            Console.WriteLine("Digite o primeiro número:");
            num1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            num3= double.Parse(Console.ReadLine());
            if (num1>num2 && num2>num3){
                soma= num1+num2;
                Console.WriteLine("{0} é a soma dos maiores números",soma);
                } else  if(num2>num1 && num3>num1){
                soma= num2+num3;
                Console.WriteLine("{0} é a soma dos maiores números",soma);
                } else if (num1>num2 && num3>num2){
                soma= num1+num3;
                Console.WriteLine("{0} é a soma dos maiores números",soma);
                }
        }
    }
}
