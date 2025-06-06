/*Edwin Hared Albancando Robles*/
using System;
using System.IO;
// This class is the recipebook, the one that will "hold" the recipes
class RecipeBook
{
    public List<Recipe> recipes;
    public RecipeBook()
    {
        recipes = new List<Recipe>();
    }
    // This method will add a recipe to the recipebook, will read the user input and will create a new recipe
    public void AddRecipe()
    {
        Console.WriteLine("Enter the title of the recipe:");
        string title = Console.ReadLine();
        Console.WriteLine("Enter the number of servings:");
        int servings = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the preparation time (in minutes):");
        int prepTime = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the cooking time (in minutes):");
        int cookTime = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ingredients:");
        string ingredients = Console.ReadLine();
        Console.WriteLine("Enter the instructions:");
        string instructions = Console.ReadLine();
        recipes.Add(new Recipe(title, servings, prepTime, cookTime, ingredients, instructions));
        Console.WriteLine("Recipe added successfully!");
    }
    // This method will save the recipes to a file using a StreamWriter
    public void Save()
    {
        Console.WriteLine("Enter the file name to save the recipe:");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Recipe recipe in recipes)
            {
                writer.WriteLine($"{recipe.GetTitle()},{recipe.GetServings()}, {recipe.GetPrepTime()}, {recipe.GetCookTime()}, {recipe.GetIngredients().Replace(",", ",,")},{recipe.GetInstructions().Replace(",", ",,")}");
            }
        }
        Console.WriteLine("Recipes saved successfully!");
    }
    // This method will load the recipes from a file using a StreamReader
    public void Load()
    {
        Console.WriteLine("Enter the existing file name to load the recipe:");
        string fileName = Console.ReadLine();
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { "," }, StringSplitOptions.None);
                    string title = parts[0];
                    string servings = parts[1];
                    string prepTime = parts[2];
                    string cookTime = parts[3];
                    string ingredients = parts[4].Replace(",,", ",");
                    string instructions = parts[5].Replace(",,", ",");
                    recipes.Add(new Recipe(title, int.Parse(servings), int.Parse(prepTime), int.Parse(cookTime), ingredients, instructions));
                }
            }
            Console.WriteLine("Recipes loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }


    }
    // This method will display the recipes from the previous loaded file
    public void DisplayRecipes()
    {
        Console.WriteLine("Recipes:");
        foreach (Recipe recipe in recipes)
        {
            Console.WriteLine(recipe.ToString());
        }
    }


}