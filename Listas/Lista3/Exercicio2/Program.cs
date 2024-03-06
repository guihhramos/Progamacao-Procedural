using System;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite quantos produtos voce comprou");
        int quantidadeItens = int.Parse(Console.ReadLine());

        int contador = 1;
        double somatorio = 0;

        while (contador <= quantidadeItens)
        {
            System.Console.WriteLine("Digite o valor dos seus produtos: \n" + contador + "º produto:");
            double precoProduto = double.Parse(Console.ReadLine());

            somatorio = somatorio + precoProduto;
            contador++;
        }
        if (somatorio >= 150)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"Parabens! Voce ganhou frete gratis em sua compra de valor {Math.Round(somatorio, 2)} R$");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Voce nao ganhou frete gratis! O total da sua compra eh {Math.Round(somatorio, 2)} R$");
            Console.ResetColor();
        }
    }
}