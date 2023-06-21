using ShapeCalculator;
using System;

namespace ToDoListApp
{
    class Program
    {
        private static ViewMenu _menu = new ViewMenu();

        static void Main(string[] args)
        {

            bool shouldExit = false;
            while (!shouldExit)
            {
                shouldExit = _menu.MainMenu();
            }
        }
    }
}
