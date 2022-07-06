using System;

namespace Atv8
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1,nota2,nota3,nota4, media;
            Console.WriteLine("Digite a primeira nota:");
            nota1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota:");
            nota4= double.Parse(Console.ReadLine());
            media= nota1+ nota2+ nota3+ nota4;
            if (media>= 60){
                Console.WriteLine("{0} é a media, ou seja, Aluno Aprovado", media);
            } else {
                Console.WriteLine("{0} é a media, ou sejaa, Aluno Reprovado", media);
            }
        }

    }
}
