using System;
using System.Text;
using System.Globalization;

class VerificadorPalindromo
{
    static void Main()
    {
        Console.Write("digite uma palavra: ");
        string? texto = Console.ReadLine();
        string corrigido = remover(texto).ToLower().Replace(" ", "");
        char[] arrayChar = corrigido.ToCharArray();
        Array.Reverse(arrayChar);
        string invertido = new string(arrayChar);
        if (corrigido== invertido)
            Console.WriteLine("é um palíndromo");
        else
            Console.WriteLine("não é um palíndromo");
    }
    static string remover(string texto)
    {    
        return new string(texto.Normalize(NormalizationForm.FormD).ToCharArray()
        .Where(c => CharUnicodeInfo.GetUnicodeCategory(c)
         != UnicodeCategory.NonSpacingMark).ToArray());
    }
}