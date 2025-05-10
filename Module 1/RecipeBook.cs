/*Edwin Hared Albancando Robles*/
using System;
using System.Text.Json;

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

    public void Save()
    {
        Console.WriteLine("Enter the file name to save the recipe:");
        string fileName = Console.ReadLine();
        string json = JsonSerializer.Serialize(recipes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, json);
        Console.WriteLine("Recipes saved successfully!");
    }

    public void Load()
    {
        Console.WriteLine("Enter the existing file name to load the recipe:");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            recipes = JsonSerializer.Deserialize<List<Recipe>>(json) ?? new List<Recipe>();
            Console.WriteLine("Recipes loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }


    public void DisplayRecipes()
    {
        Console.WriteLine("Recipes:");
        foreach (Recipe recipe in recipes)
        {
            Console.WriteLine(recipe.ToString());
        }
    }


}