using System;
class Program
{
    static void Main(string[] args)
    {
        for (int crescente = 0; crescente <= 100; crescente++)
        {
            int contagemDecrescente = 200;
            if (crescente % 2 == 0)
            {
                System.Console.WriteLine($"{crescente} - {contagemDecrescente - (crescente * 2)}");
            }
        }
    }
}