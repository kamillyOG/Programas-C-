using System;

namespace Atvidade6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x=250;
            double j=0;

            for (i=21; i<=250; i++){
                j += i/(double)x;
                x--;
            }
            Console.WriteLine("{0:0.0}", j);
        }
    }
}
