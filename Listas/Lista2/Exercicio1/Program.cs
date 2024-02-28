using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] orgs)
    {
        Console.WriteLine("Usuario: ");
        string usuario = Console.ReadLine();

        Console.WriteLine("Senha: ");
        string senha = (Console.ReadLine());

        if (usuario == "admin" && senha == "123senha")
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("Credenciais invalidas");
        }
        
        
    }
    
}