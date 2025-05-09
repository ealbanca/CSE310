using System;
using System.Collections.Generic;

namespace RecipeBookApp.Services
{
    public class RecipeService
    {
        private List<Recipe> recipes;

        public RecipeService()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public List<Recipe> GetAllRecipes()
        {
            return recipes;
        }

        public Recipe GetRecipe(string name)
        {
            return recipes.Find(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayRecipes()
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            foreach (var recipe in recipes)
            {
                Console.WriteLine($"Name: {recipe.Name}");
                Console.WriteLine($"Ingredients: {string.Join(", ", recipe.Ingredients)}");
                Console.WriteLine($"Instructions: {recipe.Instructions}");
                Console.WriteLine();
            }
        }
    }
}