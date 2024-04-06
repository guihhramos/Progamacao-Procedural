using System;
class Program
{
    static int ClassificarNadador(int idade)
    {
        return idade;
    }
    
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite sua idade para descobrir sua categoria:");
        int idadeDoNadador = Convert.ToInt32(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        if (ClassificarNadador(idadeDoNadador) < 12)
        {
            System.Console.WriteLine("Sua categoria eh: Infantil");
        }
        else if (ClassificarNadador(idadeDoNadador) >= 12 && ClassificarNadador(idadeDoNadador) <= 14)
        {
            System.Console.WriteLine("Sua categoria eh: Juvenil A");
        }
        else if (ClassificarNadador(idadeDoNadador) >= 15 && ClassificarNadador(idadeDoNadador) <= 17)
        {
            System.Console.WriteLine("Sua categoria eh: Juvenil B");
        }
        else if (ClassificarNadador(idadeDoNadador) >= 18)
        {
            System.Console.WriteLine("Sua categoria eh: Adulto");
        }
        Console.ResetColor();
    }
}