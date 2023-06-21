using ShapeCalculator.Shapes;

namespace ShapeCalculator
{
    public class ViewMenu
    {
        public bool MainMenu()
        {
            RenderMenu();

            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    CircleInput();
                    return false;
                case "2":
                    SquareInput();
                    return false;
                case "3":
                    TriangleInput();
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
            Console.Write("What is the radius of the circle: ");
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
            Console.WriteLine("Circumference: " + Math.Round(circumference, 2) + "\n");

            return true;
        }

        private bool SquareInput()
        {
            Console.Write("What is the length of the sqare: ");
            var input = Console.ReadLine();
            Console.WriteLine();

            double length = 0;

            bool isNumber = double.TryParse(input, out length);
            if (!isNumber)
            {
                Console.WriteLine("Invalid Input\n");

                return true;
            }

            Square square = new Square(length);
            double area = square.GetArea();
            double circumference = square.GetCircumference();

            Console.WriteLine("Area: " + Math.Round(area, 2));
            Console.WriteLine("Circumference: " + Math.Round(circumference, 2) + "\n");

            return true;
        }

        private bool TriangleInput()
        {
            Console.Write("What is the length of the triangle: ");
            var input = Console.ReadLine();
            Console.WriteLine();

            double length = 0;

            bool isNumber = double.TryParse(input, out length);
            if (!isNumber)
            {
                Console.WriteLine("Invalid Input\n");

                return true;
            }

            Triangle square = new Triangle(length);
            double area = square.GetArea();
            double circumference = square.GetCircumference();

            Console.WriteLine("Area: " + Math.Round(area, 2));
            Console.WriteLine("Circumference: " + Math.Round(circumference, 2) + "\n");

            return true;
        }
    }
}
