using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i=0; i<=360; i+=15){
                Console.WriteLine("{0}= {1:0.000} ,{2:0.000}", i, Math.Sin(i), Math.Cos(i));
            }
        }
    }
}
