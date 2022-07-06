using System;

namespace Atv5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número");
            num= int.Parse(Console.ReadLine());
            if (num%2==0  &&  num%7=0) {
                Console.WriteLine("{0} é um número divisivel por 2 e 7", num);
            } else {
                Console.WriteLine("{0} não é um número divisivel por 2 e 7", num);
            }
        }
    }
}
