namespace cwiczenia3;

public class GasContainer : Container, IHazardNotifier
{
    private static int _gasContainerCounter;
    public GasContainer(int weight, int height, int loadWeight, int width, int maxLoadWeight) : base(weight, height, loadWeight, width, maxLoadWeight)
    {
        SerialNumber += "G-" + _gasContainerCounter++;
    }
    public void NotifyWhenDangerousSituation()
    {
        Console.WriteLine("Dangerous situation with container " + SerialNumber);
    }
}