using System;
class Program
{
    static void Main(string[] args)
    {
        for (int valorMultiplicado = 10; valorMultiplicado >= 1; valorMultiplicado--)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{valorMultiplicado} x {contador} = {valorMultiplicado * contador}");
                Console.ResetColor();
            }
            System.Console.WriteLine();
        }
    }
}