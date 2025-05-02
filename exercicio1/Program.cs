using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma senha: ");
        string senha = Console.ReadLine();

        bool temMaiuscula = false;
        bool temNumero = false;
        bool temEspecial = false;

        foreach (char c in senha)
        {
            if (char.IsUpper(c))
                temMaiuscula = true;
            else if (char.IsDigit(c))
                temNumero = true;
            else if (!char.IsLetterOrDigit(c))
                temEspecial = true;
        }

        if (senha.Length >= 8 && temMaiuscula && temNumero && temEspecial)
        {
            Console.WriteLine("Senha forte!");
        }
        else
        {
            Console.WriteLine("Senha fraca. A senha precisa ter:");
            Console.WriteLine("- Pelo menos 8 caracteres");
            Console.WriteLine("- Pelo menos uma letra maiúscula");
            Console.WriteLine("- Pelo menos um número");
            Console.WriteLine("- Pelo menos um caractere especial");
        }
    }
}
