using System;

namespace Atividade6_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i;
            double l=0;
            Console.WriteLine("Digite o numero:");
            n=int.Parse(Console.ReadLine());

            for(i=1; i<=n; i++) {
                if (i%2==0){
                    l= l-(double)i/Math.Pow(i, 2);
                }else{
                    l= l+(double)i/Math.Pow(i, 2);

                }
            }

            Console.WriteLine("{0:0.00}", l);
            
        }
    }
}
