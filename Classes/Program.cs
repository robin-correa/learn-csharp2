namespace Classes;
using Methods;
using Fields;

class Program
{
    static void Main(string[] args)
    {
        // [Classes]
        Console.WriteLine("Classes:");
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

        Console.WriteLine("Methods:");
        // Overloading
        UsePoints();

        // Params modifier
        UseParams();

        // Out

        // Parse Method
        try
        {
            var num = int.Parse("21");
            Console.WriteLine(num);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Conversion failed (Parse).");
        }

        // TryParse Method (to demo out modifier)
        int number;
        var result = int.TryParse("22", out number);
        if (result)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Conversion failed (TryParse).");
        }

        // [Fields]

        Console.WriteLine("Fields:");
        var customer2 = new Customer2(1);
        customer2.Orders.Add(new Order());
        customer2.Orders.Add(new Order());
        Console.WriteLine(customer2.Orders.Count); // 2

        // To demo reinitialization of List object within the method
        customer2.Promote();
        Console.WriteLine(customer2.Orders.Count); // 0



    }
    static void UseParams()
    {
        // using params modifier to give a method the ability to receive varying number of parameters
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(1, 2, 3, 4));
        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
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
        catch (Exception)
        {

            Console.WriteLine("An unexpected error occured.");
        }
    }
}