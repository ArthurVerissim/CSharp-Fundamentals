# 🖋️ Historia Interativo em C#

Este é um projeto desenvolvido em **C#** que automatiza a criação de uma história interativa baseada nas entradas fornecidas pelo usuário. O objetivo é transformar palavras isoladas de diferentes classes gramaticais (como substantivos, verbos e adjetivos) em uma narrativa coesa e cômica, garantindo que cada termo inserido ocupe o lugar gramatical correto dentro de um roteiro predefinido.

## 📝 Sobre o Projeto

O programa funciona através da captura de dados via console, onde o usuário fornece informações sem conhecer o contexto final da trama. A lógica principal do projeto consiste em:

1.  **Coleta Estruturada:** Solicitar variáveis específicas (nomes, animais, objetos e lugares).
2.  **Processamento Dinâmico:** Utilizar a técnica de **Interpolação de Strings** para injetar as respostas do usuário em lacunas estratégicas do texto.
3.  **Saída de Dados:** Gerar um parágrafo final onde a combinação de palavras aleatórias com um contexto fixo resulta em uma história imprevisível.

## 🛠️ Tecnologias e Conceitos Aplicados

* **Manipulação de Strings:** Uso de `$""` (Interpolação) para manter o código limpo e evitar concatenações complexas.
* **Interação em Tempo Real:** Fluxo de Entrada e Saída (I/O) utilizando `Console.ReadLine()` e `Console.Write()`.
* **Gerenciamento de Variáveis:** Organização de dados do tipo `string` para representar diferentes partes do discurso.
* **Ecossistema .NET:** Estrutura de projeto console multiplataforma.

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
Desenvolvido como parte de estudos em C#.