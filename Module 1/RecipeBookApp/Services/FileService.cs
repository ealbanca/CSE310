using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RecipeBookApp.Services
{
    public class FileService
    {
        private readonly string filePath = "recipes.json";

        public void SaveToFile(List<Recipe> recipes)
        {
            var json = JsonSerializer.Serialize(recipes);
            File.WriteAllText(filePath, json);
        }

        public List<Recipe> LoadFromFile()
        {
            if (!File.Exists(filePath))
            {
                return new List<Recipe>();
            }

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Recipe>>(json) ?? new List<Recipe>();
        }
    }
}