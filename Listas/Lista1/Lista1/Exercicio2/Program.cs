using System;

class Program 
{
  public static void Main (string[] args) 
  
{ 
  Console. WriteLine("Digite a base do triângulo: ");
  double baseTriangulo = double.Parse(Console.ReadLine());
  
  Console. WriteLine("Digite a 2º nota: ");
  double alturaTriangula = double.Parse(Console.ReadLine());
  double area;

  area = (baseTriangulo * alturaTriangula) / 2;
  bool resultado = area > 20;

  Console.WriteLine("À area do triângulo é maior que 20? " + resultado);
  
  }
} 