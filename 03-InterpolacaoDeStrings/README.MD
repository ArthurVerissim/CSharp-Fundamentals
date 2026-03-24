# 🖋️ História Interativa em C#

Este é um projeto desenvolvido em **C#** que automatiza a criação de uma história interativa baseada nas entradas fornecidas pelo usuário. 

## 📝 Sobre o Projeto

O programa funciona através da entrada de dados do usuário, onde a partir das informações fornecidas, o sistema completa as lacunas que estão faltando no texto.

A lógica principal do projeto consiste em:

1.  **Coleta dos Dados:** Solicitar variáveis específicas (como nomes, animais, objetos e lugares).
2.  **Completar com as informações:** Utilizar a técnica de **Interpolação de Strings** para injetar as respostas do usuário em lacunas específicas do texto.
3.  **Saída dos Dados:** Gerar um parágrafo final onde a combinação de palavras aleatórias com um contexto fixo resulta em uma história imprevisível.

## 🛠️ Tecnologias e Conceitos Aplicados

* **Manipulação de Strings:** Uso de `$""` (Interpolação) para manter o código limpo e evitar varias concatenações .
* **Interação a Partir do Console:** Recebe a entrada do usuário e utiliza a saída para completar as informações, capturando dados com `Console.ReadLine()` e exibindo com `Console.Write()`.
* **Ecossistema .NET:** Utilização da plataforma .NET para rodar a aplicação no terminal.

## 🚀 Como Executar

Para rodar o projeto localmente, siga os passos abaixo:

1.  Certifique-se de ter o [**.NET SDK**](https://dotnet.microsoft.com/download) instalado.
2.  Clone este repositório para sua máquina.
3.  Abra o terminal na pasta do projeto.
4.  Execute o comando:
    ```bash
    dotnet run
    ```

---
*Desenvolvido como parte dos meus estudos e práticas em C#.*