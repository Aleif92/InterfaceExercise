using System;

namespace InterfaceExercise;

public class Car: IVehicle, ICompany
{
    public int NumberOfWheels { get; set; } = 4;
    public string Make { get; set; } = "Chevy";
    public string Model { get; set; } = "Impala";
    public double EngineSize { get; set; } = 4.6;
    public bool Is4WheelDrive { get; set; } = true;
    public string Name { get; set; } = "Impala";
    public string CompanyMotto { get; set; } = "We Sell cars";
    
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

    
};