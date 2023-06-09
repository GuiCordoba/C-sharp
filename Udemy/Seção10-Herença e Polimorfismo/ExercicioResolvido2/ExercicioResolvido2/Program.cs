﻿using System;
using System.Globalization;
using ExercicioResolvido2.Entities;
using ExercicioResolvido2.Entities.Enums;

namespace ExercicioResolvido2
{
    internal class Program

    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shape: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (shape == 'r')
                {
                    Console.Write("Widht: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(widht, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape sh in list) 
            {
                Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}