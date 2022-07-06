using System;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double preco,novopreco;
            Console.WriteLine("Digite o preço do produto:");
            preco= double.Parse(Console.ReadLine());
            novopreco= preco - (preco*0.10);
            Console.WriteLine("O novo preço do produto com o desconto de 10% é: {0}", novopreco);


        }
    }
}

