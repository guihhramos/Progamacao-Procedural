using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;
        Produto[] Produtos = new Produto[TAMANHO_VETOR];
        int contadoor = 0;

        for (int contador = 0; contador < Produtos.Length; contador++)
        {
            Produtos[contador].id = Convert.ToInt32(Console.ReadLine());
            Produtos[contador].nome = Console.ReadLine();
            Produtos[contador].preco = double.Parse(Console.ReadLine());
            Produtos[contador].disponivelEmEstoque = bool.Parse(Console.ReadLine());
        }

        for(int contador = 0; contador < Produtos.Length; contador++)
        {
             if (Produtos[contador].disponivelEmEstoque == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("\n" + Produtos[contador].nome);
                System.Console.WriteLine($"{Math.Round(Produtos[contador].preco, 2)}");
                Console.ResetColor();
            }
        }
    }
}