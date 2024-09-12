// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using ConsoleApp2.Algorithm;

try
{
    Console.WriteLine("Hello, World!");
    ElevatorSystem system = ElevatorSystem.GetInstance();
    Passenger Daniel = new Passenger(1, "Daniel");
    Passenger Tracy = new Passenger(2, "Tracy");
    Daniel.PressHallwayButton(13, Direction.DOWN);
    Tracy.PressHallwayButton(1, Direction.DOWN);
    system.Process();
    system.SetProcessAlgorithm(new LIFO());
    Daniel.PressHallwayButton(13, Direction.DOWN);
    Tracy.PressHallwayButton(1, Direction.DOWN);
    system.Process();

}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}

