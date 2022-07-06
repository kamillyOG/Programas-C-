using System;

namespace Atividade9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, x=0, fibo=1;

            while(i<8){
                int y=x;
                x= fibo;
                fibo= x + y;
                Console.WriteLine("{0}", fibo);
                i++;
            } ;
        }
    }
}
