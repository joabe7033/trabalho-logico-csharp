using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativa;
        int contador = 0;

        Console.WriteLine("Jogo da Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("Digite sua tentativa: ");
            tentativa = int.Parse(Console.ReadLine());
            contador++;

            if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número é maior.");
            }
            else if (tentativa > numeroSecreto)
            {
                Console.WriteLine("O número é menor.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou em {contador} tentativas.");
            }
        }
        while (tentativa != numeroSecreto);
    }
}
