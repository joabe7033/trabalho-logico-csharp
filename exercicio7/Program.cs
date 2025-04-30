using System;

class SomaNumerosPares
{
    static void Main()
    {
        int[] numeros = new int[10];
        int soma = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0)
                soma += numeros[i];
        }
        Console.WriteLine($"a soma dos numeros pares é: {soma}");
    }
}
