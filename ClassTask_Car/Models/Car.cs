using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask_Car.Models
{
    internal class Car:Vehicle
    {
        //fields
        public string brand;
        public string model;
        public double fuelCapacity;
        public double fuelFor1km;
        public double currentFuel;

        public Car(string color, int year, string brand, string model, double fuelCapacity  ,double fuelFor1km, double currentFuel) : base(color, year)
        {
            this.brand = brand;
            this.model = model;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1km = fuelFor1km;
            this.currentFuel = currentFuel;
        }

        public Car()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Color: {color}\nYear: {year}\nBrand: {brand.ToUpper()}\nModel: {model.ToUpper()}\nFuel Capacity: {fuelCapacity} L\nFuel for 1 Km: {fuelFor1km}L\nCurrent fuel: {currentFuel}");
        }

        public double Drive(int distance)
        {
            if(distance * fuelFor1km > currentFuel)
            {
                Console.WriteLine($"The fuel not enough for this distance! \nYou need to add a MINIMUM of {((distance * fuelFor1km)-currentFuel).ToString("0.00")}L of fuel for finish distance.");
            }
            
            else
            {
                for(int i=distance; i>=1; i--)
                {
                    currentFuel -= 0.16;
                }
                
                Console.WriteLine("After the specified distance\nRemaining fuel ↓↓↓");
            }
            return currentFuel;
                

        }



    }
}
