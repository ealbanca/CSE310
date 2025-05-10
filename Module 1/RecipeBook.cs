/*Edwin Hared Albancando Robles*/
using System;

class RecipeBook
{
    public List<Recipe> recipes;
    public RecipeBook()
    {
        recipes = new List<Recipe>();
    }

    public void AddRecipe()
    {
        Console.WriteLine("Enter the title of the recipe:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the ingredients:");
        string ingredients = Console.ReadLine();
        Console.WriteLine("Enter the instructions:");
        string instructions = Console.ReadLine();
        recipes.Add(new Recipe(title, ingredients, instructions));
        Console.WriteLine("Recipe added successfully!");
    }

}