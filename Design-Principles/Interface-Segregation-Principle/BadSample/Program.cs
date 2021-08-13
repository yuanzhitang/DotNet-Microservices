using System;


namespace Design_Principles.Interface_Segregation_Principle.BadSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(new ElectricVehicle());
            driver.Drive();
        }
    }
}