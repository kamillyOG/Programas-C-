using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] temp= new int[10];
            int soma=0, media=0;
            int menor=1000, maior=0; 


            for(int i=0; i<10; i++){
                Console.WriteLine("Qual a temperatura?");
                temp[i]= int.Parse(Console.ReadLine());
                    
                    soma+= temp[i];

                    if(temp[i]> maior){
                         maior = temp[i];
                    } else if (temp[i]< menor){
                        menor= temp[i];
                    }

                    media= soma/10;
            } 

            tempInferior(temp, media);
            Console.WriteLine("A menor temperatura é: {0}", menor);
            Console.WriteLine("A maior temperatura é: {0}", maior);
            Console.WriteLine("A media é: {0}", media);



        }

        static void tempInferior(int[] dias, double media) {
            Console.WriteLine("A tempaeratura foi inferior a media, no seguintes dias:");
            for(int i=0; i<10; i++) {
                if(dias[i]<media)
                    Console.Write((i+1)+", ");
            }
        }
    }
}
