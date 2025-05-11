/*Edwin Hared Albancando Robles*/
using System;
using Microsoft.VisualBasic;
// The class recipe will hold the information of the recipe
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
    //all these methods are getters that will return the information of the recipe
    public string GetTitle()
    {
        return _title;
    }

    public int GetServings()
    {
        return _servings;
    }
    public int GetPrepTime()
    {
        return _prepTime;
    }
    public int GetCookTime()
    {
        return _cookTime;
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
        return $"Name of the dish:{_title}\nServings: {_servings}\nPreparation Time: {_prepTime}\nCooking Time: {_cookTime}\nIngredients: {_ingredients}\nInstructions:{_instructions}";
    }
}