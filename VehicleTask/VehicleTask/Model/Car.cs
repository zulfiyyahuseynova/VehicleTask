using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleTask.Model
{
    class Car:Vehicle
    {
        public string brand;
        public string model;
        public int fuelCapacity;
        public double fuelFor1Km;
        public double currentFuel;
        public double driveWay;

        public void ShowInfo()
        {
            Console.WriteLine($"Rengi:{color}, Ili:{year}, Brand:{brand}, Modeli:{model}, Yanacaq tutumu:{fuelCapacity}");
        }

        public void Drive(double driveWay, double fuelFor1Km, double currentFuel)
        {
            double result = currentFuel - (driveWay * fuelFor1Km);
            if (result>0)
            {
                Console.WriteLine("Avtomobil bu yolu gede biler");
            }
            else
            {
                Console.WriteLine("Avtomobil bu yolu gede bilmez");
            }
        }
        public Car()
        {

        }
        public Car(string color, int year, int fuelCapacity):base(year, color)
        {
            this.fuelCapacity = fuelCapacity;
        }
        public Car(int year, string brand):base(year)
        {
            this.brand = brand;
        }
        public Car(int year, string brand, string model):this(year,brand)
        {
            this.model = model;
        }
        public Car(int year, string brand, string model, double fuelFor1Km, int fuelCapacity):this(year,brand,model)
        {
            this.fuelFor1Km = fuelFor1Km;
            this.fuelCapacity = fuelCapacity;
        }
    }
}
