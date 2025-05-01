# Documentação Detalhada

## Exercício 9 – Jogo da Adivinhação

### Passo a passo lógico para a resolução:
1. Gerar um número aleatório entre 1 e 100, que será o número que o usuário precisa adivinhar.
2. Solicitar ao usuário que digite uma tentativa.
3. Comparar a tentativa com o número secreto:
   - Se for menor, informar que o número secreto é maior.
   - Se for maior, informar que o número secreto é menor.
   - Se for igual, informar que ele acertou e mostrar o número de tentativas.
4. Repetir o processo até que o usuário acerte.
5. Contar o número de tentativas realizadas.

### Estruturas e comandos utilizados:

- `Random random = new Random();`  
  Utiliza a classe `Random` da biblioteca padrão do C# para gerar um número aleatório. O método `random.Next(1, 101)` gera um número entre 1 (inclusive) e 101 (exclusivo), ou seja, de 1 a 100.

- `int tentativa; int contador = 0;`  
  Declara as variáveis que armazenarão a tentativa do usuário e o número de tentativas realizadas.

- `Console.WriteLine(...)` / `Console.Write(...)`  
  Comandos para exibir mensagens no terminal e solicitar a entrada do usuário.

- `Console.ReadLine()` e `int.Parse(...)`  
  Lê a entrada do usuário em formato de texto e converte para inteiro.

- Estrutura `do...while`  
  Usada para garantir que o usuário faça pelo menos uma tentativa e continue tentando até acertar o número.

- Estrutura condicional `if...else if...else`  
  Compara a tentativa com o número secreto e imprime uma dica ou o resultado final.

### Justificativas do método adotado:

- A escolha da estrutura `do...while` garante que o bloco de tentativas seja executado pelo menos uma vez, o que é ideal para esse tipo de jogo.
- O uso da classe `Random` é adequado para gerar números de forma imprevisível, simulando o comportamento de um "número secreto".
- A variável `contador` permite contabilizar as tentativas, o que torna o jogo mais interessante e oferece feedback ao usuário.
- A lógica de comparação com `if` permite dar dicas ao jogador (se o número é maior ou menor), tornando a experiência mais interativa e guiada.
