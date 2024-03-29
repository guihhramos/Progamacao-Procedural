using System;
class Program
{
    static void Main(string[] args)
    {
        const int QUANTIDADE_NOMES = 10;
        string[] nomesVetor = new string[QUANTIDADE_NOMES];

        for (int contador = 0; contador < QUANTIDADE_NOMES; contador++)
        {
            nomesVetor[contador] = Console.ReadLine();
        }

        for (int contador = QUANTIDADE_NOMES - 1; contador >= 0; contador--)
        {
            if (contador % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(nomesVetor[contador]);
                Console.ResetColor();
            }
        }
    }
}