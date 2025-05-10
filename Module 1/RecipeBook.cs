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

    public void Save()
    {
        Console.WriteLine("Enter the file name to save the recipe:");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Recipe recipe in recipes)
            {
                writer.WriteLine($"{recipe.GetTitle()},{recipe.GetIngredients().Replace(",", ",,")},{recipe.GetInstructions().Replace(",", ",,")}");
            }
        }
        Console.WriteLine("Recipes saved successfully!");
    }

}