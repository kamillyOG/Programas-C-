using System;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            double p;

            for (c=0; c<=100; c+=2){
                p = c/2.5;
                Console.WriteLine("{0} cm= {1} polegadas", c, p);
            }

        }
    }
}
