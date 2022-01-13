using System;

namespace ExercicioDeFixacao71
{
    public class UserStory71
    {
        static void Main(string[] args)
        {
            Quarto[] vect = new Quarto[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\r\nLocação " + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Quarto (1 a 10): ");
                int codigo = int.Parse(Console.ReadLine());

                vect[(codigo - 1)] = new Quarto { Reservista = nome, Email = email, Codigo = codigo };
            }

            Console.WriteLine("\r\nQuartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }

            }
        }
    }
}
