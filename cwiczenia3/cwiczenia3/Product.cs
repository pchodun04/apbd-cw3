namespace cwiczenia3;

public class Product
{
    public string ProductName { get; set; }
    public int Temperature { get; set; }

    public Product(string productName, int temperature)
    {
        ProductName = productName;
        Temperature = temperature;
    }
}