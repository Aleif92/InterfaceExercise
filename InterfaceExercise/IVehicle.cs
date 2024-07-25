using System.Dynamic;

namespace InterfaceExercise;

public interface IVehicle
{
      /* Create 4 members that Car, Truck, & SUV all have in common.
                     * Example: public int NumberOfWheels { get; set; }
                     */
      
      
      
      public int NumberOfWheels { get; set; }
      public string Make { get; set; }
      public string Model { get; set; }
      public double EngineSize { get; set; }
      public bool Is4WheelDrive { get; set; }
      

      public void Drive();
      public void Reverse();
      public void Park();

     
}