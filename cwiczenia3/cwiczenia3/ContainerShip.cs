namespace cwiczenia3;

public class ContainerShip
{
    private static int _containerCounter;
    private static int _containersCurrentWeight;
    public static List<Container> Containers = new List<Container>();
    public static double MaxSpeed;
    public static int MaxContainers;
    public static double MaxWeight;

    public ContainerShip(double maxSpeed, int maxContainers, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void AddContainer(Container container)
    {
        if (_containersCurrentWeight + container.Weight > MaxWeight)
        {
            throw new Exception("Weight exceed maximum weight");
        }else if(_containerCounter > MaxContainers)
        {
            throw new Exception("Number of containers exceed maximum containers");
        }
        _containersCurrentWeight += container.Weight;
        _containerCounter++;
        Containers.Add(container);
    }

    public void AddContainers(List<Container> containers)
    {
        Containers.AddRange(containers);
    }

    public void RemoveContainer(Container container)
    {
        Containers.Remove(container);
    }

    public void ReplaceContainer(Container oldContainer, Container newContainer)
    {
        int index = Containers.IndexOf(oldContainer);
        if(index == -1)
            throw new Exception("Container not found");
        else Containers[index] = newContainer;
    }
    
}