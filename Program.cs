// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

try
{
    Console.WriteLine("Hello, World!");
    ElevatorSystem system = ElevatorSystem.GetInstance();
    Passenger Daniel = new Passenger(1, "Daniel");
    Passenger Tracy = new Passenger(2, "Tracy");
    Daniel.PressHallwayButton(13, Direction.DOWN);
    Daniel.PressElevatorButton(0, 15);
    //Tracy.PressHallwayButton(1, Direction.DOWN);

}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
}

