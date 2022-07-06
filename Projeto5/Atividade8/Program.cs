using System;

namespace Atv8
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0; int x=0;
            do{
                Console.WriteLine("Digite um numero:");
                int num= int.Parse(Console.ReadLine());
                soma += num;
                x++;
                if (soma<21){
                Console.WriteLine("Leu {0} números, Ainda não acabou", x);
                }
            } while(soma<21);

        
            if (soma>21){
                    Console.WriteLine("Leu {0} números, Acabou – você perdeu", x);
            } else if (soma==21){
                    Console.WriteLine("Leu {0} números, Acabado, soma = 21 – você ganhou.", x);
            }
        

        }
    }
}
