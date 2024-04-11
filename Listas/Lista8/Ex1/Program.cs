using System;

struct Pizza
{
    public int id;
    public string sabor;
    public double preco;
}

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza1;

        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Id:");
        Console.ResetColor();
        pizza1.id = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Sabor:");
        Console.ResetColor();
        pizza1.sabor = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Preco:");
        Console.ResetColor();
        pizza1.preco = double.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine(pizza1.id);
        System.Console.WriteLine(pizza1.sabor);
        System.Console.WriteLine(pizza1.preco);
        Console.ResetColor();
    }
}