using System;

namespace ExercicioDeFixacao81_Matrizes
{
    public class UserStory81
    {
        public static void Main()
        {
            Console.Write("Qual a quantidade de linhas da matriz? ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de colunas da matriz? ");
            int c = int.Parse(Console.ReadLine());

            int[,] matrix = new int[l, c];

            Console.WriteLine("\r\nPreencha a matriz com valores inteiros: ");

            for (int i = 0; i < l; i++)
            {
                string[] lineValues = Console.ReadLine().Split(" ");

                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = int.Parse(lineValues[j]);
                }
            }

            Console.Write("\r\nEscolha um valor existente na matriz: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (valor == matrix[i, j].GetHashCode())
                    {
                        Console.WriteLine("\r\nVocê escolheu a posição " + i + ", " + j);

                        if ((j - 1) >= 0)
                            Console.WriteLine("Valor à esquerda: " + matrix[i, j - 1]);

                        if ((j + 1) < c)
                        {
                            Console.WriteLine("Valor à direita: " + matrix[i, j + 1]);
                        }

                        if ((i - 1) >= 0)
                            Console.WriteLine("Valor acima: " + matrix[i - 1, j]);

                        if ((i + 1) < l)
                            Console.WriteLine("Valor abaixo: " + matrix[i + 1, j]);
                    }
                    else Console.WriteLine("Este valor não existe");
                }
            }
        }
    }
}
