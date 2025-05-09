public class Recipe
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public string Instructions { get; set; }

    public Recipe()
    {
        Ingredients = new List<string>();
    }

    public void AddIngredient(string ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public void DisplayRecipe()
    {
        Console.WriteLine($"Recipe Name: {Name}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }
        Console.WriteLine($"Instructions: {Instructions}");
    }
}