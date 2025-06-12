using System;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet;

            Console.WriteLine("Escreva quantos numeros tera no seu vetor,feito isso aperte 'enter'e em seguida digite a mesma quantidade em numeros aleatorios seja eles positivos ou negativos: ");
            n = int.Parse(Console.ReadLine()!);
            vet = new int[n];

            string[] s = Console.ReadLine()!.Split(' ');

            for (int i = 0; i < n; i++) { 
                vet[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine("Entre os numeros escolhidos " + vet[i] + " são numeros negativos");
                }
            }
            
                Console.ReadLine();
        }
    }
}
