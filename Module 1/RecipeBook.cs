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

    public void Save()
    {
        Console.WriteLine("Enter the file name to save the recipe:");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Recipe recipe in recipes)
            {
                writer.WriteLine($"{recipe.GetTitle()},{recipe.GetServings()}, {recipe.GetPrepTime()}. {recipe.GetCookTime()}, {recipe.GetIngredients().Replace(",", ",,")},{recipe.GetInstructions().Replace(",", ",,")}");
            }
        }
        Console.WriteLine("Recipes saved successfully!");
    }

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
                    int servings = int.Parse(parts[1]);
                    int prepTime = int.Parse(parts[2]);
                    int cookTime = int.Parse(parts[3]); string ingredients = parts[1].Replace(",,", ",");
                    string instructions = parts[2].Replace(",,", ",");
                    recipes.Add(new Recipe(title, servings, prepTime, cookTime, ingredients, instructions));
                }
            }
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