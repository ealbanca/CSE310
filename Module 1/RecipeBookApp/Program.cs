// filepath: /RecipeBookApp/RecipeBookApp/Program.cs
using System;
using RecipeBookApp.Models;
using RecipeBookApp.Services;

class Program
{
    static void Main(string[] args)
    {
        RecipeService recipeService = new RecipeService();
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Welcome to your Recipe Book!");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Save Recipe");
            Console.WriteLine("3. Load Recipe");
            Console.WriteLine("4. View Recipes");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please enter a number to select an option:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    recipeService.AddRecipe();
                    break;
                case "2":
                    recipeService.SaveToFile();
                    break;
                case "3":
                    recipeService.LoadFromFile();
                    break;
                case "4":
                    recipeService.DisplayRecipes();
                    break;
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