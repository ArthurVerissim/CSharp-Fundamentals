using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Definindo os valores a serem usados para comparar com a senha digitada pelo usuário
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*()-_+=\\|/?,.<>~"; 
      
      // Pedimos para o usuário digitar a senha e guardamos na variável 'senha'
      Console.WriteLine("Digite sua senha:");
      string senha = Console.ReadLine();
      
      // Iniciamos a pontuação zerada para depois irmos adicionando pontos dependendo da senha
      int score = 0;

      // Usamos apenas 'if' para testar todas as condições.
      // Cada vez que ele passa em um teste, ganha 1 ponto para ser somado no score.

      // Aqui testamos se a senha atual tem tamanho maior ou igual ao mínimo de caracteres permitido 
      if (senha.Length >= minLength) {
        score++; // score++ é o mesmo que score = score + 1
      }
      
      // Aqui verificamos se na senha atual há caracteres maiúsculos
      if (Tools.Contains(senha, uppercase)) {
        score++;
      }
      
      // Aqui verificamos se na senha atual há caracteres minúsculos
      if (Tools.Contains(senha, lowercase)) {
        score++;
      }
      
      // Aqui verificamos se na senha atual há números
      if (Tools.Contains(senha, digits)) {
        score++;
      }
      
      // Aqui verificamos se na senha atual há caracteres especiais
      if (Tools.Contains(senha, specialChars)) {
        score++;
      }
      
      // Imprimindo a pontuação para já ter uma base do resultado
      Console.WriteLine("Pontuação da senha: " + score);

      // Aqui fizemos uma estrutura switch a fim de dar uma mensagem final dependendo da pontuação alcançada
      switch (score) {
        case 5:
        case 4:
          // Se o score for 4 ou 5, ele cai aqui
          Console.WriteLine("Status: A senha é extremamente forte.");
          break;
        case 3:
          Console.WriteLine("Status: A senha é forte.");
          break;
        case 2:
          Console.WriteLine("Status: A senha é média.");
          break;
        case 1:
          Console.WriteLine("Status: A senha é fraca.");
          break;
        default:
          // Só será possível cair em default caso a senha não atenda a nenhum dos critérios fazendo com que a pontuação seja zero ou excedendo o que não é possível
          Console.WriteLine("Status: A senha não atende a nenhum dos padrões de segurança.");
          break; 
      }
    }
  }
}