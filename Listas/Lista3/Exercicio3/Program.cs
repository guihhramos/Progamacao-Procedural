using System;
class Program
{
   static void Main(string[] args)
   {
      double contador = 0;
      const int TENTATIVAS = 3;
      int tentativasRestantes = 3;
      string usuarioLogin;
      string senhaLogin;

      do
      {
         Console.WriteLine("Usuario: ");
         usuarioLogin = Console.ReadLine();

         Console.WriteLine("Senha: ");
         senhaLogin = Console.ReadLine();

         if (usuarioLogin == "admin" && senhaLogin == "123senha")
         {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login realizado com sucesso!");
            Console.ResetColor();
            break;
         }

         else
         {
            tentativasRestantes--;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Login errado! Voce tem somente {tentativasRestantes} tentativas");
            Console.ResetColor();
         }

         if (contador == 2)
         {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Sua conta foi bloqueada!");
            Console.ResetColor();
         }
         contador++;
      } while (contador < TENTATIVAS);
   }
}