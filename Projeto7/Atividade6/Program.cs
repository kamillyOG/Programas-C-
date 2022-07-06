using System;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x=1;
            double g=0;

            for (i=1; i<=99; i+=2){
                g += i/(double)x;
                x++;
            }
            Console.WriteLine("{0:0.0}", g);
        }
    }
}
