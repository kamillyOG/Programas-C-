using System;

namespace Atv2
{

    class Program
    {
        static void Main(string[] args)
        {
           
           string horario;
           
            Console.WriteLine("Qual é o horario? Informe um número entre 0 e 23");
            horario= (Console.ReadLine());
           
            switch (horario)
            {
                case "3":
                    Console.WriteLine("Matinas");
                    break;
                case "5":
                    Console.WriteLine("Laudes");
                    break;
                case "7":
                    Console.WriteLine("Prima");
                    break;
                case "9":
                    Console.WriteLine("Tercia");
                    break;
                case "meio dia":
                    Console.WriteLine("Sexta");
                    break;
                case "15":
                    Console.WriteLine("Noa");
                    break;
                case "18":
                    Console.WriteLine("Vésperas");
                    break;
                case "21":
                    Console.WriteLine("Completas");
                    break;
                default:
                    Console.WriteLine("Não é uma hora canônica");
                    break;
            }
        }
    }
}