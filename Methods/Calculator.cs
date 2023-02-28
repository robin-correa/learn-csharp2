namespace Methods;

public class Calculator
{
    // using params modifier to give a method the ability to receive varying number of parameters
    public int Add(params int[] numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }
}