using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char repetir;
            do{
                int i=0, num=1;
                double soma=0;

            while (num !=0) {
                Console.WriteLine("Digite um numero:");
                num= int.Parse(Console.ReadLine());
                soma+=num;
                i++;
            }
                Console.WriteLine("A soma é: {0}", soma);
                Console.WriteLine("Quantidade que foi rodado: {0}", i);
                
               Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
                repetir = Console.ReadKey().KeyChar; 
            } while (repetir == 'S' || repetir == 's');  
                
        }
    }
}
