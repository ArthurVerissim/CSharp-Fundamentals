# Choose Your Own Adventure

Um joguinho simples de texto pra praticar lógica básica em C#.

## Tecnologias
* C#
* .NET

## Desafios
O que pegou aqui foi lidar com as condicionais aninhadas. Como o jogo tem várias camadas de decisão (ir pro corredor, escolher entre abrir ou bater, escolher chave), ficou meio chato de organizar os blocos de `if/else` dentro de outros `if/else` sem o código virar uma bagunça. Tive que focar em deixar as camadas de decisão precisas pra resposta final não sair errada.

Também usei o `.ToUpper()` pra tratar os inputs e não quebrar o código caso o usuário digite algo em minúsculo, o que é meio repetitivo, mas resolveu o problema.

## Como rodar
1. Certifique-se de ter o SDK do .NET instalado.
2. Clone o repositório.
3. No terminal, dentro da pasta do projeto, execute:
   ```bash
   dotnet run