using System;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite a altura do retangulo: ");
        int alturaRetangulo = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a base do retangulo: ");
        int baseRetangulo = int.Parse(Console.ReadLine());

        for (int linha = 1; linha <= alturaRetangulo; linha++)
        {
            for (int coluna = 1; coluna <= baseRetangulo; coluna++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("*");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}