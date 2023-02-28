namespace Classes;
using Methods;

class Program
{
    static void Main(string[] args)
    {
        // [Classes]
        // Person class is in Classes/Person.cs
        var person = Person.Parse("Robin");
        person.Introduce("Regina"); // Hi Regina, I am Robin

        // [Constructors]
        //var customer = new Customer(1, "Robin");
        var customer = new Customer();
        var order = new Order();
        customer.Orders.Add(order);

        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);

        // [Methods]
        UsePoints();


    }
    static void UsePoints()
    {
        try
        {
            var point = new Point(10, 2);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); // Point is at (40, 60)

            // Overloading
            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); // Point is at (100, 200)
        }
        catch (System.Exception)
        {

            System.Console.WriteLine("An unexpected error occured.");
        }
    }
}