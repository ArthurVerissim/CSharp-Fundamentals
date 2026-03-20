# 💰 Conversor de Moedas

Este é um projeto desenvolvido em **C#** que calcula a quantidade mínima de moedas necessárias para representar um valor inserido pelo usuário. O objetivo é evitar que o usuário receba muitas moedas pequenas quando moedas de maior valor poderiam ser utilizadas.

## 🚀 Funcionalidades
* Recebe um valor decimal via console.
* Calcula a distribuição ideal entre três tipos de moedas:
    * **Ouro:** 10 centavos
    * **Prata:** 5 centavos
    * **Bronze:** 1 centavo
* Exibe o resultado detalhado no terminal.

## 🧠 Conceitos Aplicados
Para construir este projeto, utilizei conceitos fundamentais de lógica e matemática computacional:

* **Operador de Módulo (`%`):** Essencial para capturar o "resto" de uma divisão e passá-lo para a próxima etapa do cálculo.
* **Arredondamento (`Math.Floor`):** Utilizado para garantir que apenas números inteiros de moedas sejam contabilizados.
* **Conversão de Tipos (Type Casting):** Manipulação de entradas de texto (`string`) para números reais (`double`).
* **Algoritmo Guloso (Greedy Algorithm):** Uma estratégia que sempre escolhe a melhor opção imediata (a maior moeda disponível) para resolver o problema de forma eficiente.



## 🛠️ Como Executar
1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone o repositório:
   ```bash
   git clone [https://github.com/seu-usuario/money-maker.git](https://github.com/seu-usuario/money-maker.git)