using System;

class Matrizes { 


    static void Main()
    {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
            Exercicio5();
            Exercicio6();
            Exercicio7();
            Exercicio8();
            Exercicio9();
    }   

    static void Exercicio1()
    {
        Console.WriteLine("*** Exercício 1 - Soma de Matriz 3x3 ***");

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int soma = 0;

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                soma += matriz[i, j];

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{matriz[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine("Soma de todos os elementos: " + soma);
        Console.WriteLine();
    }

    static void Exercicio2()
    {
        Console.WriteLine("*** Exercício 2 - Maior Valor em Matriz 2x4 ***");

        int[,] matriz = {
            { 14, 3, 27, 8 },
            { 5, 99, 11, 42 }
        };

        int maior = matriz[0, 0];
        int linhaDoMaior = 0, colunaDoMaior = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                    linhaDoMaior = i;
                    colunaDoMaior = j;
                }
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write($"{matriz[i, j],5}");
            Console.WriteLine();
        }

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Linha: " + linhaDoMaior + "+ Coluna: " + colunaDoMaior);
        Console.WriteLine();
    }

    static void Exercicio3()
    {
        Console.WriteLine("*** Exercício 3 - Pares e Ímpares em Matriz 3x2 ***");

        int[,] matriz = {
            { 4, 7 },
            { 2, 9 },
            { 6, 3 }
        };

        int pares = 0, impares = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (matriz[i, j] % 2 == 0)
                    pares++;
                else
                    impares++;
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write($"{matriz[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine("Relatório Final:");
        Console.WriteLine("Números pares: " + pares);
        Console.WriteLine("Números ímpares: " + impares);
        Console.WriteLine();
    }

    static void Exercicio4()
    {
        Console.WriteLine("*** Exercício 4 - Multiplicação de Matriz por Escalar ***");

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int multiplicador = 3;

        int[,] resultado = new int[2, 3];

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 3; j++)
                resultado[i, j] = matriz[i, j] * multiplicador;

        Console.WriteLine("Matriz original:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{matriz[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine("Multiplicador: " + multiplicador);

        Console.WriteLine("Matriz resultante:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{resultado[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void Exercicio5()
    {
        Console.WriteLine("*** Exercício 5 - Diagonal Principal de Matriz 4x4 ***");

        int[,] matriz = {
            {  1,  2,  3,  4 },
            {  5,  6,  7,  8 },
            {  9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write($"{matriz[i, j],4}");
            Console.WriteLine();
        }

        Console.Write("Diagonal principal: ");
        for (int i = 0; i < 4; i++)
            Console.Write($"{matriz[i, i]}  ");

        Console.WriteLine();
    }

    static void Exercicio6()
    {
        Console.WriteLine("*** Exercício 6 - Soma de Duas Matrizes 2x2 ***");

        int[,] matrizA = {
            { 1, 2 },
            { 3, 4 }
        };

        int[,] matrizB = {
            { 5, 6 },
            { 7, 8 }
        };

        int[,] matrizC = new int[2, 2];

        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                matrizC[i, j] = matrizA[i, j] + matrizB[i, j];

        Console.WriteLine("Matriz A:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write($"{matrizA[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine("Matriz B:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write($"{matrizB[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine("Matriz C (A + B):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
                Console.Write($"{matrizC[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void Exercicio7()
    {
        Console.WriteLine("*** Exercício 7 - Linha com Maior Soma em Matriz 3x3 **");

        int[,] matriz = {
            { 1, 2, 3 },
            { 9, 8, 7 },
            { 4, 5, 6 }
        };

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{matriz[i, j],4}");
            Console.WriteLine();
        }

        int maiorSoma = -1;
        int linhaMaiorSoma = 0;

        for (int i = 0; i < 3; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 3; j++)
                somaLinha += matriz[i, j];

            Console.WriteLine("Soma da linha " + i + ": " + somaLinha);

            if (somaLinha > maiorSoma)
            {
                maiorSoma = somaLinha;
                linhaMaiorSoma = i;
            }
        }

        Console.WriteLine("A linha com maior soma é a linha " + linhaMaiorSoma + " soma = " + maiorSoma);
        Console.WriteLine();
    }

    static void Exercicio8()
    {
        Console.WriteLine("*** Exercício 8 - Verificação de Matriz Identidade 3x3 ***");

        int[,] matriz = {
            { 1, 0, 0 },
            { 0, 1, 0 },
            { 0, 0, 1 }
        };

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{matriz[i, j],3}");
            Console.WriteLine();
        }

        bool ehIdentidade = true;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j && matriz[i, j] != 1)
                {
                    ehIdentidade = false;
                    break;
                }
                if (i != j && matriz[i, j] != 0)
                {
                    ehIdentidade = false;
                    break;
                }
            }
            if (!ehIdentidade) break;
        }

        if (ehIdentidade)
            Console.WriteLine("A matriz É uma matriz identidade.");
        else
            Console.WriteLine("A matriz NÃO é uma matriz identidade.");

        Console.WriteLine();
    }

   
    static void Exercicio9()
    {
        Console.WriteLine("*** Exercício 9 - Multiplicação Elemento a Elemento (3x3) ***");

        int[,] matrizA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int[,] matrizB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

        int[,] matrizC = new int[3, 3];

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                matrizC[i, j] = matrizA[i, j] * matrizB[i, j];

        Console.WriteLine("Matriz A:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{matrizA[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine("Matriz B:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{matrizB[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine("Matriz C = A * B (elemento a elemento):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
                Console.Write($"{matrizC[i, j],4}");
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
