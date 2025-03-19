namespace cwiczenia3;

public class CoolingContainer : Container, IHazardNotifier
{
    private static int _coolingContainerCounter = 0;
    public CoolingContainer(int weight, int height, int loadWeight, int width, int maxLoadWeight) : base(weight, height, loadWeight, width, maxLoadWeight)
    {
        SerialNumber += "C-" + _coolingContainerCounter++;
    }

    public void NotifyWhenDangerousSituation()
    {
        Console.WriteLine("Dangerous situation with container " + SerialNumber);
    }
}