using System;

class Desafio
{
    static void Main()
    {
        Console.Write("Digite a quantidade de lanches: ");
        int qtdLanche = int.Parse(Console.ReadLine());

        Console.Write("Digite o preço do lanche: ");
        double precoLanche = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de sucos: ");
        double qtdSuco = double.Parse(Console.ReadLine());

        Console.Write("Digite o preço do suco: ");
        double precoSuco = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de sombremesas: ");
        int qtdSobremesa = int.Parse(Console.ReadLine());

        Console.Write("Digite o preço unitário da sobremesa: ");
        double precoSobremesa = double.Parse(Console.ReadLine());

        Console.Write("Digite o número de pessoas: ");
        int numeroPessoas = int.Parse(Console.ReadLine());

        double totalLanches = qtdLanche * precoLanche;
        double totalSobremesa = qtdSobremesa * precoSobremesa;
        double totalSucos = qtdSuco * precoSuco;
        double total = totalLanches + totalSucos + totalSobremesa;
        double valorPorPessoa = total / numeroPessoas;

        Console.WriteLine();
        Console.WriteLine("--- Resumo da Conta ---");
        Console.WriteLine($"Lanches: R$ {totalLanches:F2}");
        Console.WriteLine($"Sucos: R$ {totalSucos:F2}");
        Console.WriteLine($"Sobremesas: R$ {totalSobremesa:F2}");
        Console.WriteLine($"Total: R$ {total:F2}");
        Console.WriteLine($"Valor por pessoa: R$ {valorPorPessoa:F2}");
    }
}