/*Edwin Hared Albancando Robles*/
using System;

class Recipe
{
    public string _date;
    public string _title;
    public string _content;

    public Recipe(string date, string title, string content)
    {
        _date = date;
        _title = title;
        _content = content;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetContent()
    {
        return _content;
    }
    public override string ToString()
    {
        return $"Date:{_date} - Name of the recipe:{_title}\n{_content}";
    }
}