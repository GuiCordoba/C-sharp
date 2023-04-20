﻿namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Estudantes[] vect = new Estudantes[10];

            Console.WriteLine("----------Bem-Vindo ao pensionato da dona Maria----------");
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudantes (nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados: ");
            for(int i = 0; i < 10;i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }

            }


        }
    }
}