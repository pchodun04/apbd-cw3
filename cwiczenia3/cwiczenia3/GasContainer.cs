namespace cwiczenia3;

public class GasContainer : Container, IHazardNotifier
{
    private static int _gasContainerCounter;
    private static int _gasPressure;
    public GasContainer(int weight, int height, int loadWeight, int width, int maxLoadWeight, int gasPressure) : base(weight, height, loadWeight, width, maxLoadWeight)
    {
        SerialNumber += "G-" + _gasContainerCounter++;
        _gasPressure = gasPressure;
    }
    public void NotifyWhenDangerousSituation()
    {
        Console.WriteLine("Dangerous situation with container " + SerialNumber);
    }

    public override void EmptyContainer()
    {
        LoadWeight = (int)(LoadWeight * 0.05);
    }

    public override void LoadContainer(int weight)
    {
        if (weight > MaxLoadWeight)
        {
            throw new OverfillException("The maximum load weight has been reached.");
        }else base.LoadContainer(weight);
    }
}