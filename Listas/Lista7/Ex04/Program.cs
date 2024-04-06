using System;

class Porgram
{
    static void Main(string[] args)
    {
        int[] vagoes = new int[12];

        PreencherVetor(vagoes);

        VerificarPesoDosVagoes(vagoes);
    }

    static void PreencherVetor(int[] vetor)
    {
        for(int vagao = 0; vagao < vetor.Length; vagao++)
        {
            vetor[vagao] = int.Parse(Console.ReadLine());
        }
    }

    static void VerificarPesoDosVagoes(int[] vetor)
    {
        for(int numeroToneladas = 0; numeroToneladas < vetor.Length; numeroToneladas++)
        {
            if(vetor[numeroToneladas] > 50)
            {
                System.Console.WriteLine($"{numeroToneladas + 1}º vagao ultrapassou o limite de peso");
            }
        }
    }
}