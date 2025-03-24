namespace cwiczenia3;

public class Container
{
    public int Weight {get;set;}
    public int Height {get;set;}
    public int LoadWeight {get;set;}
    public int Width {get;set;}
    public string SerialNumber {get;set;}
    public int MaxLoadWeight {get;set;}

    public Container(int weight, int height, int loadWeight, int width, int maxLoadWeight)
    {
        Weight = weight;
        Height = height;
        LoadWeight = loadWeight;
        Width = width;
        SerialNumber = "KON-";
        MaxLoadWeight = maxLoadWeight;
    }

    public virtual void EmptyContainer()
    {
        LoadWeight = 0;
    }

    public virtual void LoadContainer(int loadWeight)
    {
        if (loadWeight > MaxLoadWeight)
        {
            throw new OverfillException("Load weight is too big");
        }
    }

    public override string ToString()
    {
        return "weight: " + Weight + " height: " + Height + " loadweight: " + LoadWeight + " width: " + Width;
    }
}