using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            double k;

            for(c=0 ; c<=100; c++){
                k= c+ 273.15;
                Console.WriteLine("{0} ºC = {1} ºK", c, k);
            }
        }
    }
}
