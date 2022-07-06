using System;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Foi feita uma pesquisa em um número indeterminado de postos dos preços da gasolina, do álcool e do diesel. Ler para cada posto, os valores  de cada combustível, calcular e imprimir o maior e o menor  valor  encontrado  para  cada  tipo  de  combustível  dentre  os  postos  pesquisados.  Os  dados terminam quando for digitado um valor de preço de gasolina igual a Zero. Colocar no final a opção para repetir tudo de novo.

            char repetir;
            do{
                double gasolina=1,maiorg=-1, menorg=100000, maiord=-1, menord=100000, maiora=-1, menora=100000;
            do{
                double disel,alcool;
                Console.WriteLine("Qual o valor da gasolina?");
                gasolina= double.Parse(Console.ReadLine());
                if (gasolina==0){
                    continue;
                }
                Console.WriteLine("Qual o valor do disel?");
                disel= double.Parse(Console.ReadLine());
                Console.WriteLine("Qual o valor da álcool?");
                alcool= double.Parse(Console.ReadLine());
                if (gasolina> maiorg) maiorg = gasolina;
                if (gasolina < menorg) menorg= gasolina;

                if (disel> maiord) maiord = disel;
                if (disel < menord) menord= disel;

                if (alcool> maiora) maiora = alcool;
                if (alcool < menora) menora= alcool;
                gasolina++;
            } while(gasolina != 0);

                Console.WriteLine("O maior preço da gasolina é: {0}", maiorg );
                Console.WriteLine("O menor preço da gasolina é: {0}", menorg );

                Console.WriteLine("O maior preço do disel é: {0}", maiord );
                Console.WriteLine("O menor preço do disel é: {0}", menord );

                Console.WriteLine("O maior preço do álcool é: {0}", maiora );
                Console.WriteLine("O menor preço da álcool é: {0}", menora );
            
            Console.WriteLine("\n Deseja repetir o programa ? (S / N)");
                repetir = Console.ReadKey().KeyChar; 
            } while (repetir == 'S' || repetir == 's'); 


            
        }
    }
}
