using System;
using System.Collections.Generic;
class CadastroProdutos
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();
         for (int i = 0; i < 3; i++)
        {
            Produto p = new Produto();

            Console.WriteLine($"produto {i + 1}:");
            Console.Write("nome: ");
            p.nome = Console.ReadLine();

            Console.Write("preço: ");
            p.preco = double.Parse(Console.ReadLine());

            Console.Write("quantidade: ");
            p.quantidade = int.Parse(Console.ReadLine());

            produtos.Add(p);
            Console.WriteLine();
        }

        Console.WriteLine("produtos cadastrados:");
        foreach (var p in produtos)
        {
            Console.WriteLine($"nome: {p.nome} preço: {p.preco:C2} quantidade: {p.quantidade} total: {p.valorTotal():C2}");
        }
    }
}