namespace cwiczenia3;

public class OverfillExeption : Exception
{
    public OverfillExeption(string? message) : base(message)
    {
        Console.WriteLine(message);
    }
}