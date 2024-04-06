using System;
class Program
{
    static void PreencherMatriz(int[,] matriz)
    {
        for (int linha = 0; linha < matriz.Length; linha++)
        {
            for (int coluna = 0; coluna < matriz.Length; coluna++)
            {
                int numeroDigitado = int.Parse(Console.ReadLine());
                matriz[linha, coluna] = numeroDigitado;
            }
        }
    }
    static void ZeroEstaPresente(int[,] numeroZero)
    {
        for (int linha = 0; linha < numeroZero.Length; linha++)
        {
            for (int coluna = 0; coluna < numeroZero.Length; coluna++)
            {
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());
                numeroZero[linha, coluna] = numeroDigitado;
            }
        }
    }

    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        PreencherMatriz(matriz);
    }
}