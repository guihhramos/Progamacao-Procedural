using System;
class Program
{
    static void PreencherMatriz(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());
                matriz[linha, coluna] = numeroDigitado;
            }
        }
    }
    static bool ZeroEstaPresente(int[,] numeroZero)
    {
        int numero = 0;
        bool validacao = false;
        for (int linha = 0; linha < numeroZero.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < numeroZero.GetLength(1); coluna++)
            {
                if (numero == numeroZero[linha, coluna])
                {
                    validacao = true;
                }
            }
        }
        return validacao;
    }

    static void Main(string[] args)
    {
        bool resultadoValidacao = false;
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];


        PreencherMatriz(matriz);
        resultadoValidacao = ZeroEstaPresente(matriz);
        
        if (resultadoValidacao)
        {
            System.Console.WriteLine($"Fique atento! existem balistas no tabuleiro");
        }
    }
}