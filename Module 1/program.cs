/*Edwin Hared Albancando Robles */
using System;

class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Welcome to your Recipe Book!");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipes");
            Console.WriteLine("3. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    recipe.AddRecipe();
                    break;
                case "2":
                    recipe.ViewRecipes();
                    break;
                case "3":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}