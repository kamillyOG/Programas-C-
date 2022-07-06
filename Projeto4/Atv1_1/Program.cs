using System;

namespace Atv1
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, resultado;
            string operacao;

            Console.WriteLine("Digite o primeiro numero:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação (' / | + | * | - |'): ");
            operacao = (Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            num2 = double.Parse(Console.ReadLine());

            if (operacao == "+")
            {
                resultado = num1 + num2;
                Console.WriteLine("{0}", resultado);
            }
            else if (operacao == "-")
            {
                resultado = num1 - num2;
                Console.WriteLine("{0}", resultado);
            }
            else if (operacao == "*")
            {
                resultado = num1 * num2;
                Console.WriteLine("{0}", resultado);
            }
            else if (operacao == "/")
            {
                resultado = num1 / num2;
                Console.WriteLine("{0}", resultado);
            }
            else
            {
                Console.WriteLine("Digite uma operação válida");
            }

        }
    }
}
