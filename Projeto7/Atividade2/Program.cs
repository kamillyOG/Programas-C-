using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            double h=0;

            Console.WriteLine("Digite o valor:");
            n= int.Parse(Console.ReadLine());

            for (i=1; i<=n; i++){
                h += 1/(double)i;
            }
            Console.WriteLine("{0}", h);
        }
    }
}
