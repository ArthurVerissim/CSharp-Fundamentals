using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Este programa é um jogo de Mad Libs (Histórias Malucas).
             * O objetivo é pedir palavras ao usuário e inseri-las em uma história.
             */

            // 2. Informa ao usuário que o programa começou
            Console.WriteLine("--- Começou! ---");

            // 3. Define o título da história
            string titulo = "Historia Inesperada";
            Console.WriteLine($"Título: {titulo}\n");

            // 5. Solicita o nome do personagem principal
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            // 6. Solicita os três adjetivos
            Console.Write("Digite o 1º adjetivo (ex: engraçado): ");
            string adjetivo1 = Console.ReadLine();

            Console.Write("Digite o 2º adjetivo (ex: gigante): ");
            string adjetivo2 = Console.ReadLine();

            Console.Write("Digite o 3º adjetivo (ex: confuso): ");
            string adjetivo3 = Console.ReadLine();

            // 8. Solicita um verbo
            Console.Write("Digite um verbo (ex: dançar, pular): ");
            string verbo = Console.ReadLine();

            // 9. Solicita dois substantivos
            Console.Write("Digite o 1º substantivo (ex: rádio, cadeira): ");
            string substantivo1 = Console.ReadLine();

            Console.Write("Digite o 2º substantivo (ex: castelo, controle): ");
            string substantivo2 = Console.ReadLine();

            // 10. Solicita os itens extras para a diversão
            Console.Write("Digite um animal: ");
            string animal = Console.ReadLine();

            Console.Write("Digite uma comida: ");
            string comida = Console.ReadLine();

            Console.Write("Digite uma fruta: ");
            string fruta = Console.ReadLine();

            Console.Write("Digite um super-herói: ");
            string superHeroi = Console.ReadLine();

            Console.Write("Digite um país: ");
            string pais = Console.ReadLine();

            Console.Write("Digite uma sobremesa: ");
            string sobremesa = Console.ReadLine();

            Console.Write("Digite um ano: ");
            string ano = Console.ReadLine();

            // 11 e 12. Montagem da história usando Interpolação de Strings ($)
            // Note que seguimos a ordem exata pedida nas instruções originais.
            string historia = $"Nesta manhã, {nome} acordou sentindo-se {adjetivo1}. 'Vai ser um dia {adjetivo2}!' Lá fora, um grupo de {animal}s estava protestando para manter {comida} nas lojas. Eles começaram a {verbo} no ritmo do(a) {substantivo1}, o que deixou todas as {fruta}s muito {adjetivo3}. Preocupado(a), {nome} enviou uma mensagem para {superHeroi}, que voou com {nome} até o(a) {pais} e deixou {nome} cair em uma poça de {sobremesa} congelada. {nome} acordou no ano de {ano}, em um mundo onde {substantivo2}s governavam a Terra.";

            // 13 e 14. Exibe o resultado final
            Console.WriteLine("\n========================================");
            Console.WriteLine("SUA HISTÓRIA FINALIZADA:");
            Console.WriteLine("========================================\n");
            Console.WriteLine(historia);
            Console.WriteLine("\n--- FIM ---");
        }
    }
}
