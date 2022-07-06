using System;

namespace Atv9
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int i=0, x=0, fibo=1;

            do {
                int y=x;
                x= fibo;
                fibo= x + y;
                Console.WriteLine("{0}", fibo);
                i++;
            } while(i<8);
            
        }
    }
}
