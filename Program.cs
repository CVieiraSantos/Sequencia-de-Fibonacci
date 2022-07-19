using System;
using Exercicio2.Services;
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            
            
            int[]vet = new int[10];

            vet[0] = 0;
            vet[1] = 1;
            vet[2] = 1;
            vet[3] = 2;
            vet[4] = 3;
            vet[5] = 5;
            vet[6] = 8;
            vet[7] = 13;
            vet[8] = 21;
            vet[9] = 34;
                                
            for(int i = 0; i < vet.Length; i++)
            {                  
                if(vet[0] == numero)
                    Console.WriteLine("Pertence");
                
                
                
                if(vet[1] == numero)
                    Console.WriteLine("Pertence");
                
                
                
                if(vet[2] == numero)
                    Console.WriteLine("Pertence");
                
                
                
                if(vet[3] == numero)
                    Console.WriteLine("Pertence");
                
                

                if(vet[4] == numero)
                    Console.WriteLine("Pertence");
                
                

                if(vet[5] == numero)
                    Console.WriteLine("Pertence");
                
                

                if(vet[6] == numero)
                    Console.WriteLine("Pertence");
                
                

                if(vet[7] == numero)
                    Console.WriteLine("Pertence");
                
                

                if(vet[8] == numero)
                    Console.WriteLine("Pertence");
                
                

                if(vet[9] == numero)
                    Console.WriteLine("Pertence");
                
                
                
                Console.WriteLine(Sequencia.SequenciaFibonacci(i));
                
            }

            Console.WriteLine("Não pertence");

        }
    }
}
