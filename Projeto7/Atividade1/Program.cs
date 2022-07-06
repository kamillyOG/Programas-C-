using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int conv, f;

            for (conv=0; conv<=100; conv++){
                f= 9* conv/ 5+32;
                Console.WriteLine("{0}ºC = {1}º F", conv, f);
            }
        }
    }
}
