namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        // [Classes]
        // Person class is in Classes/Person.cs
        var person = Person.Parse("Robin");
        person.Introduce("Regina"); // Hi Regina, I am Robin

        // [Constructors]
        var customer = new Customer(1, "Robin");

        var order = new Order();
        customer.Orders.Add(order);

        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);
    }
}