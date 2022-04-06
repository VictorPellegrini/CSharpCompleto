using System;

namespace Section0680_Matrizes
{
    public class UserStory80
    {
        public static void Main()
        {
            Console.Write("Qual a ordem da matriz? ");
            int p = int.Parse(Console.ReadLine());

            int[,] matrix = new int[p, p];
            int countNegativos = 0;

            // coletando os valores e contando os números negativos
            //for (int i = 0; i < p; i++)
            //{
            //    for (int j = 0; j < p; j++)
            //    {
            //        Console.Write("Insira um valor para a posição referente à linha " + (i + 1) + " e coluna " + (j + 1) + ": ");
            //        matrix[i, j] = int.Parse(Console.ReadLine());

            //        if (matrix[i, j] < 0)
            //            countNegativos++;
            //    }
            //}

            // outra forma de coletar os valores. sendo mais próxima da proposta do exercício.

            for (int i = 0; i < p; i++)
            {
                string[] lineValues = Console.ReadLine().Split(" ");

                for (int j = 0; j < p; j++)
                {
                    matrix[i, j] = int.Parse(lineValues[j]);

                    if (matrix[i, j] < 0)
                        countNegativos++;
                }
            }

            // imprimindo a matriz
            for (int i = 0; i < p; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < p; j++)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
            }

            // imprimindo a diagonal principal
            Console.WriteLine("\r\n\r\nA diagonal principal é composta pelos seguintes valores: ");

            for (int i = 0; i < p; i++)
            {
                Console.Write(matrix[i, i] + "  ");
            }

            //imprimindo a quantidade de números negativos
            Console.WriteLine("\r\n\r\nNúmeros negativos nesta matriz: " + countNegativos);

            Console.ReadLine();
        }
    }
}
