// See https://aka.ms/new-console-template for more information


using cwiczenia3;

List<Container> containers = new List<Container>();
Product banana = new Product("banana", 15);
ContainerShip ship1 = new ContainerShip(25.5,5,50.5);
ContainerShip ship2 = new ContainerShip(25.5,5,50.5);
Container gasContainer = new GasContainer(10,2,5,5,5,10);
Container gasContainer2 = new GasContainer(10,2,5,5,5,10);
Container lqContainer = new LiquidContainer(2,2,2,5,5, false);
Container coolContainer = new CoolingContainer(10,2,5,5,5, banana);
containers.Add(lqContainer);
containers.Add(coolContainer);
lqContainer.LoadContainer(2);
coolContainer.LoadContainer(5);
gasContainer.LoadContainer(5);
ship1.AddContainer(gasContainer);
ship1.AddContainer(gasContainer2);
ship2.AddContainers(containers);
ship2.RemoveContainer(coolContainer);
lqContainer.EmptyContainer();
ship1.ReplaceContainer(gasContainer, lqContainer);
ship1.MoveContainers(ship1, ship2, gasContainer2);
Console.WriteLine(gasContainer);
Console.WriteLine(ship1);