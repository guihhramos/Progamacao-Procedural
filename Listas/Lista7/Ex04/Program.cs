using System;

class Program
{
    static void Vagoes()
    {
        Vagoes();
    }

    static void Main(string[] args)
    {
        int[] vagoes = new int[12];

        for (int contadorVagoes = 0; contadorVagoes < vagoes.Length; contadorVagoes++)
        {
            int toneladasRecebida = int.Parse(Console.ReadLine());

            if (toneladasRecebida > 50)
            {
                System.Console.WriteLine($"{contadorVagoes}º vagao ultrapassou o limite de peso");
            }
        }
    }
}