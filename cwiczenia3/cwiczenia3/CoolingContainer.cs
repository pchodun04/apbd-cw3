namespace cwiczenia3;

public class CoolingContainer : Container, IHazardNotifier
{
    private static int _coolingContainerCounter;
    public static string ProductName;
    public static double TemperatureInContainer;
    public Product Product;
    public List<Product> products = new List<Product>();
    public CoolingContainer(int weight, int height, int loadWeight, int width, int maxLoadWeight, Product product) : base(weight, height, width, maxLoadWeight)
    {
        SerialNumber += "C-" + _coolingContainerCounter++;
        Product = product;
        products.Add(product);
        ProductName = product.ProductName;
        TemperatureInContainer = product.Temperature;
    }

    public void NotifyWhenDangerousSituation()
    {
        Console.WriteLine("Dangerous situation with container " + SerialNumber);
    }

    public void AddProduct(Product product)
    {
        if (product.ProductName == ProductName)
        {
            if (product.Temperature <= TemperatureInContainer)
            {
                products.Add(product);
            }
            else throw new Exception("Temperature of product is not good.");
        }
        else throw new Exception("Product name is not equal to the container.");
    }

    public override void EmptyContainer()
    {
        LoadWeight = 0;
        products.Clear();
    }
    public override string ToString()
    {
        return "own weight:" + OwnWeight + " height:" + Height + " loadweight:" + LoadWeight + " width:" + Width + " maxloadweight:" + MaxLoadWeight + " Products:" + products + base.ToString();
    }
}