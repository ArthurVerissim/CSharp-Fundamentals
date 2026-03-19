using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    // 1 a 4: Criando as variáveis originais
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    // 5 a 8: Imprimindo os dados iniciais
    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);

    // 9: Aumentando a idade (Incremento)
    passengerAge = passengerAge + 1;  
    Console.WriteLine(passengerAge);

    // 10: Conversão EXPLÍCITA (com o parênteses)
    double passengerAgeDouble = (double)passengerAge;
    Console.WriteLine(passengerAgeDouble);

    // 11: Conversão IMPLÍCITA  
    double passengerAgeDouble2 = passengerAge; 
    Console.WriteLine(passengerAgeDouble2);

    // 12: Conversão usando o método Convert
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeString);
  }
}