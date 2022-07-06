using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            double basemaior, basemenor, altura, area;
            Console.WriteLine("Digite a maior base do trapézio:");
            basemaior= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a menor base do trapézio:");
            basemenor= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do trapézio:");
            altura= double.Parse(Console.ReadLine());
            area= ((basemaior - basemenor)* altura / 2);
            Console.WriteLine("A área do trapézio é: {0}", area);


        }
    }
}

