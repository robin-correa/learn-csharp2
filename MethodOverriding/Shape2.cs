namespace MethodOverriding;

public class Shape2
{
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual void Draw()
    {

    }
}

public class Circle2 : Shape2
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Circle");
    }
}

public class Rectangle2 : Shape2
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Rectangle");
    }
}

public class Triangle2 : Shape2
{
    public override void Draw()
    {
        Console.WriteLine("Draw a Triangle");
    }
}