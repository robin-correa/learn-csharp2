namespace Properties;
public class Person3
{
    public string? Name { get; set; }
    public string? Username { get; set; }
    public DateTime Birthdate { get; private set; }
    public Person3(DateTime birthdate)
    {
        Birthdate = birthdate;
    }

    // Readonly
    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;
            return years;
        }
    }

}