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
                    return true;
                case "2":
                    return true;
                case "3":
                    return true;
                default:
                    Console.WriteLine("Unknown Command");
                    return false;
            }
        }

        private void RenderMenu()
        {
            Console.WriteLine("---------- Main Menu ----------\n");

            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("1. Triangle");
        }
    }
}
