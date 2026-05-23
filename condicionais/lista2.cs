using System;

namespace ExerciciosOperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("**  EXERCÍCIOS DE OPERADORES LÓGICOS - C# **");
                Console.WriteLine();
                Console.WriteLine("  1 - Número entre 1 e 10");
                Console.WriteLine("  2 - Usuário e Senha");
                Console.WriteLine("  3 - Pode Votar");
                Console.WriteLine("  4 - Aprovado com Presença");
                Console.WriteLine("  5 - Final de Semana e Chuva");
                Console.WriteLine("  6 - Triângulo Válido");
                Console.WriteLine("  7 - Categoria do Nadador");
                Console.WriteLine("  8 - Empréstimo Bancário");
                Console.WriteLine("  9 - Ano Bissexto");
                Console.WriteLine(" 10 - Nota e Comportamento");
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

        // Exercício 1 - Número entre 1 e 10
        static void Exercicio1()
        {
            Console.WriteLine("** EXERCÍCIO 1 - NÚMERO ENTRE 1 E 10 **");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 1 && numero <= 10)
            {
                Console.WriteLine("Está no intervalo");
            }
            else
            {
                Console.WriteLine("Fora do intervalo");
            }
        }

        // Exercício 2 - Usuário e Senha
        static void Exercicio2()
        {
            Console.WriteLine("** EXERCÍCIO 2 - USUÁRIO E SENHA **");
            Console.WriteLine();

            Console.Write("Digite o usuário: ");
            string usuario = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (usuario == "admin" && senha == "1234")
            {
                Console.WriteLine("Login realizado");
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorretos");
            }
        }

        // Exercício 3 - Pode Votar
        static void Exercicio3()
        {
            Console.WriteLine("** EXERCÍCIO 3 - PODE VOTAR **");
            Console.WriteLine();

            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 16 && idade < 70)
            {
                Console.WriteLine("Pode votar");
            }
            else
            {
                Console.WriteLine("Não pode votar");
            }
        }

        // Exercício 4 - Aprovado com Presença
        static void Exercicio4()
        {
            Console.WriteLine("** EXERCÍCIO 4 - APROVADO COM PRESENÇA **");
            Console.WriteLine();

            Console.Write("Digite a média do aluno: ");
            double media = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de presença: ");
            double presenca = double.Parse(Console.ReadLine());

            if (media >= 6 && presenca >= 75)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        // Exercício 5 - Final de Semana e Chuva
        static void Exercicio5()
        {
            Console.WriteLine("** EXERCÍCIO 5 - FINAL DE SEMANA E CHUVA **");
            Console.WriteLine();
            Console.WriteLine("Dias da semana: 1=Segunda ... 6=Sábado, 7=Domingo");
            Console.WriteLine();

            Console.Write("Digite o dia da semana (1 a 7): ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Está chovendo? (sim/não): ");
            string chovendo = Console.ReadLine().ToLower();

            if (dia <= 0 || dia >= 8)
            {
                Console.WriteLine("Dia inválido!");
            }

            else if ((dia == 6 || dia == 7) && chovendo == "não")
            {
                Console.WriteLine("Ótimo dia para passear!");
            }
            else
            {
                Console.WriteLine("Fique em casa.");
            }
        }

        // Exercício 6 - Triângulo Válido
        static void Exercicio6()
        {
            Console.WriteLine("** EXERCÍCIO 6 - TRIÂNGULO VÁLIDO **");
            Console.WriteLine();

            Console.Write("Digite o lado A: ");
            double ladoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            double ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            double ladoC = double.Parse(Console.ReadLine());

            if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
            {
                Console.WriteLine("Triângulo válido");
            }
            else
            {
                Console.WriteLine("Triângulo inválido");
            }
        }

        // Exercício 7 - Categoria do Nadador
        static void Exercicio7()
        {
            Console.WriteLine("** EXERCÍCIO 7 - CATEGORIA DO NADADOR **");
            Console.WriteLine();

            Console.Write("Digite a idade do nadador: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 10)
            {
                Console.WriteLine("Infantil");
            }
            else if (idade <= 15)
            {
                Console.WriteLine("Juvenil");
            }
            else if (idade <= 25)
            {
                Console.WriteLine("Junior");
            }
            else
            {
                Console.WriteLine("Adulto");
            }
        }

        // Exercício 8 - Empréstimo Bancário
        static void Exercicio8()
        {
            Console.WriteLine("** EXERCÍCIO 8 - EMPRÉSTIMO BANCÁRIO **");
            Console.WriteLine();

            Console.Write("Digite a renda mensal: R$ ");
            double rendaMensal = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da parcela: R$ ");
            double valorParcela = double.Parse(Console.ReadLine());

            double percentualParcela = (valorParcela / rendaMensal) * 100;

            if (valorParcela <= (rendaMensal * 0.30) && rendaMensal >= 1500)
            {
                Console.WriteLine("Empréstimo aprovado");
                Console.WriteLine($"(Parcela representa {percentualParcela:F2}% da renda)");
            }
            else
            {
                Console.WriteLine("Empréstimo negado");
                if (rendaMensal < 1500)
                {
                    Console.WriteLine("Motivo: Renda insuficiente (mínimo R$ 1500)");
                }
                if (valorParcela > (rendaMensal * 0.30))
                {
                    Console.WriteLine("Motivo: Parcela excede 30% da renda");
                }
            }
        }

        // Exercício 9 - Ano Bissexto
        static void Exercicio9()
        {
            Console.WriteLine("** EXERCÍCIO 9 - ANO BISSEXTO **");
            Console.WriteLine();

            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());


            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine("Ano bissexto");
            }
            else
            {
                Console.WriteLine("Ano não bissexto");
            }
        }

        // Exercício 10 - Nota e Comportamento
        static void Exercicio10()
        {
            Console.WriteLine("** EXERCÍCIO 10 - NOTA E COMPORTAMENTO **");
            Console.WriteLine();

            Console.Write("Digite a nota do aluno (0 a 10): ");
            double nota = double.Parse(Console.ReadLine());

            Console.Write("Digite o comportamento (bom/ruim): ");
            string comportamento = Console.ReadLine().ToLower();

            if (nota >= 6 && comportamento == "bom")
            {
                Console.WriteLine("Destaque da turma");
            }
            else if (nota >= 7 && comportamento == "ruim")
            {
                Console.WriteLine("Aprovado, mas precisa melhorar o comportamento");
            }
            else if (nota < 7 && comportamento == "bom")
            {
                Console.WriteLine("Reprovado, mas bom comportamento");
            }
            else
            {
                Console.WriteLine("Reprovado e comportamento ruim");
            }
        }
    }
}
