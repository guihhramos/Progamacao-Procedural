using System;
class Program
{
    static int EncontrarMaiorNumero(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            return num1;
        }
        
        else if (num2 > num1 && num2 > num3)
        {
            return num2;
        }

        else
        {
            return num3;
        }
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um numero inteiro:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite outro numero inteiro:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Digite outro numero inteiro:");
        int numero3 = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nO maior número é: {EncontrarMaiorNumero(numero1, numero2, numero3)}");
        Console.ResetColor();
    }
}