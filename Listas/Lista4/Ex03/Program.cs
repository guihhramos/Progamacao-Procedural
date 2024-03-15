using System;
class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();

        for (int linha = 0; linha < 8; linha++)
        {
            for (int coluna = 0; coluna < 8; coluna++)
            {
                if (linha <= 0 || linha == 7 || coluna == 0 || coluna == 7)
                {
                    Tabuleiro.Adicionar(coluna, linha, "s");
                }
            }
        }
        Tabuleiro.ImprimeTabuleiro();
    }
}