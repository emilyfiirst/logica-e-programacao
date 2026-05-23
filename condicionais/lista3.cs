using System;

namespace Exercicios12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("** 12 EXERCÍCIOS - C# **");
                Console.WriteLine();
                Console.WriteLine("  1 - Logaritmo de Número Positivo");
                Console.WriteLine("  2 - Média Ponderada (3 Provas)");
                Console.WriteLine("  3 - Dia da Semana");
                Console.WriteLine("  4 - Divisível por 3 ou 5");
                Console.WriteLine("  5 - Classificação de Triângulo");
                Console.WriteLine("  6 - Aposentadoria");
                Console.WriteLine("  7 - Imposto por Estado");
                Console.WriteLine("  8 - Consumo de Combustível");
                Console.WriteLine("  9 - Ordenar Três Números");
                Console.WriteLine(" 10 - Tabela de Preços");
                Console.WriteLine(" 11 - Idades (2 Homens e 2 Mulheres)");
                Console.WriteLine(" 12 - Índice de Poluição");
                Console.WriteLine("  0 - Sair");
                Console.WriteLine();
                Console.Write("Escolha um exercício: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        Exercicio1();
                        break;
                    case "2":
                        Exercicio2();
                        break;
                    case "3":
                        Exercicio3();
                        break;
                    case "4":
                        Exercicio4();
                        break;
                    case "5":
                        Exercicio5();
                        break;
                    case "6":
                        Exercicio6();
                        break;
                    case "7":
                        Exercicio7();
                        break;
                    case "8":
                        Exercicio8();
                        break;
                    case "9":
                        Exercicio9();
                        break;
                    case "10":
                        Exercicio10();
                        break;
                    case "11":
                        Exercicio11();
                        break;
                    case "12":
                        Exercicio12();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Encerrando programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (continuar && opcao != "0")
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        // Exercício 1 - Logaritmo de Número Positivo
        static void Exercicio1()
        {
            Console.WriteLine("** EXERCÍCIO 1 - LOGARITMO **");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Numero invalido");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Logaritmo de zero não existe");
            }
            else
            {
                double logaritmo = Math.Log10(numero);
                Console.WriteLine($"O logaritmo de {numero} é: {logaritmo:F4}");
            }
        }

        // Exercício 2 - Média Ponderada
        static void Exercicio2()
        {
            Console.WriteLine("** EXERCÍCIO 2 - MÉDIA PONDERADA **");
            Console.WriteLine();
            Console.WriteLine("Pesos: Prova 1 (peso 1), Prova 2 (peso 1), Prova 3 (peso 2)");
            Console.WriteLine();

            Console.Write("Digite a nota da prova 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da prova 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da prova 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            // Média ponderada = (nota1*1 + nota2*1 + nota3*2) / (1+1+2)
            double mediaPonderada = (nota1 * 1 + nota2 * 1 + nota3 * 2) / 4;

            Console.WriteLine($"\nMédia do aluno: {mediaPonderada:F2}");

            if (mediaPonderada >= 6)
            {
                Console.WriteLine("Situação: APROVADO");
            }
            else
            {
                Console.WriteLine("Situação: REPROVADO");
            }
        }

        // Exercício 3 - Dia da Semana
        static void Exercicio3()
        {
            Console.WriteLine("** EXERCÍCIO 3 - DIA DA SEMANA **");
            Console.WriteLine();

            Console.Write("Digite um número de 1 a 7: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido! Digite de 1 a 7.");
                    break;
            }
        }

        // Exercício 4 - Divisível por 3 ou 5
        static void Exercicio4()
        {
            Console.WriteLine("** EXERCÍCIO 4 - DIVISÍVEL POR 3 OU 5 **");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());


            if ((numero % 3 == 0) && (numero % 5 == 0))
            {
                Console.WriteLine($"{numero} é divisível por 3 E por 5 simultaneamente.");
                Console.WriteLine("Condição NÃO atendida (não pode ser simultaneamente).");
            }
            else if ((numero % 3 == 0))
            {
                Console.WriteLine($"{numero} é divisível por 3 (mas não por 5).");
                Console.WriteLine("Condição ATENDIDA!");
            }
            else if ((numero % 3 == 5))
            {
                Console.WriteLine($"{numero} é divisível por 5 (mas não por 3).");
                Console.WriteLine("Condição ATENDIDA!");
            }
            else
            {
                Console.WriteLine($"{numero} NÃO é divisível nem por 3 nem por 5.");
            }
        }

        // Exercício 5 - Classificação de Triângulo
        static void Exercicio5()
        {
            Console.WriteLine("** EXERCÍCIO 5 - CLASSIFICAÇÃO DE TRIÂNGULO **");
            Console.WriteLine();

            Console.Write("Digite o lado A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            double c = double.Parse(Console.ReadLine());

            // Verifica se pode ser um triângulo
            if (a < (b + c) && b < (a + c) && c < (a + b))
            {
                Console.WriteLine("\nÉ um triângulo válido!");

                // Classifica o tipo
                if (a == b && b == c)
                {
                    Console.WriteLine("Tipo: EQUILÁTERO (três lados iguais)");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Tipo: ISÓSCELES (dois lados iguais)");
                }
                else
                {
                    Console.WriteLine("Tipo: ESCALENO (três lados diferentes)");
                }
            }
            else
            {
                Console.WriteLine("\nNÃO é um triângulo válido!");
            }
        }

        // Exercício 6 - Aposentadoria
        static void Exercicio6()
        {
            Console.WriteLine("** EXERCÍCIO 6 - APOSENTADORIA **");
            Console.WriteLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o tempo de serviço (anos): ");
            int tempoServico = int.Parse(Console.ReadLine());

            if (idade >= 65)
            {
                Console.WriteLine("\nPODE SE APOSENTAR (65 anos ou mais)");
            }
            else if (tempoServico >= 30)
            {
                Console.WriteLine("\nPODE SE APOSENTAR (30 anos ou mais de serviço)");
            }
            else if (idade >= 60 && tempoServico >= 25)
            {
                Console.WriteLine("\nPODE SE APOSENTAR (60+ anos e 25+ anos de serviço)");
            }
            else
            {
                Console.WriteLine("\nNÃO PODE SE APOSENTAR ainda");
            }
        }

        // Exercício 7 - Imposto por Estado
        static void Exercicio7()
        {
            Console.WriteLine("** EXERCÍCIO 7 - IMPOSTO POR ESTADO **");
            Console.WriteLine();
            Console.WriteLine("Estados disponíveis: MG, SP, RJ, MS");
            Console.WriteLine();

            Console.Write("Digite o valor do produto: R$ ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o estado (MG/SP/RJ/MS): ");
            string estado = Console.ReadLine().ToUpper();

            double imposto = 0;
            double precoFinal = 0;
            bool estadoValido = true;

            switch (estado)
            {
                case "MG":
                    imposto = 0.07;  // 7%
                    break;
                case "SP":
                    imposto = 0.12;  // 12%
                    break;
                case "RJ":
                    imposto = 0.15;  // 15%
                    break;
                case "MS":
                    imposto = 0.08;  // 8%
                    break;
                default:
                    Console.WriteLine("\nERRO: Estado inválido!");
                    estadoValido = false;
                    break;
            }

            if (estadoValido)
            {
                precoFinal = valor + (valor * imposto);
                Console.WriteLine($"\nValor do produto: R$ {valor:F2}");
                Console.WriteLine($"Imposto ({estado}): {imposto * 100}%");
                Console.WriteLine($"Preço final: R$ {precoFinal:F2}");
            }
        }

        // Exercício 8 - Consumo de Combustível
        static void Exercicio8()
        {
            Console.WriteLine("** EXERCÍCIO 8 - CONSUMO DE COMBUSTÍVEL **");
            Console.WriteLine();

            Console.Write("Digite a distância percorrida (Km): ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de litros consumidos: ");
            double litros = double.Parse(Console.ReadLine());

            double consumo = distancia / litros;

            Console.WriteLine($"\nConsumo: {consumo:F2} Km/l");

            if (consumo < 8)
            {
                Console.WriteLine("Classificação: Venda o carro!");
            }
            else if (consumo <= 14)
            {
                Console.WriteLine("Classificação: Econômico");
            }
            else
            {
                Console.WriteLine("Classificação: Super econômico");
            }
        }

        // Exercício 9 - Ordenar Três Números
        static void Exercicio9()
        {
            Console.WriteLine("** EXERCÍCIO 9 - ORDENAR TRÊS NÚMEROS **");
            Console.WriteLine();

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int menor, meio, maior;

            if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
                if (num2 <= num3)
                {
                    meio = num2;
                    maior = num3;
                }
                else
                {
                    meio = num3;
                    maior = num2;
                }
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
                if (num1 <= num3)
                {
                    meio = num1;
                    maior = num3;
                }
                else
                {
                    meio = num3;
                    maior = num1;
                }
            }
            else
            {
                menor = num3;
                if (num1 <= num2)
                {
                    meio = num1;
                    maior = num2;
                }
                else
                {
                    meio = num2;
                    maior = num1;
                }
            }

            Console.WriteLine($"\nNúmeros em ordem crescente: {menor}, {meio}, {maior}");
        }

        // Exercício 10 - Tabela de Preços
        static void Exercicio10()
        {
            Console.WriteLine("** EXERCÍCIO 10 - TABELA DE PREÇOS **");
            Console.WriteLine();
            Console.WriteLine("Produtos disponíveis:");
            Console.WriteLine("  abcd - R$ 5,30");
            Console.WriteLine("  xypk - R$ 6,00");
            Console.WriteLine("  klmp - R$ 3,20");
            Console.WriteLine("  qrst - R$ 2,50");
            Console.WriteLine();

            Console.Write("Digite o código do produto: ");
            string codigo = Console.ReadLine().ToLower();

            Console.Write("Digite a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            double preco = 0;
            bool codigoValido = true;

            switch (codigo)
            {
                case "abcd":
                    preco = 5.30;
                    break;
                case "xypk":
                    preco = 6.00;
                    break;
                case "klmp":
                    preco = 3.20;
                    break;
                case "qrst":
                    preco = 2.50;
                    break;
                default:
                    Console.WriteLine("\nCódigo inválido!");
                    codigoValido = false;
                    break;
            }

            if (codigoValido)
            {
                double total = preco * quantidade;
                Console.WriteLine($"\nPreço unitário: R$ {preco:F2}");
                Console.WriteLine($"Quantidade: {quantidade}");
                Console.WriteLine($"Preço total: R$ {total:F2}");
            }
        }

        // Exercício 11 - Idades (2 Homens e 2 Mulheres)
        static void Exercicio11()
        {
            Console.WriteLine("** EXERCÍCIO 11 - IDADES (2 HOMENS E 2 MULHERES) **");
            Console.WriteLine();

            Console.Write("Digite a idade do homem 1: ");
            int homem1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade do homem 2: ");
            int homem2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da mulher 1: ");
            int mulher1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade da mulher 2: ");
            int mulher2 = int.Parse(Console.ReadLine());

            int homemMaisVelho, homemMaisNovo;
            if (homem1 > homem2)
            {
                homemMaisVelho = homem1;
                homemMaisNovo = homem2;
            }
            else
            {
                homemMaisVelho = homem2;
                homemMaisNovo = homem1;
            }

            int mulherMaisVelha, mulherMaisNova;
            if (mulher1 > mulher2)
            {
                mulherMaisVelha = mulher1;
                mulherMaisNova = mulher2;
            }
            else
            {
                mulherMaisVelha = mulher2;
                mulherMaisNova = mulher1;
            }

            // Soma: homem mais velho + mulher mais nova
            int soma = homemMaisVelho + mulherMaisNova;

            // Produto: homem mais novo * mulher mais velha
            int produto = homemMaisNovo * mulherMaisVelha;

            Console.WriteLine($"\nHomem mais velho + Mulher mais nova = {homemMaisVelho} + {mulherMaisNova} = {soma}");
            Console.WriteLine($"Homem mais novo × Mulher mais velha = {homemMaisNovo} × {mulherMaisVelha} = {produto}");
        }

        // Exercício 12 - Índice de Poluição
        static void Exercicio12()
        {
            Console.WriteLine("**EXERCÍCIO 12 - ÍNDICE DE POLUIÇÃO **");
            Console.WriteLine();
            Console.WriteLine("Índice aceitável: 0,05 a 0,25");
            Console.WriteLine();

            Console.Write("Digite o índice de poluição: ");
            double indice = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (indice >= 0.5)
            {
                Console.WriteLine("ALERTA CRÍTICO: Índice 0,5 ou mais");
                Console.WriteLine("Notificação: TODOS OS GRUPOS (1, 2 e 3) devem paralisar suas atividades!");
            }
            else if (indice >= 0.4)
            {
                Console.WriteLine("ALERTA: Índice 0,4");
                Console.WriteLine("Notificação: GRUPOS 1 e 2 devem suspender suas atividades!");
            }
            else if (indice >= 0.3)
            {
                Console.WriteLine("ALERTA: Índice 0,3");
                Console.WriteLine("Notificação: GRUPO 1 deve suspender suas atividades!");
            }
            else if (indice >= 0.05 && indice <= 0.25)
            {
                Console.WriteLine("Índice aceitável. Nenhuma ação necessária.");
            }
            else if (indice < 0.05)
            {
                Console.WriteLine("Índice abaixo do aceitável.");
            }
            else
            {
                Console.WriteLine("Índice acima do aceitável mas abaixo de 0,3.");
            }
        }
    }
}
