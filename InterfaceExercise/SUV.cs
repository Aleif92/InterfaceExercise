using System;

namespace InterfaceExercise;

public class SUV: IVehicle, ICompany
{
    public int NumberOfWheels { get; set; } = 4;
    public string Make { get; set; } = "Ford";
    public string Model { get; set; } = "Explorer";
    public double EngineSize { get; set; } = 4.0;
    public bool Is4WheelDrive { get; set; } = true;
    

    public void Drive()
    {
        Console.WriteLine($"The {GetType().Name} is now driving forward");
    }

    public void Reverse()
    {
        Console.WriteLine($"The {GetType().Name} is now driving in reverse");
    }

    public void Park()
    {
        Console.WriteLine($"The {GetType().Name} is now parked");
    }



    public string Name { get; set; } = "Explorer";
    public string CompanyMotto { get; set; } = "We sell cars";
}