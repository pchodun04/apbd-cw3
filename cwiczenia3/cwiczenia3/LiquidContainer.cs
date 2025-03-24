namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    private static bool _isDangerous;
    private static int _liquidContainerCounter;
    
    public LiquidContainer(int weight, int height, int loadWeight, int width, int maxLoadWeight, bool isDangerous) : base(weight, height, loadWeight, width, maxLoadWeight)
    {
        SerialNumber += "L-" + _liquidContainerCounter++;
        _isDangerous = isDangerous;
    }

    public void NotifyWhenDangerousSituation()
    {
        Console.WriteLine("Dangerous situation with container " + SerialNumber);
    }

    public override void LoadContainer(int weight)
    {
        if (_isDangerous)
        {
            if (weight > MaxLoadWeight/2)
            {
                throw new OverfillException("You can't load more than a half of maximum load weight");
            }else base.LoadContainer(weight);
        }
        else
        {
            if (weight > MaxLoadWeight*0.9)
            {
                throw new OverfillException("You can't load more than 90% of maximum load weight");
            }else base.LoadContainer(weight);
        }
    }
    public override string ToString()
    {
        return "weight:" + Weight + " height: " + Height + " loadweight: " + LoadWeight + " width: " + Width + " maxloadweight: " + MaxLoadWeight + " is dangerous: " + _isDangerous + base.ToString();
    }
}