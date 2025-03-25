namespace cwiczenia3;

public abstract class Container
{
    public int OwnWeight {get;set;}
    public int Height {get;set;}
    public int LoadWeight {get;set;}
    public int Width {get;set;}
    public string SerialNumber {get;set;}
    public int MaxLoadWeight {get;set;}

    public Container(int weight, int height, int width, int maxLoadWeight)
    {
        OwnWeight = weight;
        Height = height;
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
        LoadWeight = loadWeight;
    }

    public override string ToString()
    {
        return " own weight: " + OwnWeight + " height: " + Height + " loadweight: " + LoadWeight + " width: " + Width;
    }
}