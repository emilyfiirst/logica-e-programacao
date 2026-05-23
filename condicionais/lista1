using System;

namespace ExerciciosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("**  EXERCÍCIOS DE ESTRUTURAS CONDICIONAIS - C# **");
                Console.WriteLine();
                Console.WriteLine("  1 - Positivo ou Negativo");
                Console.WriteLine("  2 - Número Maior");
                Console.WriteLine("  3 - Senha Correta");
                Console.WriteLine("  4 - Caixa Eletrônico");
                Console.WriteLine("  5 - Dia de Semana ou Fim de Semana");
                Console.WriteLine("  6 - Classificação de Temperatura");
                Console.WriteLine("  7 - Desconto na Compra");
                Console.WriteLine("  8 - Calculadora Simples");
                Console.WriteLine("  9 - Classificação do IMC");
                Console.WriteLine(" 10 - Jogo de Pedra, Papel e Tesoura");
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

        // Exercício 1 - Positivo ou Negativo
        static void Exercicio1()
        {
            Console.WriteLine("** EXERCÍCIO 1 - POSITIVO OU NEGATIVO **");
            Console.WriteLine();

            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }

        // Exercício 2 - Número Maior
        static void Exercicio2()
        {
            Console.WriteLine("** EXERCÍCIO 2 - NÚMERO MAIOR **");
            Console.WriteLine();

            Console.Write("Digite o primeiro número inteiro: ");
            int primeiro = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            int segundo = int.Parse(Console.ReadLine());

            if (primeiro > segundo)
            {
                Console.WriteLine("O primeiro número é maior");
            }
            else
            {
                Console.WriteLine("O segundo número é maior");
            }
        }

        // Exercício 3 - Senha Correta
        static void Exercicio3()
        {
            Console.WriteLine("** EXERCÍCIO 3 - SENHA CORRETA **");
            Console.WriteLine();

            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            if (senha == 1234)
            {
                Console.WriteLine("Acesso permitido");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
        }

        // Exercício 4 - Caixa Eletrônico
        static void Exercicio4()
        {
            Console.WriteLine("** EXERCÍCIO 4 - CAIXA ELETRÔNICO **");
            Console.WriteLine();

            Console.Write("Digite o saldo da conta: R$ ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do saque: R$ ");
            double valorSaque = double.Parse(Console.ReadLine());

            if (valorSaque <= saldo)
            {
                double novoSaldo = saldo - valorSaque;
                Console.WriteLine("Saque realizado com sucesso");
                Console.WriteLine($"Novo saldo: R$ {novoSaldo:F2}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        // Exercício 5 - Dia de Semana ou Fim de Semana
        static void Exercicio5()
        {
            Console.WriteLine("** EXERCÍCIO 5 - DIA DE SEMANA OU FIM DE SEMANA **");
            Console.WriteLine();
            Console.WriteLine("1 = Segunda, 2 = Terça, 3 = Quarta, 4 = Quinta");
            Console.WriteLine("5 = Sexta, 6 = Sábado, 7 = Domingo");
            Console.WriteLine();

            Console.Write("Digite um número de 1 a 7: ");
            int dia = int.Parse(Console.ReadLine());

            if (dia == 6 || dia == 7)
            {
                Console.WriteLine("Fim de semana");
            }
            else
            {
                Console.WriteLine("Dia útil");
            }
        }

        // Exercício 6 - Classificação de Temperatura
        static void Exercicio6()
        { 
            Console.WriteLine("** EXERCÍCIO 6 - CLASSIFICAÇÃO DE TEMPERATURA  **");
            Console.WriteLine();

            Console.Write("Digite a temperatura em °C: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (temperatura > 30)
            {
                Console.WriteLine("Calor");
            }
            else if (temperatura > 18)
            {
                Console.WriteLine("Agradável");
            }
            else
            {
                Console.WriteLine("Frio");
            }
        }

        // Exercício 7 - Desconto na Compra
        static void Exercicio7()
        {
            Console.WriteLine("** EXERCÍCIO 7 - DESCONTO NA COMPRA **");
            Console.WriteLine();

            Console.Write("Digite o valor da compra: R$ ");
            double valorCompra = double.Parse(Console.ReadLine());

            if (valorCompra >= 200)
            {
                double valorFinal = valorCompra - (valorCompra * 0.1); // 10% de desconto
                Console.WriteLine($"Desconto de 10% aplicado!");
                Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
            }
            else if (valorCompra >= 100)
            {
                double valorFinal = valorCompra - (valorCompra * 0.05); // 5% de desconto
                Console.WriteLine($"Desconto de 5% aplicado!");
                Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
            }
            else
            {
                Console.WriteLine("Sem desconto");
                Console.WriteLine($"Valor final: R$ {valorCompra:F2}");
            }
        }

        // Exercício 8 - Calculadora Simples
        static void Exercicio8()
        {
            Console.WriteLine("** EXERCÍCIO 8 - CALCULADORA SIMPLES **");
            Console.WriteLine();

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a operação (+, -, *, /): ");
            string operacao = Console.ReadLine();

            if (operacao == "+")
            {
                Console.WriteLine($"Resultado: {num1 + num2}");
            }
            else if (operacao == "-")
            {
                Console.WriteLine($"Resultado: {num1 - num2}");
            }
            else if (operacao == "*")
            {
                Console.WriteLine($"Resultado: {num1 * num2}");
            }
            else if (operacao == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Erro: divisão por zero");
                }
                else
                {
                    Console.WriteLine($"Resultado: {num1 / num2}");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
        }

        // Exercício 9 - Classificação do IMC
        static void Exercicio9()
        {
            Console.WriteLine("** EXERCÍCIO 9 - CLASSIFICAÇÃO DO IMC **");
            Console.WriteLine();

            Console.Write("Digite o peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"\nIMC calculado: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade");
            }
        }

        // Exercício 10 - Jogo de Pedra, Papel e Tesoura
        static void Exercicio10()
        {
            Console.WriteLine("** EXERCÍCIO 10 - PEDRA, PAPEL E TESOURA **");
            Console.WriteLine();

            Console.Write("Jogador 1, escolha (pedra/papel/tesoura): ");
            string jogador1 = Console.ReadLine().ToLower();

            Console.Write("Jogador 2, escolha (pedra/papel/tesoura): ");
            string jogador2 = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (jogador1 == jogador2)
            {
                Console.WriteLine("Empate");
            }
            else if (jogador1 == "pedra" && jogador2 == "tesoura")
            {
                Console.WriteLine("Jogador 1 venceu - pedra ganha de tesoura");
            }
            else if (jogador1 == "pedra" && jogador2 == "papel")
            {
                Console.WriteLine("Jogador 2 venceu - papel ganha de pedra");
            }
            else if (jogador1 == "papel" && jogador2 == "pedra")
            {
                Console.WriteLine("Jogador 1 venceu - papel ganha de pedra");
            }
            else if (jogador1 == "papel" && jogador2 == "tesoura")
            {
                Console.WriteLine("Jogador 2 venceu - tesoura ganha de papel");
            }
            else if (jogador1 == "tesoura" && jogador2 == "papel")
            {
                Console.WriteLine("Jogador 1 venceu - tesoura ganha de papel");
            }
            else if (jogador1 == "tesoura" && jogador2 == "pedra")
            {
                Console.WriteLine("Jogador 2 venceu - pedra ganha de tesoura");
            }
            else
            {
                Console.WriteLine("Escolha inválida! Use: pedra, papel ou tesoura");
            }
        }
    }
}
