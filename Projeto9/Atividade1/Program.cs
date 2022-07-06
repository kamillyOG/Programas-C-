using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] a= new float[10];
            float[] b= new float[10];
            float[] c= new float [10];

            LeVetor(a);
            LeVetor(b);
            MostraVetor(a);
            MostraVetor(b);
            Minvetor(a, b, c);
            MostraVetor(c);

            
        }

        static void LeVetor(float[] vetor) 
        { 
            for (int i = 0; i < vetor.Length;  i++ ) { 
                Console.Write("Entre com a nota do aluno [{0}]: ", i+1);    
                vetor[ i ] = float.Parse(Console.ReadLine()); 
            } 
        } 

        static void MostraVetor(float[] vetor) 
        { 
            for (int i = 0; i < vetor.Length;  i++ ) {   
                Console.Write(vetor [i]+"");
            } 
                Console.WriteLine();
        } 

        static void Minvetor(float[] veta, float[] vetb, float[] vetc) 
        { 
            Console.Write("As menores notas foram:");
            for (int i = 0; i < vetc.Length;  i++ ) { 
               if (veta[i] < vetb[i]){
                   vetc[i]= veta[i];
               } else{
                   vetc[i]= vetb[i];
               }
            } 
        } 
    }
}
