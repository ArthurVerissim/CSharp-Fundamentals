using System;

public class SpaceExpedition
{
    public static void Main(string[] args)
    {
        // Criando variaveis booleana
        bool isAtmosphereBreathable = true;
        bool isGravityStable = false;
        bool resourcesSufficient = true;

        
        // Só é habitável se tiver ar e gravidade ou no caso, se as duas variaveis for verdadeira
        bool isHabitable = isAtmosphereBreathable && isGravityStable;
        Console.WriteLine($"Status de Habitabilidade: {isHabitable}");

        // Caso nao haja gravidade ainda é possivel habitar desde que tenha recurso ou se pelo menos uma seja verdadeira pra compensar a outra
        bool suitableForExpansion = isGravityStable || resourcesSufficient;
        Console.WriteLine($"Viável para expansão? {suitableForExpansion}");

        //  tripulantes atuais e o maximo possivel 
        int currentCrew = 5;
        int maxCrewCapacity = 10;

        // verificando se os tripulantes atual é menor que o maximo permitido 
        bool canAcceptMoreCrew = currentCrew < maxCrewCapacity;
        Console.WriteLine($"Vagas disponíveis: {canAcceptMoreCrew}");
    }
}
