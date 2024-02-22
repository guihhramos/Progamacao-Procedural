using System;

class Program 
{
  public static void Main (string[] args) 
  
{ 
  Console. WriteLine("Digite o valor em centavos: ");
  
  int valorCentavos = int.Parse(Console.ReadLine());

  int reals = valorCentavos / 100;
  int centavos = valorCentavos % 100;

  Console.WriteLine("O valor em dinheiro eh: " + reals + " real(is) " + centavos + "centavo(s) ");
  
  }
} 