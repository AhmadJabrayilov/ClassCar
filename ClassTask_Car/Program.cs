using System;
using ClassTask_Car.Models;

namespace ClassTask_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car cr = new Car("Gray",2018,"chevrolet","Malibu",71.8, 0.16,15);
            cr.ShowInfo();
            Console.WriteLine("------- ------- ------- ------- -------");
            Console.WriteLine($"Current fuel: {cr.Drive(65).ToString("0.00")}");


        }
    }
}
