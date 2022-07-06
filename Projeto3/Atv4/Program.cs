using System;

namespace Atv4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Digite um valor");
            num= double.Parse(Console.ReadLine());
            num=Math.Abs(num);
            Console.WriteLine("{0} é o valor absoluto desse  número.",num);
        }
    }
}
