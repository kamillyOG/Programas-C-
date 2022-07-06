using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve sua frase:");
            string f=Console.ReadLine();

            Console.WriteLine("Escreve uma letra qualquer:");
            char l=char.Parse(Console.ReadLine());

            int espacobranco=0, letrap=0;

            for(int i=0; i<f.Length; i++) {
                if(f[i] == ' ')
                    espacobranco++;
                if(f[i] == 'p' || f[i] == 'P')
                    letrap++;

            }

            Console.WriteLine("Existem {0} espaços em branco", espacobranco);
            Console.WriteLine(" Existem {0} letras p", letrap);

             int pos=retornaposicao(f,l);
                if(pos>= 0){
                    Console.WriteLine("Posição =" +pos);
                } else{
                    Console.WriteLine("Letra não encontrada");
                }
            
        }



        static int retornaposicao(string frase, char letra){
            for(int i=0; i< frase.Length; i++){
                if(frase[i].Equals(letra)){
                    return i;
                }
            }
                return -1;
        }

    }


}
