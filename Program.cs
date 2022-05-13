using System;

namespace sistema_que_calcula_valores_de_dois_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor1 = new int[5];
            int contador = 0;
            for (int i = 0; i < Vetor1.Length; i++)
            {
                Console.WriteLine("digite 5 numeros");
                Vetor1[i] = int.Parse(Console.ReadLine());


            }

            int[] Vetor2 = new int[5];

            for (int i = 0; i < Vetor2.Length; i++)
            {
                Console.WriteLine("digite 5 numeros");
                Vetor2[i] = int.Parse(Console.ReadLine());
                contador++;
            }

            int[] Vetor1e2 = new int[5];
            for (int i = 0; i < Vetor2.Length; i++)
            {
                Vetor1e2[i] = Vetor1[i] * Vetor2[i];
                Console.WriteLine("o resultado é: " + Vetor1e2[i]);
                contador++;
            }




        }
    }
}
