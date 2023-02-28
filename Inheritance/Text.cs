namespace Inheritance;

public class Text : PresentationObject
{
    public int FontSize { get; set; }
    public string? FontName { get; set; }

    public void AddHyperlink(string url)
    {
        Console.WriteLine("We added a link to {0}", url);
    }

    public void Duplicate()
    {
        Console.WriteLine("Object was duplicated");
    }
}