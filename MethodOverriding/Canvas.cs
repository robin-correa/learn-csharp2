namespace MethodOverriding;

public class Canvas
{

    public virtual void DrawShapes(List<Shape2> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
