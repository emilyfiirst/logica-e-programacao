
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            exercicio8();
            
        }

        static void exercicio1()
        {
            int tamanho = 5, soma = 0;

            int[] array = new int[tamanho];

            for(int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe um valor: ");
                array[i] = int.Parse(Console.ReadLine());
                soma += array[i];
            }

            Console.WriteLine(soma);

        }
        static void exercicio2()
        {
            int tamanho = 10;

            int[] array = new int[tamanho];

            for(int i = 0; i < tamanho; i++)
            {
                Console.Write("Informe um valor: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int menor = array[0];
            int maior = array[0];
            int indiceMenor = 0, indiceMaior = 0;

            for (int i = 1; i < tamanho; i++)
            {
                if (array[i] > maior)
                    indiceMaior = i;


                else if (array[i] < menor)
                    indiceMenor = i;
            }

            Console.WriteLine($"Menor valor {array[indiceMenor]} que está no indice {indiceMenor}");
            Console.WriteLine($"Maior valor {array[indiceMaior]} que está no indice {indiceMaior}");

        }
        static void exercicio3()
        {
            int tamanho = 8;

            int[] array = new int[tamanho];
            
            for(int i = 0;i < tamanho; i++)
            {
                Console.Write("Informe um valor: ");
                array[i] += int.Parse(Console.ReadLine());
            }

            for (int i = tamanho-1; i>=0; i--)
            {
                Console.WriteLine(array[i]);
            } 
        }
        static void exercicio4()
        {
            int tamanho = 15;
            int impar = 0, par = 0;
            int[] array = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Informe um valor: ");
                array[i] += int.Parse(Console.ReadLine());
                if (array[i] % 2 == 0) par++;
                else impar++;
            }

            Console.WriteLine("Quantidade impar: " + impar);
            Console.WriteLine("Quantidade par: " + par);


            
        }
        static void exercicio5()
        {
            int tamanho = 5;

            int[] array = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Informe um valor: ");
                array[i] += int.Parse(Console.ReadLine());
            }

            Console.Write("Informe um vaolor para busca: ");
            int numeroBusca = int.Parse(Console.ReadLine());
            bool existe = false;
            for (int i = 0; i < tamanho; i++)
            {
                if (array[i] == numeroBusca)
                {
                    Console.WriteLine("O número existe! Na posição: " + i);
                    existe = true;
                }

               
            }
            if (!existe)
            {
                Console.WriteLine("Número não encontrado");
            }


        }
        static void exercicio6()
        {
            int tamanho = 5;
            double somatorio = 0;
            double[] array = new double[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Informe uma nota: ");
                array[i] += double.Parse(Console.ReadLine());
                somatorio += array[i];
            }

            double media = somatorio / tamanho;
            int acimaMedia = 0, abaixoMedia = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (array[i] > media) { acimaMedia++; }
                else if (array[i] < media){ abaixoMedia++; }
            }

            Console.WriteLine("Abaixo da média: " + acimaMedia);
            Console.WriteLine("Acima da média: " + abaixoMedia);
        }
        static void exercicio7()
        {
            int tamanho = 5;
            int[] array = new int[] { 1, 2, 2, 3, 3};

            int[] valoresNicos = new int[tamanho];
            int tamanhoReal = 0;
            bool duplicado = false;

            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanhoReal; j++)
                {
                    if (valoresNicos[j] == array[i])
                    {
                        duplicado = true;
                        break;
                    }
                }
                if (!duplicado)
                {
                    valoresNicos[tamanhoReal] = array[i];
                    tamanhoReal++;
                }
                
                duplicado = false;
            }

            for (int i = 0; i < tamanhoReal; i++)
            {
                Console.WriteLine(valoresNicos[i]);
            }

        }

        static void exercicio8()
        {

            int tamanho = 10;
            int[] array = new int[tamanho];
            int[] novoArray = new int[tamanho];
            int tamanhoReal = 0;

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Informe um valor: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Informe um valor maior: ");
            int valor = int.Parse(Console.ReadLine());


            for (int i = 0; i < tamanho; i++)
            {
                if (array[i] > valor)
                {
                    novoArray[tamanhoReal] = array[i];
                    tamanhoReal++;
                }

            }

            Console.WriteLine("Itens do array maiores que " + valor);

            for (int i = 0; i < tamanhoReal; i++)
            {
                Console.WriteLine(novoArray[i]);
            }
        }
    }
}
