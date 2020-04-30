using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework05.RacingCars.Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }

    }
}
