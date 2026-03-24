 # Password Checker

Fiz esse script via terminal para checar a força de uma senha. Ele pega o input do usuário, compara com alguns critérios e devolve uma pontuação.

## Stack/Tecnologia
- C#

## O que ele faz
A lógica é bem simples:
- Define os critérios (tamanho mínimo, maiúsculas, minúsculas, números e caracteres especiais).
- Passa a senha por uma sequência de `if`s. Cada critério atendido soma 1 ponto.
- No final, joga o score num `switch` que avisa se a senha é fraca, média ou forte (pontuação de 0 a 5).

## Desafios
- Fiquei quebrando a cabeça pra decidir qual sistema de pontuação usar e como montar as regras de comparação foi meio chato.
- A sintaxe do `switch` e as regras dele eram novidade pra mim, então apanhei um pouco no final até fazer compilar direito, mas acabou funcionando.