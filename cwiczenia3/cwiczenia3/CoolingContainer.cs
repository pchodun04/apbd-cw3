namespace cwiczenia3;

public class CoolingContainer : Container, IHazardNotifier
{
    private static int _coolingContainerCounter;
    public static string ProductName;
    public static double TemperatureInContainer;
    public Product Product;
    public CoolingContainer(int weight, int height, int loadWeight, int width, int maxLoadWeight, string productName, double temperature, Product product) : base(weight, height, loadWeight, width, maxLoadWeight)
    {
        SerialNumber += "C-" + _coolingContainerCounter++;
        ProductName = productName;
        TemperatureInContainer = temperature;
        Product = product;
    }

    public void NotifyWhenDangerousSituation()
    {
        Console.WriteLine("Dangerous situation with container " + SerialNumber);
    }
    
    
    
}