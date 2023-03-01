namespace AbstractClasses;

public abstract class Shape3
{
    public int Width { get; set; }
    public int Height { get; set; }

    public abstract void Draw();

    public void Copy()
    {
        Console.WriteLine("Copy shape into clipboard.");
    }

    public void Select()
    {
        Console.WriteLine("Select the shape.");
    }
}

public class Circle3 : Shape3
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Circle");
    }
}

public class Rectangle3 : Shape3
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Rectangle");
    }
}

public class Triangle3 : Shape3
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Triangle");
    }
}