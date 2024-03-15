using System;

class Program
{
    static void Main(string[] args)
    {

        for (int valorMultiplicado = 1; valorMultiplicado <= 10; valorMultiplicado++)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                System.Console.WriteLine($"{valorMultiplicado} x {contador} = {valorMultiplicado * contador}");
            }
            System.Console.WriteLine();
        }
    }
}