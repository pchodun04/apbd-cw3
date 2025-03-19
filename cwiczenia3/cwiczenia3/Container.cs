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

    public void EmptyContainer()
    {
        LoadWeight = 0;
    }

    public void LoadContainer(int loadWeight)
    {
        if (loadWeight > MaxLoadWeight)
        {
            throw new OverfillException("Load weight is too big");
        }
    }
}