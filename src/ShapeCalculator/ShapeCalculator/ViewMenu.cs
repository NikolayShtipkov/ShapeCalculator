﻿using ShapeCalculator.Shapes;

namespace ShapeCalculator
{
    public class ViewMenu
    {
        public bool MainMenu()
        {
            RenderMenu();

            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    CircleInput();
                    return false;
                case "2":
                    return false;
                case "3":
                    return false;
                case "4":
                    return true;
                default:
                    Console.WriteLine("Unknown Command\n");
                    return false;
            }
        }

        private void RenderMenu()
        {
            Console.WriteLine("---------- Main Menu ----------\n");

            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Exit\n");
        }

        private bool CircleInput()
        {
            Console.Write("What is the radius: ");
            var input = Console.ReadLine();
            Console.WriteLine();

            double radius = 0;

            bool isNumber = double.TryParse(input, out radius);
            if (!isNumber)
            {
                Console.WriteLine("Invalid Input\n");

                return true;
            }

            Circle circle = new Circle(radius);
            double area = circle.GetArea();
            double circumference = circle.GetCircumference();

            Console.WriteLine("Area: " + Math.Round(area, 2));
            Console.WriteLine("Circumference: " + Math.Round(circumference, 2));

            return true;
        }
    }
}
