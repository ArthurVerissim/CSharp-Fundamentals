using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      
      string input = Console.ReadLine();
      double total = Convert.ToDouble(input);

      Console.WriteLine($"{total} cents is equal to...");

      // Valores das moedas
      int goldValue = 10;
      int silverValue = 5;

      // 1. Calcular Moedas de Ouro
      double goldCoins = Math.Floor(total / goldValue);
      // 2. Calcular o que sobrou depois do ouro
      double remainder = total % goldValue;

      // 3. Calcular Moedas de Prata (usando o RESTO do ouro)
      double silverCoins = Math.Floor(remainder / silverValue);
      // 4. Calcular o que sobrou depois da prata
      remainder = remainder % silverValue;

      // 5. O que sobrou no final são as moedas de bronze
      double bronzeCoins = remainder;

      // Saída final
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {bronzeCoins}");
    }
  }
}