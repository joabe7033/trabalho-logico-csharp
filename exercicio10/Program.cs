using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluida = new List<bool>();
        string opcao;

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Adicionar nova tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Marcar tarefa como concluída");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a nova tarefa: ");
                    string novaTarefa = Console.ReadLine();
                    tarefas.Add(novaTarefa);
                    concluida.Add(false);
                    break;

                case "2":
                    Console.WriteLine("\nLista de Tarefas:");
                    for (int i = 0; i < tarefas.Count; i++)
                    {
                        string status = concluida[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                    }
                    break;

                case "3":
                    Console.Write("Digite o número da tarefa a marcar como concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tarefas.Count)
                    {
                        concluida[indice - 1] = true;
                        Console.WriteLine("Tarefa marcada como concluída.");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;

                case "0":
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != "0");
    }
}
