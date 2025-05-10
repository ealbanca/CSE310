/*Edwin Hared Albancando Robles*/
using System;

class Recipe
{
    public string _title;
    public string _ingredients;
    public string _instructions;


    public Recipe(string title, string ingredients, string instructions)
    {
        _title = title;
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