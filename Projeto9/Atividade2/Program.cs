using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] vet= new int[7];
            int i, p=0, n=0;

            for(i=0; i<vet.Length; i++){
                Console.WriteLine("Digite um número:");
                vet [i]=int.Parse(Console.ReadLine());
                if (vet [i]> 0){
                    p+= 1;
                } else {
                    n+=1;
                }
            }

            Console.WriteLine("Positivos:");
            Console.WriteLine("{0}", p );
            for(i=0; i<vet.Length; i++){
                if (vet [i]> 0){
                    Console.Write( vet [i]+ " ");
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Negativos:");
            Console.WriteLine("{0}", n );
            for(i=0; i<vet.Length; i++){
                if (vet [i]< 0){
                    Console.Write( vet [i]+ " ");
                }
            }


        }
    }
}
