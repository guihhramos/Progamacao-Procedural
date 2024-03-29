using System;
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int[,] matriz = new int[TAMANHO_MATRIZ,TAMANHO_MATRIZ];

        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                if(linha + coluna == 2)
                {
                    matriz[linha,coluna] = int.Parse(Console.ReadLine()) * 2;
                }
                else
                {
                    matriz[linha,coluna] = int.Parse(Console.ReadLine());
                }
            }
        }

        for(int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for(int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                System.Console.Write($"{matriz[linha,coluna]}|");
            }
            System.Console.WriteLine();
        }
    }
}