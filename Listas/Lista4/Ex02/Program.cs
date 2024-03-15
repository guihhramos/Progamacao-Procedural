using System;
class Program
{
    static void Main(string[] args)
    {
        bool alturaValida = false;
        int altura = 0;

        while (alturaValida == false)
        {
            Console.WriteLine("Informe a altura do triangulo, precisa ser entre 1 e 9:");
            altura = int.Parse(Console.ReadLine());

            if (altura <= 9 && altura >= 1)
            {
                alturaValida = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Numero invalido, tem que ser entre 1 e 9! \nSeu numero foi {altura}.\n");
                Console.ResetColor();
            }
        }

        for (int linha = 0; linha <= altura; linha++)
        {
            for (int coluna = 1; coluna <= linha; coluna++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(coluna);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}