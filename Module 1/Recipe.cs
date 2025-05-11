/*Edwin Hared Albancando Robles*/
using System;
using Microsoft.VisualBasic;

class Recipe
{
    public string _title;
    public int _servings;
    public int _prepTime;
    public int _cookTime;
    public string _ingredients;
    public string _instructions;


    public Recipe(string title, int servings, int prepTime, int cookTime, string ingredients, string instructions)
    {
        _title = title;
        _servings = servings;
        _prepTime = prepTime;
        _cookTime = cookTime;
        _ingredients = ingredients;
        _instructions = instructions;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetIngredients()
    {
        return _ingredients;
    }
    public string GetInstructions()
    {
        return _instructions;
    }
    public override string ToString()
    {
        return $"Name of teh dish:{_title}\nIngredients: {_ingredients}\n Instructions:{_instructions}";
    }
}