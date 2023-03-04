namespace AccessModifiers;
public class Person2
{
    private DateTime _birthdate;
    public void SetBirthdate(DateTime birthdate)
    {
        _birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
        return _birthdate;
    }
}