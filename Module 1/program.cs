/*Edwin Hared Albancando Robles */
using System;

class Program
{
    static void Main(string[] args)
    {
        RecipeBook recipebook = new RecipeBook();
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Welcome to your Recipe Book!");
            Console.WriteLine("1. Add a newRecipe");
            Console.WriteLine("2. Save the Recipe");
            Console.WriteLine("3. Load Recipe");
            Console.WriteLine("4. View Recipes");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please enter a number to select an option:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    recipebook.AddRecipe();
                    break;
                /*case "2":
                    recipe.SaveToFile();
                    break;
                case "3":
                    recipe.LoadFromFile();
                    break;
                case "4":
                    recipe.DisplayRecipe();
                    break;*/
                case "5":
                    quit = true;
                    Console.WriteLine("Thank you for using the Recipe Book!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}