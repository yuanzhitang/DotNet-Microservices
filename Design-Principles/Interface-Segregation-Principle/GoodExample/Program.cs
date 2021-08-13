using System;


namespace Design_Principles.Interface_Segregation_Principle.GoodSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(new Car());
            driver.Drive();
        }
    }
}