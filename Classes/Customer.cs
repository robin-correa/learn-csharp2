namespace Classes;
public class Customer
{
    public int? Id;
    public string? Name;
    public List<Order> Orders;

    public Customer()
    {
        Orders = new List<Order>();
    }

    /* Can be removed, but retained for the sake of demonstration
        // method overloading #1
        public Customer(int id)
            : this() // To call the first constructor (Minimum)
        {
            this.Id = id;
        }

        // method overloading #2
        public Customer(int id, string name)
            : this(id) // To call the second contructor (Not recommended)
        {
            this.Id = id;
            this.Name = name;
        }
        */
}