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

- Random random = new Random();  
  Utiliza a classe Random da biblioteca padrão do C# para gerar um número aleatório. O método random.Next(1, 101)gera um número entre 1 (inclusive) e 101 (exclusivo), ou seja, de 1 a 100.

- int tentativa; int contador = 0; 
  Declara as variáveis que armazenarão a tentativa do usuário e o número de tentativas realizadas.

- Console.WriteLine(...) / Console.Write(...)  
  Comandos para exibir mensagens no terminal e solicitar a entrada do usuário.

- Console.ReadLine() e int.Parse(...)  
  Lê a entrada do usuário em formato de texto e converte para inteiro.

- Estrutura do...while
  Usada para garantir que o usuário faça pelo menos uma tentativa e continue tentando até acertar o número.

- Estrutura condicional if...else if...else 
  Compara a tentativa com o número secreto e imprime uma dica ou o resultado final.

### Justificativas do método adotado:

- Estrutura do...while: A estrutura do...while foi escolhida porque ela garante que o código dentro do laço será executado pelo menos uma vez. Isso é importante no caso deste jogo, pois o jogador precisa fazer ao menos uma tentativa. Além disso, o laço continuará sendo executado até que o jogador acerte o número, permitindo que o jogo aconteça de forma contínua.

- Uso da classe Random: Utilizamos a classe Random para gerar o número secreto de forma aleatória. Isso é essencial para garantir que o número a ser adivinhado seja imprevisível, criando um desafio verdadeiro para o jogador. O método random.Next(1, 101) gera um número aleatório entre 1 e 100, oferecendo um intervalo apropriado para o jogo.

- Variável contador: A variável contador serve para contar o número de tentativas feitas pelo jogador. Isso não só permite ao programa saber quando o jogador acertou, como também fornece um feedback sobre quantas tentativas foram necessárias, tornando o jogo mais envolvente e desafiador.

- Estrutura condicional if...else if...else: A lógica de comparação entre a tentativa do jogador e o número secreto é feita usando a estrutura if...else if...else. Isso permite ao programa fornecer dicas ao jogador sobre se o número secreto é maior ou menor do que o que ele tentou. Essas dicas tornam a experiência de adivinhar mais interativa e ajudam o jogador a chegar à resposta correta de maneira guiada.