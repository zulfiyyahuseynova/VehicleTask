using System;
using VehicleTask.Model;

namespace VehicleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car {color="Qara", year=2016, brand="Hyundai", model="Sonata", fuelCapacity=40};
            car1.ShowInfo();
            Car car2 = new Car("Ag",2018,15);
            Console.WriteLine($"{car2.color} {car2.year} {car2.fuelCapacity}");
            car2.Drive(3.5, 2.4, 15.8);

        }
    }
}
