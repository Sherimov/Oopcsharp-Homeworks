using SEDC.Homework05.RacingCars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework05.RacingCars.Methods
{
    public class RaceMethod
    {
        public void RaceCars(Car carOne, Car carTwo)
        {

            int carOneSpeed = carOne.CalculateSpeed();
            int carTwoSpeed = carTwo.CalculateSpeed();
            if (carOneSpeed > carTwoSpeed)
                Console.WriteLine($"Car no. 1 was faster.The car that won was {carOne.Model} and it was droven by {carOne.Driver.Name}, with a speed of {carOne.Speed}");
            else
                Console.WriteLine($"Car no. 2 was faster.The car that won was {carTwo.Model} and it was droven by {carTwo.Driver.Name}, with a speed of {carTwo.Speed}");
        }

    }
}
