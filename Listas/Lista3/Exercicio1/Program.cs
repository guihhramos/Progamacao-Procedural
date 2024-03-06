using System;

class Program
{
  static void Main(string[] args)
  {
    const int NUMERO_HABITANTES = 3;
    double somatorioSalario = 0;
    int somatorioFilhosn = 0;
    double maiorSalario = 0;

    for (int contador = 1; contador < NUMERO_HABITANTES; contador++)
    {
      Console.WriteLine(contador + "º cidadao: digite o valor medio do seu salario");
      double salarioCidadao = double.Parse(Console.ReadLine());

      Console.WriteLine(contador + "º cidadao: digite quantos filhos tem");
      int quantidadeFilhos = int.Parse(Console.ReadLine());

      somatorioSalario = somatorioSalario + salarioCidadao;
      somatorioFilhosn = somatorioFilhosn + quantidadeFilhos;

      if (salarioCidadao > maiorSalario)
      {
        maiorSalario = salarioCidadao;
      }
    }

    double mediaSalarial = somatorioSalario / NUMERO_HABITANTES;
    System.Console.WriteLine($"A media salarial:  {Math.Round(mediaSalarial, 2)}  R$");

    double mediaFilhos = somatorioFilhosn / NUMERO_HABITANTES;
    System.Console.WriteLine($"A media de filhos por habitante eh: {Math.Round(mediaFilhos, 2)} filho(s)");

    System.Console.WriteLine($"Maior salario eh {Math.Round(maiorSalario, 2)} R$");

  }

}