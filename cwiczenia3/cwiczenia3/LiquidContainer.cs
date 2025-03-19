namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    private static bool _isDangerous;
    private static int _liquidContainerCounter;
    public LiquidContainer(int weight, int height, int loadWeight, int width, string serialNumber, int maxLoadWeight) : base(weight, height, loadWeight, width, maxLoadWeight)
    {
        SerialNumber += "L-" + _liquidContainerCounter++;
    }

    public LiquidContainer(int weight, int height, int loadWeight, int width, int maxLoadWeight) : base(weight, height, loadWeight, width, maxLoadWeight)
    {
        SerialNumber += "L-" + _liquidContainerCounter++;
        _isDangerous = _isDangerous;
    }

    public void NotifyWhenDangerousSituation()
    {
        Console.WriteLine("Dangerous situation with container " + SerialNumber);
    }

    public void LoadContainer(int weight)
    {
        base.LoadContainer(weight);
        
    }
}