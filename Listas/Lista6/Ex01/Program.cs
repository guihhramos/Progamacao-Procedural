using System;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[10];

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            nomes[contador] = Console.ReadLine();
        }

        bool temRosa = false;

        for (int contador = 0; contador < nomes.Length; contador++)
        {
            if (nomes[contador] == "Rosa")
            {
                temRosa = true;
            }
        }
        if (temRosa)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("ACHEI!");
            Console.ResetColor();
        }
        else
        {
            System.Console.WriteLine("NAO ACHEI!");
        }
    }
}