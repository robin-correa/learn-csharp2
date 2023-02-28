namespace Fields;

using Classes;
public class Customer2
{
    public int Id;
    public string Name;
    // Add "readonly" modifier if you think you can only initialize the object once.
    public readonly List<Order> Orders = new List<Order>();

    public Customer2(int id)
    {
        this.Id = id;
    }

    public Customer2(int id, string name)
        : this(id)
    {
        this.Name = name;
    }

    public void Promote()
    {
        // Orders = new List<Order>(); // Compile time error due to readonly (if this line accidentally initialized)
    }
}