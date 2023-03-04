namespace Classes;
using Methods;
using Fields;
using AccessModifiers;
using Properties;
using Indexers;
using Inheritance;
using Composition;
using Casting;
using Constructors;
using MethodOverriding;
using AbstractClasses;
using InterfaceAsPolymorphism;

class Program
{
    static void Main(string[] args)
    {
        // [Classes]
        Console.WriteLine("[Classes]");
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
        // using Methods/;
        Console.WriteLine("[Methods]");
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
        // using Fields/;

        Console.WriteLine("[Fields]");
        var customer2 = new Customer2(1);
        customer2.Orders.Add(new Order());
        customer2.Orders.Add(new Order());
        Console.WriteLine(customer2.Orders.Count); // 2

        // To demo reinitialization of List object within the method
        customer2.Promote();
        Console.WriteLine(customer2.Orders.Count); // 0

        // [Access Modifiers]
        // using AccessModifiers/;
        /*
            Notes:
            - In C# we have 5 access modifiers: public, private, protected, internal and protected internal.
            - A class member declared with public is accessible everywhere.
            - A class member declared with private is accessible only from inside the class.
            - We use access modifiers to hide the implementation details of a class. So anything that is about “how” a class does its job should be declared as private. This way, we make sure other parts of the code will not touch the implementation detail of a class. 
            And as a result we improve the robustness of our code. If change the implementation of a class, we only need to make changes inside the class. No other parts of the code will need to be changed.
        */

        Console.WriteLine("[Access Modifiers]");
        var person2 = new Person2();
        person2.SetBirthdate(new DateTime(1994, 11, 21));
        Console.WriteLine(person2.GetBirthdate()); // 21/11/1994 00:00:00

        // [Properties]
        // using Properties/;

        /*
            - A property is a kind of class member that is used for providing access to fields of a class.
            - As a best practice, we must declare fields as private and create public properties to provide access to them.
            - A property encapsulates a get and a set method
        */

        Console.WriteLine("[Properties]");
        var person3 = new Person3(new DateTime(1994, 11, 21));
        Console.WriteLine(person3.Age); // 28 (as of 28 Feb 2023)

        // [Indexers]
        // using Indexers/;

        /*
        - Indexer is a special kind of property that allows accessing elements of a list by an index.
        - If a class has the semantics of a list, or collection, we can define an indexer property for it. This way it's easier to get or set items in the collection.
        */
        Console.WriteLine("[Indexers]");
        var cookie = new HttpCookie();
        cookie["name"] = "Robin";
        Console.WriteLine(cookie["name"]);

        // [Inheritance]
        // using Inheritance/;
        Console.WriteLine("[Inheritance]");
        var text = new Text();
        text.Width = 100;
        text.Copy(); // Object copied to clipboard (from PresentationObject class)

        // [Composition]
        // using Composition/;
        Console.WriteLine("[Composition]");
        var dbMigrator = new DBMigrator(new Logger());
        var logger = new Logger();
        var installer = new Installer(logger);
        dbMigrator.Migrate(); // We are migrating....
        installer.Install(); // We are installing....

        /*
            Notes:
                Class Coupling
                    - A measure of how interconnected classes and subsystems are.
                    - The more coupled classes, the harder it is to change them. A change in one class may affect many other classes.
                    - Loosely coupled software, as opposed to tightly coupled software, is easier to change.
                    - Two types of relationships between classes: Inheritance and Composition.

                Inheritance
                    - A kind of relationship between two classes that allows one to inherit code from the other.
                    - Referred to as Is-A relationship: A Car is a Vehicle
                    - Benefits: code re-use and polymorphic behaviour.

                Composition
                    - A kind of relationship that allows one class to contain another.
                    - Referred to as Has-A relationship: A Car has an Engine
                    - Benefits: Code re-use, flexibility and a means to loose-coupling

                    Favour Composition over Inheritance
                    - Problems with inheritance:
                        - Easily abused by amateur designers / developers
                        - Leads to large complex hierarchies
                        - Such hierarchies are very fragile and a change may affect many classes
                        - Results in tight coupling
                    - Benefits of composition:
                        - Flexible
                        - Leads to loose coupling
                        - Having said all that, it doesn't mean inheritance should be avoided at all times. 
                        In fact, it's great to use inheritance when dealing with very stable classes on top of small hierarchies. 
                        As the hierarchy grows (or variations of classes increase), the hierarchy, however, becomes fragile. 
                        And that's where composition can give you a better design.
        */

        // [Casting]
        // using Casting/;
        Console.WriteLine("[Casting] (No output)");

        // Upcasting (implicit)
        Circle circle = new Circle();
        Shape shape = circle; // In the background: it's casted as Shape class, no conversion is required

        // Downcasting
        Circle anotherCircle = (Circle)shape;

        // Car car = (Car) shape; // throws InvalidCastException

        // To prevent InvalidCastException, use "as" keyword
        /*
            Car car = (Car) obj; // Error
            Car car = obj as Car;

            if (car != null) {
                ...
            }

            // "is" keyword is used to check the type of an object
            if (obj is Car) {
                Car car = (Car) obj;
            }
        */

        // [Constructors]
        // using Constructors/;
        Console.WriteLine("[Constructors]");
        var car = new Car("XYZ1234");
        /*
            Output in sequence:
            Vehicle is being initialized. XYZ1234
            Car is being initialized. XYZ1234
        */

        // [Boxing and Unboxing]
        // Boxing - Boxing happens when a value type instance is converted to an object reference.
        object obj = 1;

        // Unboxing - Unboxing is the opposite: when an object reference is converted to a value type.
        int i = (int)obj;

        // [Method Overriding]
        // using MethodOverriding/;
        Console.WriteLine("[Method Overriding]");
        var shapes2 = new List<Shape2>();
        shapes2.Add(new Circle2());
        shapes2.Add(new Rectangle2());
        shapes2.Add(new Triangle2());

        var canvas = new Canvas();
        canvas.DrawShapes(shapes2);
        /* Output:
            Draw a Circle
            Draw a Rectangle
            Draw a Triangle
        */

        // [Abstract Classes]
        // using AbstractClasses/;
        Console.WriteLine("[Abstract Classes]");
        var circle3 = new Circle3();
        circle3.Draw(); // Draw a Circle

        var rectangle3 = new Rectangle3();
        rectangle3.Draw(); // Draw a Rectangle

        /*
            Notes:
                Method Overriding
                - Method overriding means changing the implementation of an inherited method.
                - If a declare a method as virtual in the base class, we can override it in a derived class.

                Abstract Classes and Members
                - Abstract modifier states that a class or a member misses implementation. 
                    We use abstract members when it doesn’t make sense to implement them in a base class. 
                    For example, the concept of drawing a shape is too abstract. We don’t know how to draw a shape. 
                    This needs to be implemented in the derived classes.
                - When a class member is declared as abstract, that class needs to be declared as abstract as well. That means that class is not complete.
                - In derived classes, we need to override the abstract members in the base class.

                Sealed Classes and Members
                - If applied to a class, prevents derivation from that class.
                - If applied to a method, prevents overriding of that method in a derived class.
                - The string class is declared as sealed, and that’s why we cannot inherit from it.

        */

        // [Interface As Polymorphism]
        // using InterfaceAsPolymorphism/;
        Console.WriteLine("[Interface as Polymorphism]");
        var encoder = new VideoEncoder();
        encoder.RegisterNotificationChannel(new MailNotificationChannel());
        encoder.RegisterNotificationChannel(new SmsNotificationChannel());
        encoder.Encode(new Video());

        /*
        Notes:
         Interfaces and Inheritance
        - One of the common misconceptions about interfaces is that they are used to implement multiple inheritance in C#. This is fundamentally wrong, yet many books and videos make such a false claim.
        - With inheritance, we write code once and re-use it without the need to type all that code again.
        - With interfaces, we simply declare the members the implementing class should contain. Then we need to type all that declaration along with the actual implementation in that class. So, code is not inherited, even the declaration of the members!
        */
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