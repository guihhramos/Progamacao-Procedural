using System;
using System.ComponentModel.Design.Serialization;
using System.Formats.Asn1;
using System.Xml.Schema;

class Program
{
    static void Main(string[] orgs)
    {
      Console.WriteLine("Digite a 1º nota: ");
      double nota1 = double.Parse(Console.ReadLine());
  
      Console.WriteLine("Digite a 2º nota: ");
      double nota2 = double.Parse(Console.ReadLine());
  
      Console.WriteLine("Digite a 3º nota: ");
      double nota3 = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite a 4º nota: ");
      double nota4 = double.Parse(Console.ReadLine());
      double media; 

      media = (nota1 + nota2 + nota3 + nota4) / 4.0;

        if (media < 5.0 && media >= 3.0)
        {
          Console.WriteLine("Aluno em recuperacao :/ ");
        }
        else
        {
          Console.WriteLine("Aluno aprovado! :) ");
        }
    }
}