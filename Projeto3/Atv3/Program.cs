using System;

namespace Atv3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número:");
            num= int.Parse(Console.ReadLine());
            if (num%2==0){
                Console.WriteLine("{0} é par",num);
            } else {
                Console.WriteLine("{0} é impar",num);
            }
        }
    }
}
